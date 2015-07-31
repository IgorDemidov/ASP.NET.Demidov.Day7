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

            while (true)
            {
                int cursor = (int)(firstIndex + ((lastIndex - firstIndex) / 2));

                if (firstIndex == lastIndex)
                    if (firstIndex == cursor)
                        return true;
                    else
                        return false;

                switch (sortedSet[cursor].CompareTo((T)wanted))
                {
                    case 1:
                        lastIndex = cursor;
                        break;
                    case -1:
                        firstIndex = cursor;
                        break;
                    case 0:
                        firstIndex = cursor;
                        lastIndex = cursor;
                        break;
                }
            }
        }
    }
}
