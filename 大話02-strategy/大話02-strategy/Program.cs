using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 大話02_strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input NumberA:");
            string numberAStr = Console.ReadLine();

            Console.WriteLine("Input NumberB:");
            string numberBStr = Console.ReadLine();

            Console.WriteLine("Input Operator:");
            string operatorStr = Console.ReadLine();

            Calculator calculator = new Calculator(
                Convert.ToDouble(numberAStr),
                Convert.ToDouble(numberBStr),
                operatorStr
            );

            Console.WriteLine(calculator.operation());
            Console.ReadKey();
        }
    }

    class Calculator
    {
        運算類別 oper = null;

        public Calculator(double numberA, double numberB, string operatorStr)
        {
            switch (operatorStr) {
                case "+": this.oper = new Plus();     break;
                case "-": this.oper = new Minus();    break;
                case "*": this.oper = new Multiply(); break;
                case "/": this.oper = new Divide();   break;
            }          
            this.oper.NumberA = numberA;
            this.oper.NumberB = numberB;
        }

        public double operation()
        {
            return this.oper.operation();
        }
    }

    abstract class 運算類別
    {
        public double NumberA;
        public double NumberB;

        public abstract double operation();
    }

    class Plus : 運算類別
    {
        public override double operation()
        {
            return NumberA + NumberB;
        }
    }

    class Minus : 運算類別
    {
        public override double operation()
        {
            return NumberA - NumberB;
        }
    }

    class Multiply : 運算類別
    {
        public override double operation()
        {
            return NumberA * NumberB;
        }
    }

    class Divide : 運算類別
    {
        public override double operation()
        {
            return NumberA / NumberB;
        }
    }

}
