using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceCode
{
    public class LinkedList
    {
        public unsafe class Node
        {
            public int Value;
            public char* Ch;
            public Node Next;
        }
        public static int GetLength(Node head)    //获取链表head的长度
        {
            int length;     //长度
            length = 0;
            Node temp = new Node();
            temp = head;
            while (temp.Next != null)
            {
                length++;
                temp = temp.Next;
            }
            return length;
        }
        //第一题
        public static void eachLinkedList()
        {
            Node head = new Node()
            {
                Value = 1,
                Next = new Node()
                {
                    Value = 2,
                    Next = new Node()
                    {
                        Value = 0
                    }
                }
            };
            Node mth = head;
            while (mth.Next != null)
            {
                mth = mth.Next;
                if (mth.Next == null)
                    Console.WriteLine(mth.Value);//打印最后一个元素值
            }
        }
        //第二题删除指定节点
        public static Node DeleteNode(Node head, int index)
        {
            if (index < 1 || index > LinkedList.GetLength(head))
            {
                Console.WriteLine("不存在此位置");

            }
            Node temp = new Node();
            temp.Next = head;
            for (int i = 0; i < index; i++)
            {
                if (i == index - 1)
                {
                    Node deleteNode = temp.Next;
                    if(temp.Next==head)
                    {
                        head = temp.Next.Next;
                    }
                    temp.Next = temp.Next.Next;
                    deleteNode.Next = null;
                    break;
                }
                temp = temp.Next;
            }
            return head;
        }
        //第二题测试案例
        public static void Test()
        {
            Node head = new Node()
            {
                Value = 1,
                Next = new Node()
                {
                    Value = 2,
                    Next = new Node()
                    {
                        Value = 3
                    }
                }
            };
            head = LinkedList.DeleteNode(head, 1);//删除第一个节点
            Console.WriteLine(head.Value);
        }
    }
}
