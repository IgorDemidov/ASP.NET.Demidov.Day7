using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountdownBroadcast
{
    public class TimeElapsedEventArgs : EventArgs
    {
        private readonly string message;
        private readonly int elapsedTime;

        public TimeElapsedEventArgs(string message, int elapsedTime)
        {
            this.message = message;
            this.elapsedTime = elapsedTime;
        }

        public string Message { get { return message; } }
        public int ElapsedTime { get { return elapsedTime; } }
    }
}
