using System;
using System.Collections.Generic;
using System.Text;

namespace HeapTree
{
    class Heap<T> where T : IComparable
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
            if (ind == 0)
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


        public T Pop()
        {
            //save root
            T root = heap[0];
            heap[0] = heap[heap.Count - 1];
            heap.RemoveAt(heap.Count - 1);

            //HeapifyDown
            HeapifyDown(0);

            return root;

        }


        void HeapifyDown(int ind)
        {
            int leftind = (ind * 2) + 1;

            if (leftind >= heap.Count)
            {
                return;
            }

            int rightind = (ind * 2) + 2;
            int minind = ind;

            if (rightind >= heap.Count)
            {
                minind = leftind;
            }

            else
            {
                T leftChild = heap[leftind];
                T rightChild = heap[rightind];
                //find min child and swap
                if (leftChild.CompareTo(rightChild) < 0)
                {
                    minind = leftind;
                }

                else
                {
                    minind = rightind;
                }
            }


            if(heap[ind].CompareTo(heap[minind]) > 0)
            {
                T temp = heap[minind];
                heap[minind] = heap[ind];
                heap[ind] = temp;
            }

            HeapifyDown(minind);
        }



    }
}
