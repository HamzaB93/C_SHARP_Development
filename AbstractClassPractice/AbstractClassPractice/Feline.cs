using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassPractice
{
    public abstract class Pet
    {
        // The classes will have these properties 
        public string Name { get; set; }
        public int Age { get; set; }

        // It can override this but doesnt have to 
        public virtual string SayHello()
        {
            return "BARK!";
        }

        // Derived classes MUST override this otherwise it will be abstract also
        public abstract void DoATrick(string petName, string instruction);
    }
}
