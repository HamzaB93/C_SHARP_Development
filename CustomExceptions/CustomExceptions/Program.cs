using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptions
{
    public class Tester
    {
        // Pass  2 doubles
        public double DoDivide(double x, double y)
        {
            // if y is 0
            if (y == 0)
                // Throws existing exceptions
                throw new DivideByZeroException();
            // Because there is no test to see if the dividends is 0, we use our custom exception
            if (x == 0)
                throw new MyCustomException("Dividend cant be zero!");
            return x / y;
        }
    }

    // custom exception derives from exception class
    public class MyCustomException : Exception
    {
        // Constructor takes a message and pass that message to the base class Exception
        public MyCustomException(string message) : base(message)
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tester t = new Tester();
                // Call our divide method with valid numbers
                double answer = t.DoDivide(12, 4);
                Console.WriteLine("DoDivide(12, 4) = {0}", answer);

                answer = t.DoDivide(0, 4);
                Console.WriteLine("DoDivide(0, 4) = {0}", answer);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (MyCustomException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
