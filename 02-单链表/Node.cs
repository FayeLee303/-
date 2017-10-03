using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_单链表
{
    //节点类
    class Node<T>
    {
        private T data;//储存数据
        private Node<T> next;//指针，用来指向下一个数据的地址

        //默认的构造方法
        public Node()
        {
            data = default(T);
            next = null;
        }
        //只有一个数据
        public Node(T value)
        {
            data = value;
            next = null;
        }
        //正常的构造方法
        public Node(T value,Node<T> next)
        {
            this.data = value;
            this.next = next;
        }
        //只创建了一个指针
        public Node(Node<T> next)
        {
            this.next = next;
        }

        //设置data的属性
        public T Data
        {
            get { return data; }
            set { data = value; }
        }

        //设置next的属性
        public Node<T> Next
        {
            get { return next; }
            set { next = value; }
        }
    }
}
