using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CountdownBroadcast
{
    public class CountdownBroadcaster
    {
        private string message = "Time is up.";
        private int time;

        public event EventHandler<TimeElapsedEventArgs> TimeElapsedEvent;

        public CountdownBroadcaster(string message, int time)
        {
            this.message = message;
            this.time = time;
        }

        protected virtual void OnTimeElapsed(TimeElapsedEventArgs e)
        {
            if (TimeElapsedEvent != null)
                TimeElapsedEvent(this, e);
        }

        public void Start()
        {
            Thread.Sleep(time);
            TimeElapsedEventArgs e = new TimeElapsedEventArgs(message, time);
            OnTimeElapsed(e);
        }    


    }
}

