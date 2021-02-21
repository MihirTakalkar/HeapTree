using System;
using System.Collections.Generic;

namespace HeapTree
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> test = new List<int>{ 1, 9, 2, 13, 10, 3 };
            Heap<int> heaptest = new Heap<int>();
            for (int i = 0; i < test.Count; i++)
            {
                heaptest.Insert(test[i]);
            }
            heaptest.Insert(0);

       
        }
    }
}
