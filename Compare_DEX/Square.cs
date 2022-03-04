using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Compare_DEX
{
    class Square: IArea, IComparable<Square>
    {
        private int Side { get; set; }
        public int Area { get; set; }

        private static int CountOfSquares { get; set; }

        public static void OutputCountOfSquares()
        {
            Console.WriteLine($"Количество квадратов:{CountOfSquares}");
        }

        public int GetArea()
        {
            return Side * Side;
        }

        public int CompareTo(Square? other)
        {
            if (other != null)
            {
                return other.Area - Area;
            }
            else
            {
                throw new Exception("Ошибка в сравнении.");
            }
        }

        public Square (int Side)
        {
            this.Side = Side;
            Area = GetArea();
            Console.WriteLine($"Создан круг со стороной {Side}");
        }
    }
}
