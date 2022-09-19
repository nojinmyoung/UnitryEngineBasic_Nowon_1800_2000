﻿using System;

namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 14;
            int b = 6;
            int c = 0;

            // 산술 연산자 
            //더하기,뺴기,곱하기,나누기, 나머지
            //=======================================================================

            // 더하기
            c = a + b;
            Console.WriteLine(c);

            // 뺴기
            c = a - b;
            Console.WriteLine(c);

            // 곱하기
            c = a * b;
            Console.WriteLine(c);

            // 나누기 
            // 정수연사시 몫만 변환, 실수연산시 소수점까지 연산
            c = a / b;
            Console.WriteLine(c);

            //나머지
            // 정수든 실수든 정수 나머지결과 반환
            c = a % b;
            Console.WriteLine(c);

            // 증가 연산자 
            // 증가 연산자, 감소연산자
            //=======================================================================

            //증가 연산자
            ++c; // 전위연사 : 해당 라인에서 연산을 먼저 수행한 후에 명령 실행
            c++; // 후위연산 : 해당 라인에서 연산을 먼저 수행한 후에 연산실행
            c = 0;
            Console.WriteLine(++c);
            Console.WriteLine(c++);
            Console.WriteLine(c);
        }
    }
}
