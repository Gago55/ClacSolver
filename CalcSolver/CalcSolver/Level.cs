using System;
using System.Collections.Generic;
using System.Text;

namespace CalcSolver
{
    class Level
    {
        public int moves;
        public int goal;
        public int value;

        public List<Element> elements;

        public Level(int moves, int value, int goal,List<Element> elements)
        {
            this.moves = moves;
            this.goal = goal;
            this.value = value;
            this.elements = elements;

            if (elements.Count == moves)
                SolveNoRepeat();
            else
                Solve();
        }

        public void SolveNoRepeat()
        {


            foreach (var permu in Permutate(elements, elements.Count))
            {
                int startValue = value;
                foreach (var i in permu)
                {
                    i.Do(ref value);
                }
                if (value != goal)
                    value = startValue;
                else
                {
                    foreach (var i in permu)
                    {
                        if (i.inst == Instruments.TRANS)
                            Console.Write(i.inst.ToString() + i.x.ToString() + " ");
                        else
                            Console.Write(i.inst.ToString() + " ");
                    }
                    break;
                }
            }
        }
        public void Solve()
        {
            int startValue = value;
            double count = Math.Pow(Convert.ToDouble(elements.Count), moves);

            for (int i = 0; i < count; i++)
            {
                string num = DecimalToArbitrarySystem(i, elements.Count);
                num = num.PadLeft(moves, '0');
                for (int j = 0; j < num.Length; j++)
                {
                    int index = Convert.ToInt32(num[j]) -48;
                    elements[index].Do(ref value);
                }
                if (value != goal)
                    value = startValue;
                else
                {
                    for (int j = 0; j < num.Length; j++)
                    {
                        int index = Convert.ToInt32(num[j]) - 48;
                        if(elements[index].inst==Instruments.TRANS)
                            Console.Write(elements[index].inst.ToString() + elements[index].x.ToString() + " ");
                        else
                        Console.Write(elements[index].inst.ToString() + " ");
                    }
                    Console.WriteLine();
                }
                
            }
        }


        public static string DecimalToArbitrarySystem(long decimalNumber, int radix)
        {
            const int BitsInLong = 64;
            const string Digits = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            if (radix < 2 || radix > Digits.Length)
                throw new ArgumentException("The radix must be >= 2 and <= " +
                    Digits.Length.ToString());

            if (decimalNumber == 0)
                return "0";

            int index = BitsInLong - 1;
            long currentNumber = Math.Abs(decimalNumber);
            char[] charArray = new char[BitsInLong];

            while (currentNumber != 0)
            {
                int remainder = (int)(currentNumber % radix);
                charArray[index--] = Digits[remainder];
                currentNumber = currentNumber / radix;
            }

            string result = new String(charArray, index + 1, BitsInLong - index - 1);
            if (decimalNumber < 0)
            {
                result = "-" + result;
            }

            return result;
        }
        public static void RotateRight(List<Element> sequence, int count)
        {
            Element tmp = sequence[count - 1];
            sequence.RemoveAt(count - 1);
            sequence.Insert(0, tmp);
        }
        public static IEnumerable<List<Element>> Permutate(List<Element> sequence, int count)
        {
            if (count == 1) yield return sequence;
            else
            {
                for (int i = 0; i < count; i++)
                {
                    foreach (var perm in Permutate(sequence, count -1 ))
                        yield return perm;
                    RotateRight(sequence, count);
                }
            }
        }
    }
}
