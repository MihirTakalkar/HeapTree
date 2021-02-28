using System;
using System.Collections.Generic;

namespace HeapTree
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> test = new List<int>();

            Random rand = new Random();

            for (int i = 0; i < 10; i++)
            {
                test.Add(rand.Next(1, 100));
            }

            Heap<int> heaptest = new Heap<int>();
            for (int i = 0; i < test.Count; i++)
            {
                heaptest.Insert(test[i]);
            }

            for (int i = 0; i < test.Count; i++)
            {
                Console.WriteLine(heaptest.Pop());
            }
            
        }
    }
}
