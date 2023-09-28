using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Re_Day_3B_PracticeProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool execute = true;
            while (execute)

            {
                Console.WriteLine("Choose any program");
                Console.WriteLine("1. Types of constructor with example\n" +
                    "2. Interface Concept\n" +
                    "3. Access modifier conceot\n");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        TypesOfConstructor typesOfConstructor = new TypesOfConstructor();
                       // Console.WriteLine(typesOfConstructor.name);
                        Console.WriteLine("\nWould you like to continue(1) or exit the program(0)");
                        int desicion1 = Convert.ToInt32(Console.ReadLine());
                        if (desicion1 == 0)
                        {
                            execute = false;
                        }
                        break;
                    case 2:
                        Rectangle r1 = new Rectangle();
                        r1.CalculateArea(100, 200);
                        break;
                    case 3:
                        AccessModifierConcept accessModifierConcept = new AccessModifierConcept();
                        Console.WriteLine(accessModifierConcept.name);
                        
                        Student student = new Student();
                        

                        break;
                }
            }
        }
    }
}
