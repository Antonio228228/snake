using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21maiAnton
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Clear();
            Console.Title = "Snake";
            Console.SetWindowSize(101, 26);
            Console.Beep();


            Walls walls = new Walls(80, 25);
            walls.Draw();



            //отрисовка рамочки
            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, '+');
            VerticalLine leftline = new VerticalLine(0, 24, 0, '+');
            VerticalLine rightline = new VerticalLine(0, 24, 78, '+');
            upLine.Draw();
            downLine.Draw();
            leftline.Draw();
            rightline.Draw();




            //отрисовка точек
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT); //zadaem xBocT
            snake.Draw();
            snake.Move();



            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();


            //prepjatstvie dlja zmeiki
            /*List<int> numList = new List<int>();
            numList.Add(0);
            numList.Add(1);
            numList.Add(2);

            int x = numList[0]; //v peremennuju x zapisivaem zna4enie pervogo elementa spiska
            int y = numList[1];
            int z = numList[2];

            foreach(int i in numList)
            {
                Console.WriteLine(i);
            }

            numList.RemoveAt(0); //funkcija spiska remove 4tobi udalit element po porjadkovomu nomeru

            List<Point> pList = new List<Point>();
            pList.Add(p1); //dobavlaem peremennie
            pList.Add(p2);*/



            /*static void Draw(int x, int y, char sym) //funkcija budet vqvodit na ekran to4ku.
            {
                Console.SetCursorPosition(x, y); //ukazivaem koordinatq
                Console.Write(sym); //vqvodim v etoi pozicii symbol
            }*/

            while (true)
            {
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    break;
                }
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }

                Thread.Sleep(100);
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey()
                }
            }
        }
    }
}
