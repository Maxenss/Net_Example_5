using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Net_Example_5
{
    class Complex : Pair
    {
        #region Поля
        // Рациональная часть числа
        private int rationalPart;
        // Иррациональная часть числа
        private int irrationalPart;
        #endregion

        #region Конструкторы
        public Complex()
        {
            this.rationalPart = 0;
            this.irrationalPart = 0;
        }

        public Complex(int _rationalPart, int _irrationalPart)
        {
            this.rationalPart = _rationalPart;
            this.irrationalPart = _irrationalPart;
        }
        #endregion

        #region Методы доступа
        public int GetRationalPart()
        {
            return rationalPart;
        }

        public int GetIrrationalPart()
        {
            return irrationalPart;
        }
        #endregion

        #region Методы
        // Метод для получения комплексно-сопряженного числа
        public Complex Conj()
        {
            return new Complex(this.rationalPart, this.irrationalPart * -1);
        }

        // Метод для сложения комплексных чисел
        public void Add(Pair opr2)
        {
            Complex operand2 = opr2 as Complex;

            this.rationalPart += operand2.rationalPart;
            this.irrationalPart += operand2.irrationalPart;
        }

        // Метод для деления комплексных чисел
        public void Difference(Pair opr2)
        {
            Complex operand2 = opr2 as Complex;

            this.rationalPart -= operand2.rationalPart;
            this.irrationalPart -= operand2.irrationalPart;
        }

        // Метод для произведения комплексных чисел
        public void Multiplication(Pair opr2)
        {
            Complex operand2 = opr2 as Complex;

            int temp_rationalPart = this.rationalPart;
            int temp_irrationalPart = this.irrationalPart;

            this.rationalPart = temp_rationalPart * operand2.rationalPart -
                temp_irrationalPart * operand2.irrationalPart;

            this.irrationalPart = temp_rationalPart * operand2.irrationalPart +
               temp_irrationalPart * operand2.rationalPart;
        }

        // Метод для деления комплексных чисел
        public void Division(Pair opr2)
        {
            Complex operand2 = opr2 as Complex;

            int temp_rationalPart = this.rationalPart;
            int temp_irrationalPart = this.irrationalPart;

            this.rationalPart = (int)((temp_rationalPart * operand2.rationalPart +
                temp_irrationalPart * operand2.irrationalPart) /
                (Math.Pow(operand2.rationalPart, 2) + Math.Pow(operand2.irrationalPart, 2)));

            this.irrationalPart = (int)((temp_irrationalPart * operand2.rationalPart -
                temp_rationalPart * temp_irrationalPart) /
                (Math.Pow(operand2.rationalPart, 2) + Math.Pow(operand2.irrationalPart, 2)));
        }

        // Метод для сравнения комплексных чисел
        public string Equals(Pair opr2)
        {
            Complex operand2 = opr2 as Complex;

            if (this.rationalPart == operand2.rationalPart &&
                this.irrationalPart == this.irrationalPart)
                return "Комплексные числа равны";

            return "Комплексные числа не равны";
        }

        // Переопределенный метод ToString()
        public override string ToString()
        {
            return rationalPart + " " + (this.irrationalPart < 0 ?
                "- " + irrationalPart * -1 :
                "+ " + irrationalPart) + "i";
        }
        #endregion
    }
}
