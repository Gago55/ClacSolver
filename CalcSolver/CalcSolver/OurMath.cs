using System;
using System.Collections.Generic;
using System.Text;

namespace CalcSolver
{
    class OurMath
    {
        public void Plus(ref int value , int x)
        {
            value += x;
        }

        public void Minus(ref int value, int x)
        {
            value -= x;
        }

        public void AddToNum(ref int value, string x)
        {
            string result = value.ToString() + x;
            value = Convert.ToInt32(result);
        }
    }
}
