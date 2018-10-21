using System;
using System.Collections.Generic;
using System.Text;

namespace CalcSolver
{
    class OurMath
    {
        public void P2M(ref int value)
        {
            value *= -1;
        }

        public void Plus(ref int value , int x)
        {
            value += x;
        }

        public void Minus(ref int value, int x)
        {
            value -= x;
        }

        public void Multiplication(ref int value, int x)
        {
            value *= x;
        }

        public void Division(ref int value, int x)
        {
            value /= x;
        }

        public void AddToNum(ref int value, string x)
        {
            string result = value.ToString() + x;
            value = Convert.ToInt32(result);
        }

        public void Reverse(ref int value)
        {
            string num = value.ToString();
            string newnum ="";
            while(num.Length > 0)
            {
                int lastIndex = num.Length - 1;
                newnum += num[lastIndex];
                num = num.Remove(lastIndex);
            }
            value = Convert.ToInt32(newnum);
        }

        public void RemoveLast(ref int value)
        {
            string num = value.ToString();
            int lastIndex = num.Length - 1;
            num = num.Remove(lastIndex);
            value = Convert.ToInt32(num);
        }

        public void Transformation(ref int value , int x , int y)
        {

        }

        private int getCountsOfDigits(long number)
        {
            string num = number.ToString();
            return num.Length;
        }
    }
}
