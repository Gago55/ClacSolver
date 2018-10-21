using System;
using System.Collections.Generic;
using System.Text;

namespace CalcSolver
{
    class Element
    {
        public Instruments inst = new Instruments();
        public int x;

        public Element(Instruments instrument,int x)
        {
            inst = instrument;
            this.x = x;
        }

        public Element(Instruments instrument)
        {
            inst = instrument;
        }
    }
}
