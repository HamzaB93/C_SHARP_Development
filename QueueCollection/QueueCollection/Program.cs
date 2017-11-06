using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create new queue
            var myQueue = new Queue<int>();
            // Adding to queueu
            myQueue.Enqueue(100);
            // Dequeueing the value into variable
            var val = myQueue.Dequeue();
            // Diplay the values
            // Console.WriteLine("Val: {0}", val);

            // for loop to add 50 values to the queue
            for (int i = 0; i < 50; i++)
            {
                myQueue.Enqueue(i);
            }

            // Examine whats in the queue
            foreach (int number in myQueue)
            {
                Console.Write("{0}, ", number);
            }

            // Dequeing a value from the queue and display it, should be the first number
            var whichNumber = myQueue.Dequeue();
            Console.WriteLine("\nDequeued number is : {0}", whichNumber);

            // Repeat dequeue
            whichNumber = myQueue.Dequeue();
            Console.WriteLine("\nDequeued number is : {0}", whichNumber);
            
        }
    }
}
