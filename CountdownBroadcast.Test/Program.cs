using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CountdownBroadcast;

namespace CountdownBroadcast.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            CountdownBroadcaster broadcaster = new CountdownBroadcaster("Hello world", 5000);
            FirstSubscriber firstSubscriber = new FirstSubscriber(broadcaster);
            SecondSubscriber secondSubscriber = new SecondSubscriber();
            secondSubscriber.Register(broadcaster);

            broadcaster.Start();

            Console.ReadLine();

        }
    }
}
