using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch.Task4.Library
{
    public static class BinarySearch<T>
    {
        public static bool Search(IComparable<T>[] sortedSet, IComparable<T> wanted)
        {
            int firstIndex = 0;
            int lastIndex = sortedSet.Length;

            if (lastIndex == firstIndex)
                return false;

            int cursor = (int)(firstIndex + ((lastIndex - firstIndex) / 2));

            if (sortedSet[cursor].CompareTo((T)wanted)==1)
            {

            }






            return true;
        }
    }
}
