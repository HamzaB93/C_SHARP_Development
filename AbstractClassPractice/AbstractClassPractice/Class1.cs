using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassPractice
{
    public class Cat : Pet
    {
        public Cat(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // Also want to override sayhello as cats dont bark
        public override string SayHello()
        {
            return "MEOW";
        }
        public override void DoATrick(string petName, string instruction)
        {
            Console.WriteLine("{0} did a {1}", petName, instruction);
        }
    }
}
