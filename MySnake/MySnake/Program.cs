﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySnake
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 3;
            int y1 = 1;
            char sym1 = '*';
            Draw(x1, y1, sym1);

            int x2 = 7;
            int y2 = 4;
            char sym2 = '#';
            Draw(x2, y1, sym2);
            Console.ReadLine();
        }
        static void Draw(int x, int y, char sym)
        {
            Console.SetCursorPosition( x , y );
            Console.Write(sym);
        }
    }
}
