using System.Collections.Generic;

namespace Ventus
{
    internal class Reverse : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            //return y.CompareTo(x);
            //return y - x;
            if (x == y)
                return 0;
            if (x < y)
                return 1;
            return -1;
        }
    }
}