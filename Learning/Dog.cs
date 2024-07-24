using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    public class Dog
    {
        private float _height;
        private float _weight;
        private string _food;
        private string _name;

        public Dog() { }
        public Dog(float height, float weight, string food, string name) { 
            _height = height;
            _weight = weight;
            _food = food;
            _name = name;
        }
        public void Run()
        {
            Console.WriteLine($"{_name} runing");
        }
        public void Play()
        {
            Console.WriteLine($"{_name} playing");
        }
        public void Eat()
        {
            Console.WriteLine($"{_name} eating");
        }
        public void ChangeName(string newname)
        {
            _name = newname;
        }
        public void ChangeFood(string newfood)
        {
            _food = newfood; ;
        }
        public void GetElements()
        {
            Console.WriteLine($"name: {_name}, height: {_height}, weight: {_weight}, food: {_food}");
        }
    }
}
