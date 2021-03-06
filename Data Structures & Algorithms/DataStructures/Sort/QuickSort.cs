﻿using BotterDSA.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Botter.CodeSnippets.DSA.Sort
{
    public class QuickSort
    {
        public void Sort(int[] m)
        {
            Sort(m, 0, m.Length - 1);
        }

        private void Sort(int[] m, int leftIdx, int rightIdx)
        {
            if (leftIdx < rightIdx)
            {
                var pivot = Partition(m, leftIdx, rightIdx);
                Sort(m, leftIdx, pivot - 1);
                Sort(m, pivot + 1, rightIdx);
            }
        }

        private int Partition(int[] m, int leftIdx, int rightIdx)
        {
            // get pivot as the right most element of the array
            var pivot = m[rightIdx];
            var i = leftIdx;

            for (var j = leftIdx; j < rightIdx; j++)
			{
                if (m[j] <= pivot) 
                {
                    BotterUtils.Swap(ref m[i], ref m[j]);

                    i++;
                }
			}
           
            var tm = m[rightIdx];
            m[rightIdx] = m[i];
            m[i] = tm;

            return i;
        }
    }
}
