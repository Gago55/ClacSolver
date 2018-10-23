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
        public int instruments;
        public List<Element> elements;

        public Level(int moves, int value, int goal, int instruments, List<Element> elements)
        {
            this.moves = moves;
            this.goal = goal;
            this.value = value;
            this.instruments = instruments;
            this.elements = elements;
        }

        public void Solve()
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
                        Console.Write(i.inst.ToString() + " ");
                    }
                    break;
                }
            }
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
                    foreach (var perm in Permutate(sequence, count - 1))
                        yield return perm;
                    RotateRight(sequence, count);
                }
            }
        }
    }
}
