using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classes_Objects
{
    internal class Person
    {
        // Fields
        public string? name;
        public int age;

        public void Greet()
        {
            Console.WriteLine($"Nice to meet you, I'm {name} and I'm {age} years old.");
        }
    }
}