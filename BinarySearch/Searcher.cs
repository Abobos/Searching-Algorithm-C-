using System;
using System.Collections.Generic;

namespace BinarySearch
{
        public class Searcher
        {
            private readonly List<int> _proposedArray;

            public Searcher(List<int> arrays)
            {
                _proposedArray = arrays;

            }
            public int linearSearch(int element)
            {

                for (var i = 0; i < this._proposedArray.Count; i++)
                {
                    if (this._proposedArray[i] == element) return i;
                }
                return -1;
            }

            public int binarySearch(int element)
            {
                int lowerbound = 0;
                int upperBound = this._proposedArray.Count;
                int midPoint = 0;

            while (lowerbound <= upperBound) {

                midPoint = (int)Math.Floor(Convert.ToDouble(lowerbound + upperBound) / 2);
             
                var midPointElement = this._proposedArray[midPoint];

                if (midPointElement == element) return midPoint;

                if (element < midPointElement) upperBound = midPoint - 1;

                if (element > midPointElement) lowerbound = midPoint + 1;

            }

            return -1;
            }

    }
}
