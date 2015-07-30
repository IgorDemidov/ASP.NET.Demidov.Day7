using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountdownBroadcast
{
    public class FirstSubscriber
    {
        public FirstSubscriber() { }
        public FirstSubscriber(CountdownBroadcaster broadcaster)
            : this()
        {
            Register(broadcaster);
        }

        public static void WriteToConsole(object sender, TimeElapsedEventArgs e)
        {
            Console.WriteLine("***************************************");
            Console.WriteLine("First subscriber handler (WriteToConsole):");
            Console.WriteLine("\t Input message: " + e.Message);
            Console.WriteLine("\t Elapsed time: " + e.ElapsedTime);
            Console.WriteLine("\t Sender: " + sender.GetType().Name);
            Console.WriteLine("***************************************");
        }

        public void Register(CountdownBroadcaster broadcaster)
        {
            broadcaster.TimeElapsedEvent += WriteToConsole;
        }

        public void Unregister(CountdownBroadcaster broadcaster)
        {
            broadcaster.TimeElapsedEvent -= WriteToConsole;
        }
    }
}
