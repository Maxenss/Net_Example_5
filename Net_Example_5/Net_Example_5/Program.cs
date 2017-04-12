using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Net_Example_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Проверяем методы класса Rational : ");
            Console.WriteLine("Метод Rational.Add - " + RationalTest.AddTest());
            Console.WriteLine("Метод Rational.Difference - " + RationalTest.DifferenceTest());
            Console.WriteLine("Метод Rational.Multiplication - " + RationalTest.MultiplicationTest());
            Console.WriteLine("Метод Rational.Division - " + RationalTest.DivisionTest());
            Console.WriteLine("Метод Rational.Equals - " + RationalTest.EqualsTest());

            Console.WriteLine();

            Console.WriteLine("Проверяем методы класса Complex : ");
            Console.WriteLine("Метод Complex.Add - " + ComplexTest.AddTest());
            Console.WriteLine("Метод Complex.Difference - " + ComplexTest.DifferenceTest());
            Console.WriteLine("Метод Complex.Multiplication - " + ComplexTest.MultiplicationTest());
            Console.WriteLine("Метод Complex.Division - " + ComplexTest.DivisionTest());
            Console.WriteLine("Метод Complex.Equals - " + ComplexTest.EqualsTest());

            Console.ReadKey();

        }
    }
}
