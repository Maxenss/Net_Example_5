using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Net_Example_5
{
    static class RationalTest
    {
        private static Rational rational1;
        private static Rational rational2;
         
        private static int numerator = 0;
        private static int denominator = 0;

        public static bool AddTest()
        {
            // Подготавливем данные
            rational1 = new Rational(2, 5);
            rational2 = new Rational(2, 5);

            // Ожидаемый результат
            int numerator = 4;
            int denominator = 5;

            // Производим тест метода
            rational1.Add(rational2);

            // Сравниваем ожидания и результат
            if (rational1.GetNumerator() == numerator &&
                rational1.GetDenominator() == denominator)
                return true;

            return false;
        }

        public static bool DifferenceTest()
        {
            // Подготавливем данные
            rational1 = new Rational(3, 5);
            rational2 = new Rational(2, 5);

            // Ожидаемый результат
            int numerator = 1;
            int denominator = 5;

            // Производим тест метода
            rational1.Difference(rational2);

            // Сравниваем ожидания и результат
            if (rational1.GetNumerator() == numerator &&
                rational1.GetDenominator() == denominator)
                return true;

            return false;
        }

        public static bool MultiplicationTest()
        {
            // Подготавливем данные
            rational1 = new Rational(4, 2);
            rational2 = new Rational(3, 5);

            // Ожидаемый результат
            int numerator = 6;
            int denominator = 5;

            // Производим тест метода
            rational1.Multiplication(rational2);

            // Сравниваем ожидания и результат
            if (rational1.GetNumerator() == numerator &&
                rational1.GetDenominator() == denominator)
                return true;

            return false;
        }

        public static bool DivisionTest()
        {
            // Подготавливем данные
            rational1 = new Rational(3, 2);
            rational2 = new Rational(4, 5);

            // Ожидаемый результат
            int numerator = 15;
            int denominator = 8;

            // Производим тест метода
            rational1.Division(rational2);

            // Сравниваем ожидания и результат
            if (rational1.GetNumerator() == numerator &&
                rational1.GetDenominator() == denominator)
                return true;

            return false;
        }

        public static bool EqualsTest()
        {
            // Подготавливем данные
            rational1 = new Rational(2, 3);
            rational2 = new Rational(2, 3);

            // Ожидаемый результат
            String result;
            result = "Дроби равны";

            // Производим тест метод и сравниваем ожидания и результат
            if (!(rational1.Equals(rational2).Equals(result)))
                return false;

            // Подготавливем данные
            rational1 = new Rational(5, 3);
            rational2 = new Rational(2, 3);

            // Ожидаемый результат
            result = "Исходная дробь больше";

            // Производим тест метод и сравниваем ожидания и результат
            if (!(rational1.Equals(rational2).Equals(result)))
                return false;

            // Подготавливем данные
            rational1 = new Rational(2, 3);
            rational2 = new Rational(5, 3);

            // Ожидаемый результат
            result = "Исходная дробь меньше";

            // Производим тест метод и сравниваем ожидания и результат
            if (!(rational1.Equals(rational2).Equals(result)))
                return false;

            return true;
        }
    }
}
