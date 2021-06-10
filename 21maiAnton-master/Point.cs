using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21maiAnton
{
    class Point //class eto tip dannqh. Opisivaem kak vqgladit to4ka.
    {
        public int x; //peremennqe kotorie zadajut koordinatq to4ki po osi x
        public int y;
        public char sym;

        public Point() //konstruktor nikogda ne vozvrawaet
        {
            Console.WriteLine("Создается новая точка");
        }
        //konstruktori - metodi s pomowi kotorih mi mowem sozdavat to4ki.
        public Point(int _x, int _y, char _sym) //funkcija kotoraja ponimaet koordinatq
        {
            x = _x;
            y = _y;
            sym = _sym;
        }


        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }

        public void Move(int offset, Direction direction) //delaem napravlenija
        {
            if(direction == Direction.RIGHT)
            {
                x = x + offset;
            }
            else if(direction == Direction.LEFT)
            {
                x = x - offset;
            }
            else if(direction == Direction.UP)
            {
                y = y + offset;
            }
            else if (direction == Direction.DOWN)
            {
                y = y - offset;
            }
        }

        public bool IsHit(Point p)
        {
            return p.x == this.x && p.y == this.y;
        }

        public void Draw()  //metod narisovat to4ku. Void ozna4aet 4to ni4ego ne nado vozvrawat
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
        public void Clear()
        {
            sym = ' ';
            Draw();
        }

        public override string ToString()
        {
            return x + ", " + y + ", " + sym;
        }

    }

}
