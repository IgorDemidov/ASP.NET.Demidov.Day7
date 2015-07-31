using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomQueue.Task3.Library;

namespace CustomQueue.Task3.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomQueue<int> userQueue = new CustomQueue<int>();

            Console.WriteLine("Was created. Count = "+userQueue.Count);
            userQueue.Enqueue(1);
            userQueue.Enqueue(2);
            userQueue.Enqueue(3);
            userQueue.Enqueue(4);
            userQueue.Enqueue(5);

            foreach (var item in userQueue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Was enqueued. Count = " + userQueue.Count);

            Console.WriteLine("\nDequeued: " + userQueue.Dequeue());      
            Console.WriteLine("Dequeued: " + userQueue.Dequeue()); 
            Console.WriteLine("\n Result:");
            foreach (var item in userQueue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Was dequeued. Count = " + userQueue.Count);

            Console.WriteLine(userQueue.Peek());
            Console.WriteLine("Was peeked. Count = " + userQueue.Count);

            Console.WriteLine("\nCtor with IEnumerable:");
            int[] array = new int[] { 5, 6, 7, 8, 9 };
            CustomQueue<int> userQueue2 = new CustomQueue<int>(array);
            foreach (var item in userQueue2)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
