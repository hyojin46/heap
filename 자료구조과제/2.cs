//using System;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//public class MaxHeap
//{
//    public List<int> MaxHeapList = new List<int>(); //힙리스트 생성
//    public void swap(List<int> MaxHeapList, int a, int b) //부모노드와 자식노드의 값을 변경해주는 메소드
//    {
//        int temp = MaxHeapList[a];
//        MaxHeapList[a] = MaxHeapList[b];
//        MaxHeapList[b] = temp;
//    }
//    public bool compare_up(int add_data) //부모노드와 자식노드의 값을 비교하는 메소드(up메소드)
//    {
//        if (add_data <= 1) return false; // 삽입된 데이터가 하나일 경우(루트만 있는 경우)
//        if (MaxHeapList[add_data / 2] < MaxHeapList[add_data]) return true; //자식노드값 < 부모노드값
//        else return false;
//    }
//    public bool compare_down(int add_data) //부모노드와 자식노드의 값을 비교하는 메소드(down메소드)
//    {
//        int add_data_left = add_data * 2; //왼쪽 자식노드
//        int add_data_right = add_data * 2 + 1; //오른쪽 자식노드

//        if (add_data_left > MaxHeapList.Count) //자식노드가 없는 경우
//            return false;
//        else if (add_data_left == MaxHeapList.Count) //자식노드가 하나만 존재하는 경우
//        {
//            if (MaxHeapList[add_data] < MaxHeapList[add_data_left]) //자식노드가 부모노드보다 작은 경우
//                swap(MaxHeapList, add_data_left, add_data); //자식노드와 부모노드를 exchange해줌
//            return false;
//        }
//        else //자식노드가 두개 다 존재하는 경우
//        {
//            if (MaxHeapList[add_data_left] < MaxHeapList[add_data_right] && MaxHeapList[add_data] < MaxHeapList[add_data_right]) return true;
//            //se if ()
//            else return false;
//        }
//    }
//    public bool MaxHeapAdd(int data) //삽입 메소드
//    {
//        MaxHeapList.Add(0); // 리스트의 0번 인덱스는 사용하지 않음
//        MaxHeapList.Add((int)data); //1번데이터부터 데이터를 넣음

//        int parent_data;
//        int add_data = MaxHeapList.Count - 1; //값 삽입
//        while (compare_up(add_data)) //자식 노드 값 <= 부모 노드값 
//        {
//            parent_data = add_data / 2; // 부모 노드값 = 왼쪽 자식노드값 / 2
//            swap(MaxHeapList, add_data, parent_data); //데이터 위치를 바꿈
//            add_data = parent_data;
//        }
//        return true;
//    }

//    public int MaxHeapDelete() //삭제 메소드
//    {
//        if (MaxHeapList.Count == 0) return 0; // 단말노드인 경우 
//        int delete_data = MaxHeapList[1]; //최대값을 가져옴(제일 큰값을 삭제)
//        int index = 1; //인덱스는 1부터 시작
//        int data_left, data_right;
//        while (compare_down(index))
//        {
//            data_left = index * 2; //왼쪽 자식노드
//            data_right = index * 2 + 1; //오른쪽 자식노드

//            if (MaxHeapList.Count <= data_right && MaxHeapList[index] < MaxHeapList[data_left])
//            {
//                swap(MaxHeapList, index, data_left);
//                index = data_left;
//            }
//            else if (data_right < MaxHeapList.Count)
//            {
//                if (MaxHeapList[data_right] > MaxHeapList.Count)
//                {
//                    swap(MaxHeapList, index, data_left);
//                    index = data_left;
//                }
//                else
//                {
//                    swap(MaxHeapList, index, data_right);
//                    index = data_right;
//                }
//            }
//        }
//        return delete_data;
//    }
//}
//class Test
//{
//    static public void Main(string[] args)
//    {
//        MaxHeap mh = new MaxHeap();
//        mh.MaxHeapAdd(10);
//        mh.MaxHeapAdd(40);
//        mh.MaxHeapAdd(30);
//        mh.MaxHeapAdd(5);
//        mh.MaxHeapAdd(12);
//        mh.MaxHeapAdd(6);
//        mh.MaxHeapAdd(15);
//        mh.MaxHeapAdd(9);
//        mh.MaxHeapAdd(60);
//        mh.MaxHeapDelete();

//        for (int i = 0; i < mh.MaxHeapList.Count; i++)
//        {
//            Console.Write(mh.MaxHeapList[i]);
//        }
//    }
//}

