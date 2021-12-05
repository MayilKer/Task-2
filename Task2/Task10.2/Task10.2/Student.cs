using System;
using System.Collections.Generic;
using System.Text;

namespace Task10._2
{
    class Student:Person
    {
        public void Study()
        {
            Console.WriteLine("I am studying");
        }
        public void ShowAge()
        {
            Console.WriteLine($"My age is {Age} years old");
        }
    }
}
