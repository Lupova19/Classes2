using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    internal class Person
    {
        private string name;
        private int age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public void IntroduceYourself()
        {
            Console.WriteLine($"Аз съм {this.Name} и съм на {this.Age} години!");
        }
    }
}
