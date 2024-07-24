using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public enum Color
    {
        Green,
        Red,
        Blue
    }

    public class Car
    {
        private Color _carColor;


        public Car() { }
        public Car(Color carColor) { 
            _carColor = carColor;
        }

        public void DisplayColor() {
            Console.WriteLine(_carColor.ToString());
        }
    }
    


}
