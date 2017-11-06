using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Stack is similar to the queuecollection program
             * only difference is that enqueue is changed to push
             * and dequeue is pop. Stack is last in first out
             */

            var myStack = new Stack<int>();
            myStack.Push(100);
            var val = myStack.Pop();
            Console.Write("Value popped: {0}, \n", val);

            // for loop to add 50 values to the queue
            for (int i = 0; i < 50; i++)
            {
                myStack.Push(i);
            }

            // Examine whats in the queue
            foreach (int number in myStack)
            {
                Console.Write("{0}, ", number);
            }
            var whichNumber = myStack.Pop();
            Console.WriteLine("\nDequeued number is : {0}", whichNumber);

            whichNumber = myStack.Pop();
            Console.WriteLine("\nDequeued number is : {0}", whichNumber);
        }
    }
}
