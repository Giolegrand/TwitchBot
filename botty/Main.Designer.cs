namespace botty
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.sExtender = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.dtgv_commands = new System.Windows.Forms.DataGridView();
            this.sManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.settings_tab = new MetroFramework.Controls.MetroTabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_status = new MetroFramework.Controls.MetroLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbx_channel = new MetroFramework.Controls.MetroTextBox();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroLink2 = new MetroFramework.Controls.MetroLink();
            this.tbx_password = new MetroFramework.Controls.MetroTextBox();
            this.tbx_username = new MetroFramework.Controls.MetroTextBox();
            this.chat_tab = new MetroFramework.Controls.MetroTabPage();
            this.tbx_chat = new MetroFramework.Controls.MetroTextBox();
            this.commands_tab = new MetroFramework.Controls.MetroTabPage();
            this.users_tab = new MetroFramework.Controls.MetroTabPage();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.mg_users = new MetroFramework.Controls.MetroGrid();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.songs_tab = new MetroFramework.Controls.MetroTabPage();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.ytplayer = new AxShockwaveFlashObjects.AxShockwaveFlash();
            this.songs_grid = new MetroFramework.Controls.MetroGrid();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_commands)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sManager)).BeginInit();
            this.metroTabControl1.SuspendLayout();
            this.settings_tab.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.chat_tab.SuspendLayout();
            this.commands_tab.SuspendLayout();
            this.users_tab.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mg_users)).BeginInit();
            this.songs_tab.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ytplayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.songs_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // sExtender
            // 
            this.sExtender.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // dtgv_commands
            // 
            this.dtgv_commands.AllowUserToResizeColumns = false;
            this.dtgv_commands.AllowUserToResizeRows = false;
            this.sExtender.SetApplyMetroTheme(this.dtgv_commands, true);
            this.dtgv_commands.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_commands.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_commands.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgv_commands.Location = new System.Drawing.Point(0, 0);
            this.dtgv_commands.MultiSelect = false;
            this.dtgv_commands.Name = "dtgv_commands";
            this.dtgv_commands.RowHeadersVisible = false;
            this.dtgv_commands.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_commands.Size = new System.Drawing.Size(741, 303);
            this.dtgv_commands.TabIndex = 2;
            // 
            // sManager
            // 
            this.sManager.Owner = this;
            this.sManager.Style = MetroFramework.MetroColorStyle.Lime;
            this.sManager.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.settings_tab);
            this.metroTabControl1.Controls.Add(this.chat_tab);
            this.metroTabControl1.Controls.Add(this.commands_tab);
            this.metroTabControl1.Controls.Add(this.users_tab);
            this.metroTabControl1.Controls.Add(this.songs_tab);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(20, 60);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 4;
            this.metroTabControl1.Size = new System.Drawing.Size(749, 345);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabControl1.UseSelectable = true;
            // 
            // settings_tab
            // 
            this.settings_tab.Controls.Add(this.groupBox1);
            this.settings_tab.Controls.Add(this.groupBox2);
            this.settings_tab.HorizontalScrollbarBarColor = true;
            this.settings_tab.HorizontalScrollbarHighlightOnWheel = false;
            this.settings_tab.HorizontalScrollbarSize = 10;
            this.settings_tab.Location = new System.Drawing.Point(4, 38);
            this.settings_tab.Name = "settings_tab";
            this.settings_tab.Size = new System.Drawing.Size(741, 303);
            this.settings_tab.Style = MetroFramework.MetroColorStyle.Lime;
            this.settings_tab.TabIndex = 3;
            this.settings_tab.Text = "Settings";
            this.settings_tab.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.settings_tab.VerticalScrollbarBarColor = true;
            this.settings_tab.VerticalScrollbarHighlightOnWheel = false;
            this.settings_tab.VerticalScrollbarSize = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_status);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox1.Location = new System.Drawing.Point(286, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 103);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection Status";
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_status.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbl_status.Location = new System.Drawing.Point(71, 36);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(127, 25);
            this.lbl_status.TabIndex = 0;
            this.lbl_status.Text = "Disconnected";
            this.lbl_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_status.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lbl_status.UseStyleColors = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbx_channel);
            this.groupBox2.Controls.Add(this.metroButton2);
            this.groupBox2.Controls.Add(this.metroLink2);
            this.groupBox2.Controls.Add(this.tbx_password);
            this.groupBox2.Controls.Add(this.tbx_username);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(277, 103);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Global Settings";
            // 
            // tbx_channel
            // 
            // 
            // 
            // 
            this.tbx_channel.CustomButton.Image = null;
            this.tbx_channel.CustomButton.Location = new System.Drawing.Point(83, 1);
            this.tbx_channel.CustomButton.Name = "";
            this.tbx_channel.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbx_channel.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbx_channel.CustomButton.TabIndex = 1;
            this.tbx_channel.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbx_channel.CustomButton.UseSelectable = true;
            this.tbx_channel.CustomButton.Visible = false;
            this.tbx_channel.Lines = new string[0];
            this.tbx_channel.Location = new System.Drawing.Point(163, 19);
            this.tbx_channel.MaxLength = 32767;
            this.tbx_channel.Name = "tbx_channel";
            this.tbx_channel.PasswordChar = '\0';
            this.tbx_channel.PromptText = "Channel Name";
            this.tbx_channel.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbx_channel.SelectedText = "";
            this.tbx_channel.SelectionLength = 0;
            this.tbx_channel.SelectionStart = 0;
            this.tbx_channel.ShortcutsEnabled = true;
            this.tbx_channel.Size = new System.Drawing.Size(105, 23);
            this.tbx_channel.TabIndex = 6;
            this.tbx_channel.UseSelectable = true;
            this.tbx_channel.WaterMark = "Channel Name";
            this.tbx_channel.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbx_channel.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(177, 48);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(75, 23);
            this.metroButton2.TabIndex = 5;
            this.metroButton2.Text = "Connect";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLink2
            // 
            this.metroLink2.Location = new System.Drawing.Point(18, 74);
            this.metroLink2.Name = "metroLink2";
            this.metroLink2.Size = new System.Drawing.Size(106, 23);
            this.metroLink2.TabIndex = 4;
            this.metroLink2.Text = "Get Oauth code";
            this.metroLink2.UseSelectable = true;
            this.metroLink2.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // tbx_password
            // 
            // 
            // 
            // 
            this.tbx_password.CustomButton.Image = null;
            this.tbx_password.CustomButton.Location = new System.Drawing.Point(119, 1);
            this.tbx_password.CustomButton.Name = "";
            this.tbx_password.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbx_password.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbx_password.CustomButton.TabIndex = 1;
            this.tbx_password.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbx_password.CustomButton.UseSelectable = true;
            this.tbx_password.CustomButton.Visible = false;
            this.tbx_password.Lines = new string[0];
            this.tbx_password.Location = new System.Drawing.Point(6, 48);
            this.tbx_password.MaxLength = 32767;
            this.tbx_password.Name = "tbx_password";
            this.tbx_password.PasswordChar = '\0';
            this.tbx_password.PromptText = "Oauth password";
            this.tbx_password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbx_password.SelectedText = "";
            this.tbx_password.SelectionLength = 0;
            this.tbx_password.SelectionStart = 0;
            this.tbx_password.ShortcutsEnabled = true;
            this.tbx_password.Size = new System.Drawing.Size(141, 23);
            this.tbx_password.TabIndex = 3;
            this.tbx_password.UseSelectable = true;
            this.tbx_password.WaterMark = "Oauth password";
            this.tbx_password.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbx_password.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbx_username
            // 
            // 
            // 
            // 
            this.tbx_username.CustomButton.Image = null;
            this.tbx_username.CustomButton.Location = new System.Drawing.Point(119, 1);
            this.tbx_username.CustomButton.Name = "";
            this.tbx_username.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbx_username.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbx_username.CustomButton.TabIndex = 1;
            this.tbx_username.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbx_username.CustomButton.UseSelectable = true;
            this.tbx_username.CustomButton.Visible = false;
            this.tbx_username.Lines = new string[0];
            this.tbx_username.Location = new System.Drawing.Point(6, 19);
            this.tbx_username.MaxLength = 32767;
            this.tbx_username.Name = "tbx_username";
            this.tbx_username.PasswordChar = '\0';
            this.tbx_username.PromptText = "Username Bot";
            this.tbx_username.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbx_username.SelectedText = "";
            this.tbx_username.SelectionLength = 0;
            this.tbx_username.SelectionStart = 0;
            this.tbx_username.ShortcutsEnabled = true;
            this.tbx_username.Size = new System.Drawing.Size(141, 23);
            this.tbx_username.TabIndex = 2;
            this.tbx_username.UseSelectable = true;
            this.tbx_username.WaterMark = "Username Bot";
            this.tbx_username.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbx_username.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // chat_tab
            // 
            this.chat_tab.Controls.Add(this.tbx_chat);
            this.chat_tab.HorizontalScrollbarBarColor = true;
            this.chat_tab.HorizontalScrollbarHighlightOnWheel = false;
            this.chat_tab.HorizontalScrollbarSize = 10;
            this.chat_tab.Location = new System.Drawing.Point(4, 38);
            this.chat_tab.Name = "chat_tab";
            this.chat_tab.Size = new System.Drawing.Size(741, 303);
            this.chat_tab.Style = MetroFramework.MetroColorStyle.Lime;
            this.chat_tab.TabIndex = 2;
            this.chat_tab.Text = "Chat";
            this.chat_tab.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.chat_tab.VerticalScrollbarBarColor = true;
            this.chat_tab.VerticalScrollbarHighlightOnWheel = false;
            this.chat_tab.VerticalScrollbarSize = 10;
            // 
            // tbx_chat
            // 
            this.tbx_chat.CausesValidation = false;
            // 
            // 
            // 
            this.tbx_chat.CustomButton.Image = null;
            this.tbx_chat.CustomButton.Location = new System.Drawing.Point(439, 1);
            this.tbx_chat.CustomButton.Name = "";
            this.tbx_chat.CustomButton.Size = new System.Drawing.Size(301, 301);
            this.tbx_chat.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbx_chat.CustomButton.TabIndex = 1;
            this.tbx_chat.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbx_chat.CustomButton.UseSelectable = true;
            this.tbx_chat.CustomButton.Visible = false;
            this.tbx_chat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbx_chat.Lines = new string[0];
            this.tbx_chat.Location = new System.Drawing.Point(0, 0);
            this.tbx_chat.MaxLength = 32767;
            this.tbx_chat.Multiline = true;
            this.tbx_chat.Name = "tbx_chat";
            this.tbx_chat.PasswordChar = '\0';
            this.tbx_chat.ReadOnly = true;
            this.tbx_chat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbx_chat.SelectedText = "";
            this.tbx_chat.SelectionLength = 0;
            this.tbx_chat.SelectionStart = 0;
            this.tbx_chat.ShortcutsEnabled = false;
            this.tbx_chat.Size = new System.Drawing.Size(741, 303);
            this.tbx_chat.Style = MetroFramework.MetroColorStyle.Lime;
            this.tbx_chat.TabIndex = 2;
            this.tbx_chat.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tbx_chat.UseSelectable = true;
            this.tbx_chat.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbx_chat.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // commands_tab
            // 
            this.commands_tab.Controls.Add(this.dtgv_commands);
            this.commands_tab.HorizontalScrollbarBarColor = true;
            this.commands_tab.HorizontalScrollbarHighlightOnWheel = false;
            this.commands_tab.HorizontalScrollbarSize = 10;
            this.commands_tab.Location = new System.Drawing.Point(4, 38);
            this.commands_tab.Name = "commands_tab";
            this.commands_tab.Size = new System.Drawing.Size(741, 303);
            this.commands_tab.Style = MetroFramework.MetroColorStyle.Lime;
            this.commands_tab.TabIndex = 4;
            this.commands_tab.Text = "Commands";
            this.commands_tab.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.commands_tab.VerticalScrollbarBarColor = true;
            this.commands_tab.VerticalScrollbarHighlightOnWheel = false;
            this.commands_tab.VerticalScrollbarSize = 10;
            this.commands_tab.Click += new System.EventHandler(this.commands_tab_Click);
            // 
            // users_tab
            // 
            this.users_tab.Controls.Add(this.metroPanel1);
            this.users_tab.HorizontalScrollbarBarColor = true;
            this.users_tab.HorizontalScrollbarHighlightOnWheel = false;
            this.users_tab.HorizontalScrollbarSize = 10;
            this.users_tab.Location = new System.Drawing.Point(4, 38);
            this.users_tab.Name = "users_tab";
            this.users_tab.Size = new System.Drawing.Size(741, 303);
            this.users_tab.Style = MetroFramework.MetroColorStyle.Lime;
            this.users_tab.TabIndex = 5;
            this.users_tab.Text = "Users";
            this.users_tab.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.users_tab.VerticalScrollbarBarColor = true;
            this.users_tab.VerticalScrollbarHighlightOnWheel = false;
            this.users_tab.VerticalScrollbarSize = 10;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.mg_users);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(741, 303);
            this.metroPanel1.TabIndex = 3;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // mg_users
            // 
            this.mg_users.AllowUserToAddRows = false;
            this.mg_users.AllowUserToDeleteRows = false;
            this.mg_users.AllowUserToResizeRows = false;
            this.mg_users.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mg_users.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.mg_users.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mg_users.CausesValidation = false;
            this.mg_users.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mg_users.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mg_users.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mg_users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mg_users.DefaultCellStyle = dataGridViewCellStyle2;
            this.mg_users.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mg_users.EnableHeadersVisualStyles = false;
            this.mg_users.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mg_users.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.mg_users.Location = new System.Drawing.Point(0, 0);
            this.mg_users.MultiSelect = false;
            this.mg_users.Name = "mg_users";
            this.mg_users.ReadOnly = true;
            this.mg_users.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mg_users.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mg_users.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mg_users.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.mg_users.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mg_users.ShowCellErrors = false;
            this.mg_users.ShowCellToolTips = false;
            this.mg_users.ShowEditingIcon = false;
            this.mg_users.ShowRowErrors = false;
            this.mg_users.Size = new System.Drawing.Size(741, 303);
            this.mg_users.Style = MetroFramework.MetroColorStyle.Lime;
            this.mg_users.TabIndex = 2;
            this.mg_users.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mg_users.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(767, 11);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(18, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "X";
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // songs_tab
            // 
            this.songs_tab.Controls.Add(this.metroPanel3);
            this.songs_tab.Controls.Add(this.metroPanel2);
            this.songs_tab.HorizontalScrollbarBarColor = true;
            this.songs_tab.HorizontalScrollbarHighlightOnWheel = false;
            this.songs_tab.HorizontalScrollbarSize = 10;
            this.songs_tab.Location = new System.Drawing.Point(4, 38);
            this.songs_tab.Name = "songs_tab";
            this.songs_tab.Size = new System.Drawing.Size(741, 303);
            this.songs_tab.Style = MetroFramework.MetroColorStyle.Silver;
            this.songs_tab.TabIndex = 6;
            this.songs_tab.Text = "Songrequest";
            this.songs_tab.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.songs_tab.VerticalScrollbarBarColor = true;
            this.songs_tab.VerticalScrollbarHighlightOnWheel = false;
            this.songs_tab.VerticalScrollbarSize = 10;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.songs_grid);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(0, 0);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(263, 303);
            this.metroPanel2.TabIndex = 2;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // metroPanel3
            // 
            this.metroPanel3.Controls.Add(this.ytplayer);
            this.metroPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(263, 0);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(478, 303);
            this.metroPanel3.TabIndex = 3;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // ytplayer
            // 
            this.sExtender.SetApplyMetroTheme(this.ytplayer, true);
            this.ytplayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ytplayer.Enabled = true;
            this.ytplayer.Location = new System.Drawing.Point(0, 0);
            this.ytplayer.Name = "ytplayer";
            this.ytplayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("ytplayer.OcxState")));
            this.ytplayer.Size = new System.Drawing.Size(478, 303);
            this.ytplayer.TabIndex = 2;
            this.ytplayer.OnProgress += new AxShockwaveFlashObjects._IShockwaveFlashEvents_OnProgressEventHandler(this.ytplayer_OnProgress);
            // 
            // songs_grid
            // 
            this.songs_grid.AllowUserToAddRows = false;
            this.songs_grid.AllowUserToDeleteRows = false;
            this.songs_grid.AllowUserToResizeRows = false;
            this.songs_grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.songs_grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.songs_grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.songs_grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.songs_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.songs_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.songs_grid.DefaultCellStyle = dataGridViewCellStyle5;
            this.songs_grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.songs_grid.EnableHeadersVisualStyles = false;
            this.songs_grid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.songs_grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.songs_grid.Location = new System.Drawing.Point(0, 0);
            this.songs_grid.Name = "songs_grid";
            this.songs_grid.ReadOnly = true;
            this.songs_grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.songs_grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.songs_grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.songs_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.songs_grid.Size = new System.Drawing.Size(263, 303);
            this.songs_grid.TabIndex = 2;
            this.songs_grid.DoubleClick += new System.EventHandler(this.songs_grid_DoubleClick);
            this.songs_grid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.songs_grid_KeyPress);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 425);
            this.ControlBox = false;
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "LucyyBot";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_commands)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sManager)).EndInit();
            this.metroTabControl1.ResumeLayout(false);
            this.settings_tab.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.chat_tab.ResumeLayout(false);
            this.commands_tab.ResumeLayout(false);
            this.users_tab.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mg_users)).EndInit();
            this.songs_tab.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ytplayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.songs_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleExtender sExtender;
        private MetroFramework.Components.MetroStyleManager sManager;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTabPage settings_tab;
        private MetroFramework.Controls.MetroTabPage chat_tab;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroTextBox tbx_channel;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroLink metroLink2;
        private MetroFramework.Controls.MetroTextBox tbx_password;
        private MetroFramework.Controls.MetroTextBox tbx_username;
        private MetroFramework.Controls.MetroTextBox tbx_chat;
        private MetroFramework.Controls.MetroTabPage commands_tab;
        private System.Windows.Forms.DataGridView dtgv_commands;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel lbl_status;
        private MetroFramework.Controls.MetroTabPage users_tab;
        private MetroFramework.Controls.MetroGrid mg_users;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTabPage songs_tab;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private AxShockwaveFlashObjects.AxShockwaveFlash ytplayer;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroGrid songs_grid;
    }
}

