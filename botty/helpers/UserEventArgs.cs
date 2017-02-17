using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace botty.helpers
{
    public class UserEventArgs : EventArgs
    {
        public User user { get; set; }
        public UserEventArgs(User u)
        {
            user = u;
        }
    }
}