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
            if(value % x == 0)
            if(x!=0)
            value /= x;
        }

        public void AddToNum(ref int value, string x)
        {
            string result = value.ToString() + x;
            value = Convert.ToInt32(result);
        }

        public void Reverse(ref int value)
        {
            bool minus = false;

            if (value<0)
            {
                minus = true;
                P2M(ref value);
            }

            string num = value.ToString();
            string newnum ="";
            while(num.Length > 0)
            {
                int lastIndex = num.Length - 1;
                newnum += num[lastIndex];
                num = num.Remove(lastIndex);
            }
            value = Convert.ToInt32(newnum);

            if (minus) P2M(ref value);
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
            string num = value.ToString();
            string newnum = "";
            string X = x.ToString();
            string Y = y.ToString();

            if (X.Length == 1)
            {
                for (int i = 0; i < num.Length; i++)
                {
                    if (num[i].ToString() == X)
                    {
                        newnum += Y;
                    }
                    else
                    {
                        newnum += num[i];
                    }
                }
                value = Convert.ToInt32(newnum);
            }
            else
            {
                int changed = 0;
                for (int i = 0; i < num.Length; i++)
                {
                    string partOfString="";
                    bool lastChars = false;
                    

                    if (num.Length - i < X.Length)
                        lastChars = true;
                    
                    if(changed == 0)
                    for(int j = 0; j < X.Length; j++)
                    {
                        if(!lastChars)
                        partOfString += num[i + j];
                    }

                    if ( partOfString == X)
                    {
                        newnum += Y;
                        changed = X.Length;
                    }
                    else
                    {
                        if (changed == 0)
                            newnum += num[i];
                    }

                    if (changed > 0)
                        changed--;
                }
                value = Convert.ToInt32(newnum);
            }
        }

        private int getCountsOfDigits(long number)
        {
            string num = number.ToString();
            return num.Length;
        }

    }
}
