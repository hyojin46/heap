//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//public class Node
//{
//    public string data; //루트값의 데이터
//    public Node left; //왼쪽 자식노드
//    public Node right; //오른쪽 자식노드

//    public Node(string data) //생성자
//    {
//        this.data = data;
//    }
//}

//public class BinaryTree //이진트리 클래스
//{
//    public Node root; //이진트리의 루트값
//    public BinaryTree(string data) //생성자
//    {
//        this.root = new Node(data); //루트값 생성
//    }

//    public void PreorderTraversal() //전위순회 (루트->왼쪽노드->오른쪽노드)
//    {
//        this.PreorderTraversalAdd(this.root);
//    }
//    private void PreorderTraversalAdd(Node node) //전위 순회 삽입
//    {
//        if (node == null) return; //만약 노드가 단말노드라면 종료

//        Console.Write(" {0}", node.data); //루트값
//        this.PreorderTraversalAdd(node.left); //왼쪽노드 삽입
//        this.PreorderTraversalAdd(node.right); //오른쪽노드 삽입
//    }

//    public void InorderTraversal() //중위 순회(왼쪽노드->루트->오른쪽노드
//    {
//        this.InorderTraversalAdd(this.root);
//    }
//    private void InorderTraversalAdd(Node node) //중위 순회 삽입
//    {
//        if (node == null) return; //만약 노드가 단말노드라면 종료

//        this.InorderTraversalAdd(node.left); //왼쪽노드 삽입
//        Console.Write(" {0}", node.data); //루트값
//        this.InorderTraversalAdd(node.right); //오른쪽노드 삽입

//    }

//    public void PostorderTraversal() //후위 순회(왼쪽노드->오른쪽노드->루트)
//    {
//        this.PostorderTraversalAdd(this.root);
//    }
//    private void PostorderTraversalAdd(Node node) //후위 순회 삽입
//    {
//        if (node == null) return; //만약 노드가 단말노드라면 종료

//        this.PostorderTraversalAdd(node.left); //왼쪽노드 삽입
//        this.PostorderTraversalAdd(node.right); //오른쪽노드 삽입
//        Console.Write(" {0}", node.data); //루트값
//    }
//}

//class Test //프로그램 테스트 클래스
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("======== 이진 트리 3가지 순회========");

//        BinaryTree tree = new BinaryTree("6");
//        tree.root.left = new Node("4");
//        tree.root.right = new Node("9");
//        tree.root.left.left = new Node("2");
//        tree.root.left.left.left = new Node("1");
//        tree.root.left.left.right = new Node("3");
//        tree.root.left.right = new Node("5");
//        tree.root.right.left = new Node("7");
//        tree.root.right.right = new Node("10");
//        tree.root.right.right.left = new Node("8");
//        tree.root.right.right.right = new Node("11");

//        Console.WriteLine("\n< 전위 순회 >");
//        tree.PreorderTraversal(); //객체를 통한 전위순회 메소드 호출
//        Console.WriteLine("\n");
//        Console.WriteLine("\n< 중위 순회 >");
//        tree.InorderTraversal(); //객체를 통한 중위순회 메소드 호출
//        Console.WriteLine("\n");
//        Console.WriteLine("\n< 후위 순회 >");
//        tree.PostorderTraversal(); //객체를 통한 후위순회 메소드 호출
//        Console.WriteLine("\n");
//        Console.WriteLine("=====================================");
//    }
//}