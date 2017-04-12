using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Net_Example_5
{
    class Rational : Pair
    {
        #region Поля
        // Числитель
        private int numerator;
        // Знаменатель
        private int denominator;
        #endregion

        #region Конструкторы

        public Rational()
        {
            this.numerator = 0;
            this.denominator = 0;
        }

        public Rational(int _numerator, int _denominator)
        {
            this.numerator = _numerator;
            this.denominator = _denominator;

            this.Reduce();
        }

        #endregion

        #region Методы доступа
        // Получить числитель
        public int GetNumerator() { return numerator; }
        // Получить знаменатель
        public int GetDenominator() { return denominator; }
        #endregion

        #region Методы

        #region public - методы
        // Метод для суммирования дробей
        public void Add(Pair opr2)
        {
            Rational operand2 = opr2 as Rational;

            this.numerator = this.numerator * operand2.denominator +
                this.denominator * operand2.numerator;

            this.denominator *= operand2.denominator;

            this.Reduce();
        }

        // Метод для получения разницы дробей
        public void Difference(Pair opr2)
        {
            Rational operand2 = opr2 as Rational;

            this.numerator = this.numerator * operand2.denominator -
                this.denominator * operand2.numerator;

            this.denominator *= operand2.denominator;

            this.Reduce();
        }

        // Метод для произведения дробей
        public void Multiplication(Pair opr2)
        {
            Rational operand2 = opr2 as Rational;

            this.numerator *= operand2.numerator;
            this.denominator *= operand2.denominator;

            Reduce();
        }

        // Метод для деления дробей
        public void Division(Pair opr2)
        {
            Rational operand2 = opr2 as Rational;

            this.numerator *= operand2.denominator;
            this.denominator *= operand2.numerator;

            Reduce();
        }

        // Метод для сравнения дробей
        public string Equals(Pair opr2)
        {
            Rational operand2 = opr2 as Rational;

            // Приводим к общему знаменателю
            this.numerator *= operand2.denominator;
            operand2.numerator *= this.denominator;
            this.denominator *= operand2.denominator;
            operand2.denominator = this.denominator;

            //Сокращаем дроби
            this.Reduce();
            operand2.Reduce();

            // Сравниваем числители у дробей
            if (this.numerator == operand2.numerator)
                return "Дроби равны";
            else if (this.numerator < operand2.numerator)
                return "Исходная дробь меньше";
            else
                return "Исходная дробь больше";

        }

        // Переопределенный метод ToString()
        public override string ToString()
        {
            return "Числитель : " + numerator + ", знаменатель : " + denominator;
        }
        #endregion

        #region private - методы
        // Метод для сокращения дроби
        private void Reduce()
        {
            if (numerator != 0)
            {
                int m = denominator,
                n = numerator,
                ost = m % n;

                // вычисление НОД(числитель, знаменатель)
                // алгоритмом Евклида
                while (ost != 0)
                {
                    m = n; n = ost;
                    ost = m % n;
                }

                int nod = n;

                if (nod != 1)
                {
                    numerator /= nod; denominator /= nod;
                }

                if (this.numerator < 0 && this.denominator < 0) {
                    this.numerator *= -1;
                    this.denominator *= -1;
                }
            }
        }
        #endregion

        #endregion
    }
}