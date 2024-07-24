using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace Learning
{
    public partial class Form1 : Form
    {
        public Dog[] dogArr = new Dog[20];
        public int poynter = 0;
        private string[] names = new string[10];
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //names[0] = "elazar";
            //names[1] = "meir";
            //names[2] = "moshe";
            //names[3] = "rivka";
            label1.Text = names[0];


            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //names[0] = "elazar";
            //names[1] = "meir";
            //names[2] = "moshe";
            //names[3] = "rivka";
            for (int name = 0; name < names.Length; name++)
            {
                if (names[name] == null)
                {
                    names[name] = textBox1.Text;
                    break;
                    //Console.WriteLine(110);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Student[] studentArr = new Student[25];
            studentArr[0] = new Student("elazar", "porush");
            studentArr[0].Id = 324987957;


        }

        private void btnOperatorim_Click(object sender, EventArgs e)
        {
            int x = 5;
            float y = 12.5f;
            string z = "Hi";
            Console.WriteLine(x + y);
            Console.WriteLine((x + y).GetType());

            Console.WriteLine(x + z);
            Console.WriteLine((x + z).GetType());

            Console.WriteLine(y + z);
            Console.WriteLine((y + z).GetType());

            Console.WriteLine(z + x);
            Console.WriteLine((z + x).GetType());

            Console.WriteLine(z + y);
            Console.WriteLine((z + y).GetType());

            Console.WriteLine(x + y + z);
            Console.WriteLine((x + y + z).GetType());

        }
        public void Append(float height, float weight, string food, string name)
        {
            if (poynter < dogArr.Length)
            {
                dogArr[poynter] = new Dog(height, weight, food, name);
                //txtAge = employsArr[poynter].Age; 
                poynter++;
            }
            else
            {
                Dog[] tmp = new Dog[dogArr.Length + 1];
                for (int i = 0; i < dogArr.Length; i++)
                {
                    tmp[i] = dogArr[i];
                }
                dogArr = tmp;
                dogArr[poynter] = new Dog(height, weight, food, name);
                //txtAge = employsArr[poynter].Age;
                poynter++;
            }
        }
        private void btnDog_Click(object sender, EventArgs e)
        {
            Dog dog2 = new Dog(1.56f, 30.3f, "meet", "Rasel");
            Dog dog1 = new Dog(1.72f, 25.9f, "fish", "Nahman");
            //Console.WriteLine(wolf);
            dog1.Run();
            dog1.Play();
            dog1.Eat();
            dog2.Run();
            dog2.Play();
            dog2.Eat();
            dog1.ChangeName("Ralf");
            dog1.Run();
            Append(1.5f, 30.32f, "beer", "Moshe");
            Append(1.7f, 27.6f, "meet", "Yakov");
            foreach (var item in dogArr)
            {
                if (item != null)
                {
                    item.GetElements();
                }
            }
        }

        private void btnAge_Click(object sender, EventArgs e)
        {
            Person person = new Person();
            person.Age = int.Parse(txtAge.Text);
            txtAge.Text = person.Age.ToString();
            
        }

    }
}

