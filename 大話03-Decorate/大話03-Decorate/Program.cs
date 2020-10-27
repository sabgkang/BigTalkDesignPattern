using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 大話03_Decorate
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("John");

            TShirt tShirt = new TShirt();
            Sneaker sneaker = new Sneaker();
            tShirt.Decorate(person);
            sneaker.Decorate(tShirt);  
            sneaker.Show();

            Console.ReadKey();
        }
    }

    class Finery
    {
        public string item = "";
        public Finery finery = null;
        public void Decorate(Finery finery)
        {
            this.finery = finery;
        }

        public virtual void Show()
        {
            Console.Write("2:" + item);
            this.finery.Show();
        }
    }

    class Person : Finery
    {
        private string name = "";
        public Person() { }
        public Person(string name)
        {
            this.name = name;
        }

        public override void Show()
        {
            Console.WriteLine("{0}的裝扮", name);
        }

    }

    class TShirt : Finery
    {
        //public Finery finery = null;

        public TShirt()
        {
            item = "TShirt ";
        }
    }

    class Sneaker : Finery
    {
        //public Finery finery = null;

        public Sneaker()
        {
            item = "Sneaker ";
        }
    }
}
