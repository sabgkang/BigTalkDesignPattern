using System;

namespace 大話01_Factory
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

            運算類別 oper = Factory.ProduceOperator(operatorStr);
            oper.NumberA = Convert.ToDouble(numberAStr);
            oper.NumberB = Convert.ToDouble(numberBStr);
            Console.WriteLine(oper.operation());
            Console.ReadKey();
        }
    }

    class Factory 
    {
        static 運算類別 oper = null;
        public static 運算類別 ProduceOperator(string operatorStr)
        {
            switch (operatorStr)
            {
                case "+": oper = new Plus(); break;
                case "-": oper = new Minus(); break;
                case "*": oper = new Multiply(); break;
                case "/": oper = new Divide(); break;
            }
            return oper;
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
