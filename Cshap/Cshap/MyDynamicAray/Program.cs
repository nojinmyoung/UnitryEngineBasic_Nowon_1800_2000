using System;
using System.Collections.Generic;

namespace MyDynamicAray
{
    internal class Program
    {
        static void Main(string[] args)
        {
          List<int> list = new List<int>();
            list.Add(1);   
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Remove(1);
            Console.WriteLine(list[0]);

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            foreach (int item in list)
            {
                Console.WriteLine(item);
            }

            IEnumerator<int> eumaerator = list.GetEnumerator();

            while (eumaerator.MoveNext())
            {
                Console.WriteLine(eumaerator.Current);
            }

            MyDynamicAray dynamicAray = new MyDynamicAray();
            dynamicAray.Add(1); 
            dynamicAray.Add(2);
            dynamicAray.Add(3);
            dynamicAray.Add(4);
            dynamicAray.Remove(1);
            Console.WriteLine(dynamicAray[0]);


            for (int i = 0; i < dynamicAray.Count; i++)
            {
                Console.WriteLine(dynamicAray[i]);
            }

           // foreach (int item in dynamicAray)
           // {
           //
           // }
        }
    }
}
