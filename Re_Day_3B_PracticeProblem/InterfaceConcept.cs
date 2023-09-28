using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Re_Day_3B_PracticeProblem
{
    interface InterfaceConcept
    {
        // Method without body
        void CalculateArea(int l, int b);
    }

    class Rectangle : InterfaceConcept
    {
        // Implementation of methods inside the interface
        public void CalculateArea(int l, int b)
        {
            int area = l * b;
            Console.WriteLine("Area of Rectangle: " + area);
        }
    }
}
