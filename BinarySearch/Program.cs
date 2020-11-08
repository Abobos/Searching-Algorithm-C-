using System;
using System.Collections.Generic;

namespace BinarySearch
{

    class Program
    {
      
        static void Main(string[] args)
        {
            var arrayToSearch = new List<int>() { 10, 14, 19, 26, 27, 31, 33, 35, 42, 44 };
            var searcher = new Searcher(arrayToSearch);
            Console.WriteLine(searcher.linearSearch(4));
            Console.WriteLine(searcher.binarySearch(26));
        }
    }

    
}
