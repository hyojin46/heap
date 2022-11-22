using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class MaxHeap
{
    int i,;
    int heap_size;
    data
    int data_left = data * 2; //왼쪽 자식노드
    int data_right = data * 2 + 1; //오른쪽 자식노드
}
    class Test
{
    static public void Main(string[] args)
    {
        MaxHeap mh = new MaxHeap();
        mh.MaxHeapAdd(10);
        mh.MaxHeapAdd(40);
        mh.MaxHeapAdd(30);
        mh.MaxHeapAdd(5);
        mh.MaxHeapAdd(12);
        mh.MaxHeapAdd(6);
        mh.MaxHeapAdd(15);
        mh.MaxHeapAdd(9);
        mh.MaxHeapAdd(60);
        mh.MaxHeapDelete();

        for (int i = 0; i < mh.MaxHeapList.Count; i++)
        {
            Console.Write(mh.MaxHeapList[i]);
        }
    }
}

