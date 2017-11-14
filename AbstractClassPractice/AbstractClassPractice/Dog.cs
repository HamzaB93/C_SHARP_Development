using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassPractice
{
    public class Dog : Pet
    {
        public Dog (string name, int age)
        {
            Name = name;
            Age = age;
        }
        // My dog has a name and an age, can override SayHello method but dont have to here
        // Must implment DoATrick otherwise itll be oabstract class too
        public override void DoATrick(string petName, string instruction)
        {
            Console.WriteLine("{0} did a {1}", petName, instruction);
        }
    }
}
