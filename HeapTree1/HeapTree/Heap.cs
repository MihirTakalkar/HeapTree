using System;
using System.Collections.Generic;
using System.Text;

namespace HeapTree
{
    class Heap<T> where T: IComparable
    {
        List<T> heap = new List<T>();
        public void Insert(T val)
        {
            //add value
            heap.Add(val);
            //heapifyUp
            HeapifyUp(heap.Count - 1);
        }

        void HeapifyUp(int ind)
        {
            if(ind == 0)
            {
                //if root is reached
                return;
            }

            int parent = (ind - 1) / 2;
            if (heap[ind].CompareTo(heap[parent]) < 0)
            {
                //swap
                T temp = heap[parent];
                heap[parent] = heap[ind];
                heap[ind] = temp;
                ind = parent;
            }

            else
            {
                //if no more swaps can be made
                return;
            }

            //recursive call
            HeapifyUp(ind);
        }


        T Pop()
        {


        }


        void HeapifyDown()
        {

        }



    }
}
