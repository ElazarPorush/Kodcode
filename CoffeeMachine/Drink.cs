using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine
{
	internal class Drink
	{
		public string Name {  get; set; }
		public float Shuger {  get; set; }
		public float Coffee { get; set; }
		public float Milk { get; set; }
		public float Cackahu { get; set; }
		public float Price { get; set; }

		public Drink() { }
		public Drink(string name, float shuger, float coffee, float milk, float cackahu, float price)
		{
			Name = name;
			Shuger = shuger;
			Coffee = coffee;
			Milk = milk;
			Cackahu = cackahu;
			Price = price;
		}
		
	}
}
