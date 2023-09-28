using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Re_Day_3B_PracticeProblem
{
    public class TypesOfConstructor
    {
        private string name;
        private int age;

        // Default constructor
        public TypesOfConstructor()
        {
            name = "John Doe";
            age = 30;
        }

        // Parameterized constructor
        public TypesOfConstructor(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        // Static constructor
        static TypesOfConstructor()
        {
            Console.WriteLine("Person class loaded.");
        }
    }
}
