using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_线性表;

namespace _02_单链表
{
    class LinkList<T>:IListDS<T>

    {
        private Node<T> head;//头节点

        //构造方法
        public LinkList()
        {
            head = null;
        }

        public int GetLength()
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool IsEmpty()
        {
            throw new NotImplementedException();
        }

        public void Add(T item)
        {
            //根据新的数据创建一个新的节点
            Node<T> newNode = new Node<T>(item);
            //如果头节点为空，则新节点就是头节点
            if (head == null)
            {
                head = newNode;
            }
            else
            {                
                //从头节点开始依次遍历直到访问链表的尾节点
                Node<T> temp = head;
                while (true)
                {
                    if (temp.Next != null)
                    {
                        temp = temp.Next;
                    }
                    else
                    {
                        //此时temp里存储的就是尾节点 
                        break;
                    }
                }
                //把新节点放在链表的末尾
                temp.Next = newNode;
            }
        }

        public void Insert(T item, int index)
        {
            throw new NotImplementedException();
        }

        public T Delete(int index)
        {
            throw new NotImplementedException();
        }

        public T this[int index]
        {
            get { throw new NotImplementedException(); }
        }

        public T GetElement(int index)
        {
            throw new NotImplementedException();
        }

        public int Locate(T value)
        {
            throw new NotImplementedException();
        }
    }
}
