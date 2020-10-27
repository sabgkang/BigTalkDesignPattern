using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 大話_Decorate
{
    class Program
    {
        static void Main(string[] args)
        {

            Person person = new Person("John");

            TShirts tShirt = new TShirts();
            BigTrouser bigTrouser = new BigTrouser();
            Sneakers sneaker = new Sneakers();
            Suit suit = new Suit();
            Tie tie = new Tie();
            LeatherShoe leatherShoe = new LeatherShoe();

            tShirt.Decorate(person);
            sneaker.Decorate(tShirt);
            //bigTrouser.Decorate(tShirt);


            sneaker.Show();

            Console.ReadKey();
        }
    }

    class Person
    {
        public Person() { }

        public string name;
        public Person(string name)
        {
            this.name = name;
        }
        public virtual void Show()
        {
            Console.WriteLine("裝扮的{0}", name);
        }
    }

    class Finery : Person
    {
        protected Person person;


        public void Decorate(Person person)
        {
            this.person = person;
        }

        public override void Show()
        {
            if (person != null)
            {
                person.Show();
            }
        }
    }

    class TShirts : Finery
    {
        public override void Show()
        {
            Console.Write("大T恤 ");
            base.Show();
        }
    }

    class BigTrouser : Finery
    {
        public override void Show()
        {
            Console.Write("垮褲 ");
            base.Show();
        }
    }

    class Sneakers : Finery
    {
        public override void Show()
        {
            Console.Write("破球鞋 ");
            base.Show();
        }
    }

    class Suit : Finery
    {
        public override void Show()
        {
            Console.Write("西裝 ");
            base.Show();
        }
    }

    class Tie : Finery
    {
        public override void Show()
        {
            Console.Write("領帶 ");
            base.Show();
        }
    }

    class LeatherShoe : Finery
    {
        public override void Show()
        {
            Console.Write("皮鞋 ");
            base.Show();
        }
    }

}
