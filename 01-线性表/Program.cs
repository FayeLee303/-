using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_线性表
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<string> strList = new List<string>();
            //strList.Add("111");//索引是0；
            //strList.Add("222");
            //strList.Add("333");
            //strList.Add("444");
            //Console.Write(strList[0]);
            //strList.Remove("444");
            //Console.Write(strList.Count);
            //Console.Write(strList.Contains("111"));
            //strList.Clear();//清空列表

            SeqList<string> seqList = new SeqList<string>();
            seqList.Add("11");
            seqList.Add("22");
            seqList.Add("33");
            Console.WriteLine(seqList[0]);
            Console.WriteLine(seqList.GetElement(2));
            seqList.Insert("66", 2);
            for (int i = 0;i<seqList.GetLength();i++) {
                Console.WriteLine(seqList[i]);
            }
            Console.ReadKey();
        }
    }
}
