using System;
using System.Collections.Generic;
using System.Text;

namespace CalcSolver
{
    class Level
    {
        public int moves ;
        public int goal ;
        public int value ;
        public int instruments ;
        public List<Element> elements;

        public Level(int moves ,int value, int goal , int instruments , List<Element> elements)
        {
            this.moves = moves;
            this.goal = goal;
            this.value = value;
            this.instruments = instruments;
            this.elements = elements;
        }


    }
}
