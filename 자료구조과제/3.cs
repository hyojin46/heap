//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace 자료구조과제
//{
//    public class Node
//    {
//        public string data; //루트값의 데이터
//        public Node left; //왼쪽 자식노드
//        public Node right; //오른쪽 자식노드
//        int heap_size;
//        Node [] heap;

//        public Node(string data) //생성자
//        {
//            this.data = data;
//        }

//        void init_heap() { heap_size = 0; }
//        int is_empty_heap() { return heap_size = 0; }
//        int is_full_heap() { return (heap_size = 100 - 1); }
//        Node find_heap() { return heap[1]; }

//        void insert_heap( Node n)
//        {

//            if (heap[100]) return;
//        }
//    }

//    class Test
//    {
//        static public void Main(string[] args)
//        {
//            MaxHeap mh = new MaxHeap();
//            mh.MaxHeapAdd(10);
//            mh.MaxHeapAdd(40);
//            mh.MaxHeapAdd(30);
//            mh.MaxHeapAdd(5);
//            mh.MaxHeapAdd(12);
//            mh.MaxHeapAdd(6);
//            mh.MaxHeapAdd(15);
//            mh.MaxHeapAdd(9);
//            mh.MaxHeapAdd(60);
//            mh.MaxHeapDelete();

//            for (int i = 0; i < mh.MaxHeapList.Count; i++)
//            {
//                Console.Write(mh.MaxHeapList[i]);
//            }
//        }
//    }


//}
