using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Net_Example_5
{
    interface Pair
    {
        void Add(Pair opr2);
        void Difference(Pair opr2);
        void Multiplication(Pair opr2);
        void Division(Pair opr2);
        String Equals(Pair opr2);
    }
}
