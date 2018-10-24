using System;
using System.Collections.Generic;
using System.Text;

namespace CalcSolver
{
    class Element : OurMath
    {
        public Instruments inst = new Instruments();
        public int x;
        public int y;
        int argument;

        public Element(Instruments instrument,int x)
        {
            inst = instrument;
            this.x = x;
            argument = 2;
        }

        public Element(Instruments instrument)
        {
            inst = instrument;
            argument = 2;
        }

        public Element(Instruments instrument , int x , int y)
        {
            inst = instrument;
            this.x = x;
            this.y = y;
            argument = 3;
        }

        public void Do(ref int value)
        {
            if(argument == 1)
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
            else if (argument == 2)
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
            else
            {
                if(inst == Instruments.TRANS)
                {
                    Transformation(ref value,x,y);
                }
            }
        }
    }
}
