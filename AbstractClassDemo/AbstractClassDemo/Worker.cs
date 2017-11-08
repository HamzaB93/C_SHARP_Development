using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemo
{
    public class Worker :  Employee
    {
        // Beucase it derives from EMployee, it HAS TO IMPLMENT THE GIVERAISE method
        public override void GiveRaise()
        {
            Salary += Salary * 0.03;
        }
    }
}
