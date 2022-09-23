using System;

namespace Statment_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //While(조건)
            //{
            //        조건이 참이때 반복할 내용
            //}

            // 무한 루프 : 끈임 없는 도는 반복문

            int[] arrint = { 23, 42, 12, 21, 37 };

            int count = 0;
            while (count < arrint.Length)
            {
                Console.WriteLine(arrint[count]);
                count++;
            }


            string name = "Luke";
            count = 0;
            while (true)
            {
                Printint(arrint[count] );
                count++;
            }

            do
            {
                Console.WriteLine("Do while test");
            } while (false);


            //for (인덱스변수 초기화; for문 반복조건; 루프 한번 실행후에 수행할 연산)
            for (int i = 0; i < arrint.Length; i++)
            {
                Console.WriteLine(arrint[i]);
            }            
        }

        private static void Printint(int num)
        {
                Console.WriteLine(num);
        }
    }
}
