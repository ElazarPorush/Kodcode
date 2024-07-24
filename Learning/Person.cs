using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    internal class Person
    {
        private int _age;
        public int Age
        {
            get { return _age; }
            set
            {
                if (value > -1 && value < 121) { _age = value; }
                else { Console.WriteLine("Eror: Age must be btween 0 to 120"); }
            }

        }
    }
}
