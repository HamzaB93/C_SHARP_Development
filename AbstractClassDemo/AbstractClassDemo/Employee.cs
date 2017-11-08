using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemo
{
    // NOt legal to instantiate this class, only ones that derive
    public abstract class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }
        private DateTime HireDate;

        // Unlike interface, it can have an implmentation of method
        // Derived class do not need to override
        public virtual void Hire()
        {
            HireDate = DateTime.Now;
        }

        // Abstract method, derived classes need to override this otherwise the method will also be abstract
        public abstract void GiveRaise();
    }
}
