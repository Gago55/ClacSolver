using System;
using System.Collections.Generic;
using System.Linq;

namespace CalcSolver
{
    class Program
    {
        static void Main(string[] args)
        {

            Element e1 = new Element(Instruments.P2M);
            Element e2 = new Element(Instruments.PLUS, 7);
            Element e3 = new Element(Instruments.MULT, 3);
            Element e4 = new Element(Instruments.REV);

            List<Element> elements = new List<Element>() { e1 , e2 , e3 , e4};

            Level level = new Level(5, 0, -5, elements);
           
            Console.ReadLine();
        }
        


    }
}
