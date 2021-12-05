using System;
using System.Collections.Generic;
using System.Text;

namespace Task10._2
{
    class Teacher:Person
    {
        public void Explain()
        {
            Console.WriteLine("I am explainig");
        }
        public void ShowAge()
        {
            Console.WriteLine($"My age is {Age} years old");
        }
    }
}
