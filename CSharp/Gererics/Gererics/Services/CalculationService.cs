﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gererics.Services
{
    class CalculationService
    {
        public T Max<T> (List<T> list) where T : IComparable
        {
            if (list == null || list.Count == 0)
            {
                throw new ArgumentException("List cannot be null or empty");
            }

            T max = list[0];
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i].CompareTo(max) > 0)
                    max = list[i];
            }
            return max;
        }
    }
}
