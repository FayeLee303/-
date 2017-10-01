using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_线性表
{
    //实现顺序表
    class SeqList<T>:IListDS<T>
    {
        private T[] data;//用来储存数据
        private int count = 0;

        public SeqList(int size)
        {
            data = new T[size];
            count = 0;
        }

        //如果用户在构造时没有传递size就调用默认构造函数
        //实际上还是调用了SeqList(int size)方法，给他传了一个默认的参数为10
        public SeqList() : this(10)
        {

        }

        //获取链表的长度
        public int GetLength()
        {
            return count;
        }

        public void Clear()
        {
            //之后每次取数据都会显示索引不存在
            count = 0;
        }

        //是否为空
        public bool IsEmpty()
        {
            //看当前count是否等于0
            return count == 0;
        }

        public void Add(T item)
        {
            if (count == data.Length)
            {
                Console.WriteLine("当前顺序表已经存满，不能再存");
            }
            else
            {
                data[count] = item;
                count++;
            }
        }
        //插入
        public void Insert(T item, int index)
        {
            //先判断索引是否有效
            if (index >= 0 && index <= count - 1)
            {
                //把index以及之后的数据都往后移动一位
                //注意要从后往前遍历，否则在移动的时候会把后一位覆盖掉
                for (int i = count - 1; i >= index; i--)
                {
                    data[i + 1] = data[i];
                }
                data[index] = item;
                count++;
            }
            else
            {
                Console.WriteLine("索引不存在");
            }       
        }

        public T Delete(int index)
        {
            //先判断索引是否有效
            if (index >= 0 && index <= count - 1)
            {
                T temp = data[index];
                //把index之后的元素都向前移动一位
                //从前往后遍历
                for (int i = index + 1; i < count; i++)
                {
                    data[i] = data[i + 1];
                }
                count--;
                return temp;
            }
            else
            {
                Console.WriteLine("索引不存在");
                return default(T);
            }
        }

        public T this[int index]
        {
            get { return GetElement(index); }
        }

        public T GetElement(int index)
        {
            //先判断索引是否有效
            if (index >= 0 && index <= count - 1)
            {
                return data[index];
            }
            else
            {
                Console.WriteLine("索引不存在");
                //default方法可以取得一个类型的默认值
                return default(T);
            }
        }

        public int Locate(T value)
        {
            for (int i = 0;i<count;i++) {
                //Equals方法判断是否相等
                if (data[i].Equals(value))
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
