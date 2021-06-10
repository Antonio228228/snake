using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21maiAnton
{
    class HorizontalLine : Figure //linija - 4astniy slu4ai figure, soderwit vsjo 4to v figure
    {
        public HorizontalLine(int xLeft, int xRight, int y, char sym ) //zadaem koordinatq v konstruktore, x iveli4ivaeca na 1
        {
            pList = new List<Point>(); //pustoi spisok
            for(int x = xLeft; x <= xRight; x++) //peremennaja x polutaet ot xleft zakan4ivaja xright
            {
                Point p = new Point(x, y, sym); //sozdanie to4ek s nuzhnqmi koordinatami
                pList.Add(p); //dobavlaem v spisok to4ek
            }
            
        }

        
    }
}
