﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDogsAndCircles
{
    public class CircleCompareByX : IComparer<Circle>
    {
        public int Compare(Circle x, Circle y)
        {
            if (x == null && y == null)
                return 0;
            if (x == null)
                return -1;
            if (y == null)
                return 1;

            return x.X.CompareTo(y.X);
        }
}
