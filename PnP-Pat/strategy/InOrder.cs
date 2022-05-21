using System.Collections.Generic;

namespace Ventus
{
    internal class InOrder : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            //return x.CompareTo(y);
            //return x - y;
            if (x == y)
                return 0;
            if (x < y)
                return -1;
            return 1;
        }
    }
}