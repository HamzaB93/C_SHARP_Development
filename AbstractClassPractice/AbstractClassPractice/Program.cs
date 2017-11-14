using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            var dog1 = new Dog("Rover", 2);
            var dog2 = new Dog("Trevor", 3);
            var dog3 = new Dog("Jack", 1);
            var cat1 = new Cat("Fluffy", 3);
            var cat2 = new Cat("Cat Smith", 4);

            // Was overriden for both derived classes
            dog1.DoATrick(dog1.Name, "Jump");
            cat1.DoATrick(cat1.Name, "be a lazy cat");

            List<Pet> pets = new List<Pet>();
            pets.Add(dog1);
            pets.Add(cat1);
            pets.Add(dog2);
            pets.Add(dog3);
            pets.Add(cat2);

            foreach (Pet p in pets)
            {
                Console.Write("My pet's name is {0} and is {1} years old. Say hello ---- {2} \n",
                    p.Name, p.Age, p.SayHello());
            }
           
            
        }
    }
}
