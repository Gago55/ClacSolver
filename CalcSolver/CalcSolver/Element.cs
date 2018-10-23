using System;
using System.Collections.Generic;
using System.Text;

namespace CalcSolver
{
    class Element : OurMath
    {
        public Instruments inst = new Instruments();
        public int x;
        bool oneArgument;

        public Element(Instruments instrument,int x)
        {
            inst = instrument;
            this.x = x;
            oneArgument = false;
        }

        public Element(Instruments instrument)
        {
            inst = instrument;
            oneArgument = true;
        }

        public void Do(ref int value)
        {
            if(oneArgument)
            {
                switch (inst)
                {
                    case Instruments.P2M:
                        P2M(ref value);
                        break;
                    case Instruments.REMOVE:
                        RemoveLast(ref value);
                        break;
                    case Instruments.REV:
                        Reverse(ref value);
                        break;
                }
            }
            else
            {
                switch (inst)
                {
                    case Instruments.PLUS:
                        Plus(ref value , x);
                        break;
                    case Instruments.MINUS:
                        Minus(ref value, x);
                        break;
                    case Instruments.MULT:
                        Multiplication(ref value, x);
                        break;
                    case Instruments.DIV:
                        Division(ref value, x);
                        break;
                    case Instruments.ADDTONUM:
                        AddToNum(ref value, x.ToString());
                        break;
                }
            }
        }
    }
}
