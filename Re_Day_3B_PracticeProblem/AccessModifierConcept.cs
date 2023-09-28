using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Re_Day_3B_PracticeProblem
{

    //public modifier
    internal class AccessModifierConcept
    {
        public string name = "Sheeran";
        public void print()
        {
            Console.WriteLine("Hello from Student class");
        }
    }

    //private modifier
    class Student
    {
        private string name = "Sheeran";
        private void Print()
        {
            Console.WriteLine("Hello from Student class");
            //Student student = new Student();
            //Console.WriteLine(student.name);
        }
    }

    //protected modifier
    class Student2
    {
        protected string name = "Sheeran";
    }

}
