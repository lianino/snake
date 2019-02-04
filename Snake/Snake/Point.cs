using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        public int x;
        public int y;
        public char sym;

        public Point()  //конструктор 1
        {
        }

        public Point(int _x,int _y,char _sym) // конструктор 2
        {
            x = _x;
            y = _y;
            sym = _sym;
        }

        public Point(Point p)// конструктор 3
        {
            x = p.x;
            y = p.x;
            sym = p.sym;
        }

        public void Move(int offset,Direction direction) // метод движения
        {
            if (direction == Direction.RIGHT)
            {
                x = x + offset;
            }
            else if (direction == Direction.LEFT)
            {
                x = x - offset;
            }
            else if (direction == Direction.UP)
            {
                y = y + offset;
            }
            else y = y - offset;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

        //Какая то магия С#
        public override string ToString()
        {
            return x + ", " + y + ", " + sym;
        }
    }
}
