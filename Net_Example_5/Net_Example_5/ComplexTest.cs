using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Net_Example_5
{
    class ComplexTest
    {
        private static Complex complex1;
        private static Complex complex2;

        private static int rationalPart = 0;
        private static int irrationalPart = 0;

        public static  bool AddTest()
        {
            // Подготавливем данные
            complex1 = new Complex(2, 5);
            complex2 = new Complex(2, 5);

            // Ожидаемый результат
            rationalPart = 4;
            irrationalPart = 10;

            // Производим тест метода
            complex1.Add(complex2);

            // Сравниваем ожидания и результат
            if (complex1.GetRationalPart() == rationalPart &&
                complex1.GetIrrationalPart() == irrationalPart)
                return true;

            return false;
        }

        public static bool DifferenceTest()
        {
            // Подготавливем данные
            complex1 = new Complex(5, 9);
            complex2 = new Complex(2, 5);

            // Ожидаемый результат
            rationalPart = 3;
            irrationalPart = 4;

            // Производим тест метода
            complex1.Difference(complex2);

            // Сравниваем ожидания и результат
            if (complex1.GetRationalPart() == rationalPart &&
                complex1.GetIrrationalPart() == irrationalPart)
                return true;

            return false;
        }

        public static bool MultiplicationTest()
        {
            // Подготавливем данные
            complex1 = new Complex(5, 9);
            complex2 = new Complex(2, 5);

            // Ожидаемый результат
            rationalPart = -35;
            irrationalPart = 43;

            // Производим тест метода
            complex1.Multiplication(complex2);

            // Сравниваем ожидания и результат
            if (complex1.GetRationalPart() == rationalPart &&
                complex1.GetIrrationalPart() == irrationalPart)
                return true;

            return false;
        }

        public static bool DivisionTest()
        {
            // Подготавливем данные
            complex1 = new Complex(5, 9);
            complex2 = new Complex(2, 5);

            // Ожидаемый результат
            rationalPart = 1;
            irrationalPart = 0;

            // Производим тест метода
            complex1.Division(complex2);

            // Сравниваем ожидания и результат
            if (complex1.GetRationalPart() == rationalPart &&
                complex1.GetIrrationalPart() == irrationalPart)
                return true;

            return false;
        }

        public static bool EqualsTest()
        {
            // Подготавливем данные
            complex1 = new Complex(2, 3);
            complex2 = new Complex(2, 3);

            // Ожидаемый результат
            String result;
            result = "Комплексные числа равны";

            // Производим тест метод и сравниваем ожидания и результат
            if (!(complex1.Equals(complex2).Equals(result)))
                return false;

            // Подготавливем данные
            complex1 = new Complex(5, 3);
            complex2 = new Complex(2, 3);

            // Ожидаемый результат
            result = "Комплексные числа не равны";

            // Производим тест метод и сравниваем ожидания и результат
            if (!(complex1.Equals(complex2).Equals(result)))
                return false;

            return true;
        }

    }
}
