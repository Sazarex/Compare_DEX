using System;
using System.Collections.Generic;

namespace Compare_DEX
{
    class Program
    {
        static void Main(string[] args)
        {
            int size_of_array = 0;
            while (true)
            {
                Console.Write("Введите кол-во квадратов, которые нужно создать:");
                try
                {
                    size_of_array = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Введите число.");
                }
            }

            Random rnd = new Random();

            Square[] squares = new Square[size_of_array];

            for (int i = 0; i < size_of_array; i++)
            {
                squares[i] = new Square(rnd.Next(51));
            }
            //Array.Sort(squares);
            Array.Sort(squares,new SquareComparer());

            for (int i = 0; i < size_of_array; i++)
            {
                Console.WriteLine(squares[i].Area);
            }

        }
    }
}
