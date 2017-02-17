using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.SQLite;
using MetroFramework.Controls;
using MetroFramework.Forms;
using botty.helpers;
using TwitchLib;
using TwitchLib.Models.Client;
using System.Text.RegularExpressions;

namespace botty
{
    public partial class Main : MetroForm
    {
        public string username { get; set; }
        public string oauth { get; set; }
        public string channel { get; set; }
        public TwitchClient client { get; set; }
        public BackgroundWorker worker { get; set; }
        public DataSet commands { get; set; }
        public string ConnectionString { get; set; }

        public BindingList<User> Users { get; set; }

        public BindingList<Song> songs { get; set; }

        public DEG.YouTube.YouTubeService yt { get; set; }
        public Main()
        {
            InitializeComponent();
            /* set the empty Users List */
            Users = new BindingList<User>();
            songs = new BindingList<Song>();
            /* Set the worker */
            worker = new BackgroundWorker();
            worker.DoWork += Worker_DoWork;
            worker.WorkerSupportsCancellation = true;
            worker.RunWorkerAsync();

            /* set style for legacy controls */
            sExtender.SetApplyMetroTheme(groupBox2, true);
            sExtender.SetApplyMetroTheme(groupBox1, true);
            sExtender.SetApplyMetroTheme(dtgv_commands, true);
            sExtender.SetApplyMetroTheme(ytplayer, true);
            sExtender.Theme = sManager.Theme;
            sExtender.Style = sManager.Style;

            lbl_status.Style = MetroFramework.MetroColorStyle.Red;

            commands = new DataSet();
            /* get the actual connection to the database */
            ConnectionString = "Data Source=lucyybot.sqlite3;Version=3;";
            /* get the commands to put in the correct tab */
            getCommands();

            setup();
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            mg_users.BeginInvoke((MethodInvoker)delegate ()
            {
                mg_users.DataSource = Users;
            });
            songs_grid.BeginInvoke((MethodInvoker)delegate () {
                songs_grid.DataSource = songs;
            });
        }

        private void getCommands()
        {
            using(SQLiteConnection db = new SQLiteConnection(ConnectionString))
            {
                db.Open();
                using(SQLiteCommand dbCommand =  new SQLiteCommand("SELECT * FROM `commands`", db))
                {
                    using(SQLiteDataAdapter dbAdapter = new SQLiteDataAdapter(dbCommand))
                    {
                        dbAdapter.Fill(commands);
                    }
                }
            }            
            /* fill the datagridview and remove id from view */
            dtgv_commands.DataSource = commands.Tables["table"];
            dtgv_commands.Columns["id"].Visible = false;
        }
        private void metroLabel1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            oauth o = new oauth();
            o.ShowDialog();
        }

        private void setup()
        {

            string username, password, channel;
            using (SQLiteConnection db = new SQLiteConnection(ConnectionString))
            {
                db.Open();
                using (SQLiteCommand dbCommand = new SQLiteCommand("SELECT value FROM `settings` WHERE `name`='username' LIMIT 1", db))
                {
                    username = (string)dbCommand.ExecuteScalar();
                }
                using (SQLiteCommand dbCommand = new SQLiteCommand("SELECT value FROM `settings` WHERE `name`='password' LIMIT 1", db))
                {
                    password = (string)dbCommand.ExecuteScalar();
                }
                using (SQLiteCommand dbCommand = new SQLiteCommand("SELECT value FROM `settings` WHERE `name`='channel' LIMIT 1", db))
                {
                    channel = (string)dbCommand.ExecuteScalar();
                }
            }

            if (!string.IsNullOrEmpty(username))
            {
                tbx_username.Text = username;
            }
            if (!string.IsNullOrEmpty(password))
            {
                tbx_password.Text = password;
            }
            if (!string.IsNullOrEmpty(channel))
            {
                tbx_channel.Text = channel;
            }

            if (!ytplayer.IsPlaying())
                ytplayer.Movie = songs.FirstOrDefault().link.ToString();
        }
        private void metroButton1_Click(object sender, EventArgs e)
        {
            
            if (!string.IsNullOrEmpty(tbx_channel.Text) && !string.IsNullOrEmpty(tbx_password.Text) && !string.IsNullOrEmpty(tbx_username.Text))
            {
                // neither one of the three may be empty
                username = tbx_username.Text;
                oauth = tbx_password.Text;
                channel = tbx_channel.Text;
                ConnectionCredentials cred = new ConnectionCredentials(username, oauth);
                if(client == null)
                    client = new TwitchClient(cred, channel, '!');
                if (!client.IsConnected)
                {
                    // connect pressed
                    client.OnMessageReceived += Client_OnMessageReceived;
                    client.OnNewSubscriber += Client_OnNewSubscriber;
                    client.OnWhisperReceived += Client_OnWhisperReceived;
                    client.OnChatCommandReceived += Client_OnChatCommandReceived;
                    client.OnConnected += Client_OnConnected;
                    client.OnConnectionError += Client_OnConnectionError;
                    client.OnUserJoined += Client_OnUserJoined;
                    client.OnUserLeft += Client_OnUserLeft;
                    client.OnUserTimedout += Client_OnUserTimedout;
                    client.OnUserBanned += Client_OnUserBanned;
                    client.Connect();
                }
                else
                {
                    // disconnect pressed
                    client.Disconnect();
                    lbl_status.Style = MetroFramework.MetroColorStyle.Red;
                    lbl_status.Text = "Disconnected";
                    tbx_channel.Enabled = true;
                    tbx_username.Enabled = true;
                    tbx_password.Enabled = true;
                }
            }
        }

        private void Client_OnUserBanned(object sender, TwitchLib.Events.Client.OnUserBannedArgs e)
        {
            User ban = Users.Single(u => u.Username == e.Username);
            ban.Points = 0;
            client.SendMessage($"@{ban.Username}: you have been banned, your points have been reset to 0.");
        }

        private void Client_OnUserTimedout(object sender, TwitchLib.Events.Client.OnUserTimedoutArgs e)
        {
            User timeout = Users.Single(u => u.Username == e.Username);
            timeout.Stop();
            Users.Remove(timeout);
        }

        private void Client_OnUserLeft(object sender, TwitchLib.Events.Client.OnUserLeftArgs e)
        {
            /*User leave = Users.Single(u => u.Username == e.Username);
            leave.Stop();
            Users.Remove(leave);*/
        }

        private void Client_OnUserJoined(object sender, TwitchLib.Events.Client.OnUserJoinedArgs e)
        {
            int id, points;
            using (SQLiteConnection db = new SQLiteConnection(ConnectionString))
            {
                db.Open();
                using (SQLiteCommand dbCommand = new SQLiteCommand($"SELECT id FROM `users` WHERE `username`='{e.Username}'", db))
                {
                    id = Convert.ToInt16(dbCommand.ExecuteScalar());
                }
                using (SQLiteCommand dbCommand = new SQLiteCommand($"SELECT points FROM `users` WHERE `username`='{e.Username}'", db))
                {
                    points = Convert.ToInt16(dbCommand.ExecuteScalar());
                }

                if (id == 0)
                {
                    using (SQLiteCommand dbCommand = new SQLiteCommand($"INSERT INTO `users`(username,points) VALUES ('{e.Username}',0)", db))
                    {
                        dbCommand.ExecuteNonQuery();
                    }
                    points = 0;
                }
            }
            
            User tmpUser = new User(e.Username, points);
            mg_users.BeginInvoke((MethodInvoker)delegate () {
                if (!Users.Any(u => u.Username == tmpUser.Username))
                {
                    Users.Add(tmpUser);
                }
            });
            /*User t = Users.Single(us => us.Username == tmpUser.Username);
                t.ran += TmpUser_ran;
                t.Start();*/
        }

        private void TmpUser_ran(object sender, UserEventArgs e)
        {
            using (SQLiteConnection db = new SQLiteConnection(ConnectionString))
            {
                db.Open();
                using (SQLiteCommand dbCommand = new SQLiteCommand($"UPDATE `users` SET `points`={e.user.Points} WHERE `username`=\"{e.user.Username}\"", db))
                {
                    dbCommand.ExecuteNonQuery();
                }
            }
        }

        private void Client_OnConnectionError(object sender, TwitchLib.Events.Client.OnConnectionErrorArgs e)
        {
            MessageBox.Show("Invalid credentials/No Internet Connection/Can't connect", "An error has occured");
        }

        private void Client_OnConnected(object sender, TwitchLib.Events.Client.OnConnectedArgs e)
        {
            using (SQLiteConnection db = new SQLiteConnection(ConnectionString))
            {
                db.Open();
                using (SQLiteCommand dbCommand = new SQLiteCommand($"UPDATE `settings` SET `value`='{username}' WHERE `name`='username';UPDATE `settings` SET `value`='{oauth}' WHERE `name`='password';UPDATE `settings` SET `value`='{channel}' WHERE `name`='channel';", db))
                {
                    dbCommand.ExecuteNonQuery();
                }
            }
            metroButton2.BeginInvoke((MethodInvoker)delegate () {
                metroButton2.Text = "Disconnect";
            });
            lbl_status.BeginInvoke((MethodInvoker)delegate () {
                lbl_status.Style = MetroFramework.MetroColorStyle.Green;
                lbl_status.Text = "Connected";
            });
            tbx_channel.BeginInvoke((MethodInvoker)delegate () {
                tbx_channel.Enabled = false;
            });
            tbx_username.BeginInvoke((MethodInvoker)delegate () {
                tbx_username.Enabled = false;
            });
            tbx_password.BeginInvoke((MethodInvoker)delegate () {
                tbx_password.Enabled = false;
            });

            RefreshUsers();
        }
        
        private void RefreshUsers()
        {
            DataSet tmp = new DataSet();
            using (SQLiteConnection db = new SQLiteConnection(ConnectionString))
            {
                db.Open();
                using (SQLiteCommand dbCommand = new SQLiteCommand($"SELECT * FROM `users`", db))
                {
                    using (SQLiteDataAdapter dbAdapter = new SQLiteDataAdapter(dbCommand))
                    {
                        dbAdapter.Fill(tmp);
                    }
                }
            }
            foreach (DataRow row in tmp.Tables[0].Rows)
            {
                User tmpUser = new User(row["username"].ToString(), Convert.ToInt16(row["points"].ToString()));
                mg_users.BeginInvoke((MethodInvoker)delegate () {
                    Users.Add(tmpUser);
                });
            }
        }

        private void Client_OnChatCommandReceived(object sender, TwitchLib.Events.Client.OnChatCommandReceivedArgs e)
        {
            // yeey commands
            string m = string.Empty;
            List<string> param = e.Command.ArgumentsAsList;
            tbx_chat.BeginInvoke((MethodInvoker)delegate { // close enough damnit
                switch (e.Command.Command)
                {
                    case "songrequest":
                    case "sr":
                        if (param.Count == 0)
                            m = $"@{e.Command.ChatMessage.DisplayName} you need to specify an youtube link to request a song.";
                        else
                        {
                            Regex r = new Regex(@"watch\?v=");
                            Song s = new Song();
                            s.title = e.Command.ChatMessage.DisplayName;
                            Uri u = new Uri(r.Replace(param[0],"v/"));
                            s.link = u;

                            songs.Add(s);

                            if(songs.First() == s)
                            {
                                ytplayer.Movie = s.link.ToString();
                                ytplayer.Play();
                            }
                            m = $"@{e.Command.ChatMessage.DisplayName} Your song has succesfully been added to the queue.";
                        }
                            

                        break;
                    case "addcommand":
                        if (!e.Command.ChatMessage.IsModerator){
                            m = $"@{e.Command.ChatMessage.DisplayName} you need to be an moderator to add commands.";
                            break;
                        }
                        if (param.Count == 0)
                        {
                            m = $"@{e.Command.ChatMessage.DisplayName} you need to type more parameters to add a command.";
                        } else if (param.Count == 1)
                        {
                            m = $"@{e.Command.ChatMessage.DisplayName} you need to specify my response.";
                        }
                        else
                        {
                            string reply = string.Empty;
                            for(int i = 0; i< param.Count; i++)
                            {
                                if(i== 1)
                                {
                                    reply = param[i];
                                }
                                else if (i > 1)
                                {
                                    reply += $" {param[i]}";
                                }
                            }
                            using (SQLiteConnection db = new SQLiteConnection(ConnectionString))
                            {
                                db.Open();
                                using (SQLiteCommand dbCommand = new SQLiteCommand($"INSERT INTO `commands`(ctext,message) VALUES(\"{param[0]}\",\"{reply}\")", db))
                                {
                                    dbCommand.ExecuteNonQuery();
                                }
                            }
                            m = $"@{e.Command.ChatMessage.DisplayName}, i have succesfully added the command: !{param[0]} with as response: {reply}";
                            getCommands(); // refresh the commands visible
                        }
                        break;
                    case "points":
                        using (SQLiteConnection db = new SQLiteConnection(ConnectionString))
                        {
                            db.Open();
                            using (SQLiteCommand dbCommand = new SQLiteCommand($"SELECT points FROM `users` WHERE `username`=\"{e.Command.ChatMessage.Username}\" LIMIT 1", db))
                            {
                                m = $"@{e.Command.ChatMessage.Username} you currently have: {dbCommand.ExecuteScalar()} Points.";
                            }
                        }
                        break;
                    case "commands":
                        int cc;
                        string commands = string.Empty, tmp ;
                        using (SQLiteConnection db = new SQLiteConnection(ConnectionString))
                        {
                            db.Open();
                            using (SQLiteCommand dbCommand = new SQLiteCommand("SELECT COUNT(id) FROM `commands`", db))
                            {
                                cc = Convert.ToInt16(dbCommand.ExecuteScalar());
                            }
                            for (int i = 0; i < cc; i++)
                            {
                                using (SQLiteCommand dbCommand = new SQLiteCommand($"SELECT ctext FROM `commands` WHERE `id`={i + 1}", db))
                                {
                                    tmp = (string)dbCommand.ExecuteScalar();

                                }
                                if (i == 0)
                                    commands = $"!{tmp}";
                                else
                                    commands += $",!{tmp}";
                            }
                        }
                        if (e.Command.ChatMessage.IsModerator)
                            commands += ",!addcommand(mod)";
                            m = $"The available commands are: {commands}";
                        break;

                    default:
                        using (SQLiteConnection db = new SQLiteConnection(ConnectionString))
                        {
                            db.Open();
                            using (SQLiteCommand dbCommand = new SQLiteCommand($"SELECT message FROM `commands` WHERE `ctext`=\"{e.Command.Command}\" LIMIT 1", db))
                            {
                                m = (string)dbCommand.ExecuteScalar();
                            }
                        }
                        if (string.IsNullOrEmpty(m))
                        {
                            m = $"@{e.Command.ChatMessage.DisplayName} i cannot find the command \"{e.Command.ChatMessage.Message}\"";
                        }
                        break;
                }
                client.SendMessage($"/me {m}");
                tbx_chat.AppendText($"[waifu]{username}: {m}{Environment.NewLine}");
            });
        }

        private void Client_OnWhisperReceived(object sender, TwitchLib.Events.Client.OnWhisperReceivedArgs e)
        {
            // filter for if its a command
            // todo
        }

        private void Client_OnNewSubscriber(object sender, TwitchLib.Events.Client.OnNewSubscriberArgs e)
        {
            client.SendMessage($"/me Thanks {e.Subscriber.Name} for Following");
        }

        private void Client_OnMessageReceived(object sender, TwitchLib.Events.Client.OnMessageReceivedArgs e)
        {
            tbx_chat.BeginInvoke((MethodInvoker)delegate { // close enough damnit
                tbx_chat.AppendText($"[{e.ChatMessage.UserType}]{e.ChatMessage.DisplayName}: {e.ChatMessage.Message}{Environment.NewLine}");
            });
            
        }

        private void commands_tab_Click(object sender, EventArgs e)
        {
            
        }

        private void ytplayer_OnProgress(object sender, AxShockwaveFlashObjects._IShockwaveFlashEvents_OnProgressEvent e)
        {
            if (e.percentDone == 100)
            {
                songs.Remove(songs.First());
                ytplayer.Movie = songs.FirstOrDefault().link.ToString();
                ytplayer.Play();
            }
        }

        private void songs_grid_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void songs_grid_DoubleClick(object sender, EventArgs e)
        {
            
        }
    }
}
