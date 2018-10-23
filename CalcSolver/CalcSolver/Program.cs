using System;
using System.Collections.Generic;
using System.Linq;

namespace CalcSolver
{
    class Program
    {
        static void Main(string[] args)
        {

            Element e1 = new Element(Instruments.ADDTONUM,2);     
            Element e2 = new Element(Instruments.MINUS, 1);
            Element e3 = new Element(Instruments.MULT, 3);
            Element e4 = new Element(Instruments.PLUS, 4);
            Element e5 = new Element(Instruments.REV);

            List<Element> seq = new List<Element>() {e1, e2, e5};

            Level level = new Level(3,121,212,3,seq);
            level.Solve();

            Console.ReadLine();
        }

        
    }
}
