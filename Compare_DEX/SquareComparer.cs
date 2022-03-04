using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Compare_DEX
{
    class SquareComparer : IComparer<Square>
    {
        public int Compare([AllowNull] Square x, [AllowNull] Square y)
        {
            if (x != null && y!= null)
            {
                return  y.Area - x.Area ;
            }
            else
            {
                throw new Exception();
            }
        }
    }
}
