﻿using System;

namespace Varlables
{
    internal class Program
    {
        // bit : 한자리 이진수(0과1로 표현, 정보 처리의 최소단위)
        // byte : 8bit ( CPU 의 데이터 처리 최소단위)

        // 변수
        int index = 7; //int 는 4 byte 부호가 있는 정수항 자료형
        // index 는 7으로 초기화되었다.
        // index 변수의 메모리공간에3이라는 데이터를 대입
        // 7 = 2 ^ 2 + 2  ^ 1 + 2 ^ 0

        // 함수
        static void Main(string[] args)
        {
            
        }
    }


    public class Human
    {
        int age; 
        float height; // 4 byte 실수형
        double weight; // 8 byte 실수형 
        bool isReseting; // 1 byte 논리형  (ture / false 값을 가짐)
        // ture: 0이 아님 false: 0
        char gender Character // 2 byte 문자형 (ASCLL 코드로 표현)
        // 'a' 97 == 64 + 32 + 1 == 2^6 + 2^5 + 2^0
        string name; // 문자열형, 문자갯수 *2 byte  + 1byte (null)
    }
}
