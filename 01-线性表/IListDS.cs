using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_线性表
{
    interface IListDS<T>
    {
        /// <summary>
        /// 获得链表的长度
        /// </summary>
        /// <returns></returns>
        int GetLength();
        /// <summary>
        /// 清空
        /// </summary>
        void Clear();
        /// <summary>
        /// 是否为空
        /// </summary>
        /// <returns></returns>
        bool IsEmpty();
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="item"></param>
        void Add(T item);
        /// <summary>
        /// 清空
        /// </summary>
        /// <param name="item">数据</param>
        /// <param name="index">索引</param>
        void Insert(T item, int index);
        /// <summary>
        /// 根据索引删除对应元素
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        T Delete(int index);
        /// <summary>
        /// 索引器，其实是一个GetSet方法，根据索引获得对应元素
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        T this[int index] { get; }
        /// <summary>
        /// 根据索引获得对应元素
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        T GetElement(int index);
        /// <summary>
        /// 根据数据得到对应索引
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        int Locate(T value);
    }
}
