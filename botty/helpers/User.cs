using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.ComponentModel; // bgworker

namespace botty.helpers
{
    public class User
    {
        public event EventHandler<UserEventArgs> ran;
        private string _username { get; set; }
        private int _points { get; set; }
        private BackgroundWorker _worker { get; set; }
        private Timer _timer { get; set; }

        public string Username { get { return this._username; } set { this._username = value; } }
        public int Points { get { return this._points; } set { this._points = value; } }


        protected virtual void OnRan(UserEventArgs ue)
        {
            var u = ran;
            if(u != null)
            {
                u(this, new UserEventArgs(this));
            }
        }

        public User(string username, int points)
        {
            Username = username;
            Points = points;

            this._worker = new BackgroundWorker();
            this._worker.DoWork += _worker_DoWork;
            this._worker.WorkerSupportsCancellation = true;
            this._timer = new Timer(18000);
            this._timer.Elapsed += _timer_Elapsed;
        }

        private void _timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (!this._worker.IsBusy)
                this._worker.RunWorkerAsync();
        }

        private void _worker_DoWork(object sender, DoWorkEventArgs e)
        {
            Points += 5; // 5 points per 3 minutes    
            OnRan(new UserEventArgs(this));        
        }

        public void Start()
        {
            this._timer.Start();
        }

        public void Stop()
        {
            this._timer.Stop();
        }
    }
}
