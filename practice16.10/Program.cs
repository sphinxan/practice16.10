using System;

namespace practice16._10
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = 2; //ширина поля
            int height = 8; //высота поля
            int top = 0; //отступ сверху
            int left = 0; //отступ слева
            int heightcell = 3; //высота ячейки
            int widthcell = 3; //ширина ячейки
            DrawField(width, height, top, left, heightcell, widthcell);
        }

        static void DrawField(int width, int height, int top, int left, int heightcell, int widthcell)
        {
            Console.Write('┌');
            ChangeSymbols(width, widthcell, '─', '┬');
            Console.WriteLine("┐");

            for (int i = 0; i < height - 1; i++)
            {
                for (int j = 0; j < heightcell - 3; j++)
                {
                    Console.Write("│");
                    IsSymbols(widthcell, ' ', '│', 3);
                }
                Console.Write("├");
                ChangeSymbols(width, widthcell, '─', '┼');
                Console.WriteLine("┤");
            }
            IsSymbols(heightcell, '│', '└', 3);
            ChangeSymbols(width, widthcell, '─', '┴');
            Console.WriteLine("┘");
 
        }
        static void ChangeSymbols(int field, int cell, char a, char b)
        {
            for (int i = 0; i < field - 1; i++)
            {
                IsSymbols(cell, a, b, 1);
            }
            for (int i = 0; i < cell - 1; i++)
                Console.Write(a); 
        }
        static void IsSymbols(int f, char a, char b, int x)
        {
            for (int j = 0; j < f - x; j++)
                Console.Write(a);
            Console.Write(b);
        }
        static void IndentLeft(int num, char a)
        {
            Console.WriteLine(a.TryParse.PadLeft(num, ' '));
        }
        static void IndentTop(int num, )
        {
            Console.WriteLine(a.PadLeft(num, ' '));
        }
    }
}
