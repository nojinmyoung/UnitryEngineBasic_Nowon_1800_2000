﻿using System;
using System.Runtime.InteropServices;

namespace Exemple02_Aray2D
{
    internal class Program
    {
        //                     [행갯수, 열갯수]
        static int[,] map = new int[5, 5]
        {
            { 0, 0, 0, 0, 1 },
            { 0, 1, 1, 1, 1 },
            { 0, 0, 0, 1, 1 },
            { 1, 1, 0, 0, 0,},
            { 0, 1, 1, 0, 0,}
        };
        static void Main(string[] args)
        {
            Player player = new Player(3, 0);
            map[0, 3] = 2;
            
            while (true)
            {
                string input = Console.ReadLine();

                switch (input)
                {
                    case "MoveLeft":
                        player.MoveLeft(map);
                        break;
                    case "MoveRight":
                        player.MoveRight(map);
                        break;
                    case "MoveDown":
                        player.MoveDown(map);
                        break;
                    case "MoveUp":
                        player.MoveUp(map);
                        break;
                    default:
                        Console.WriteLine("Wrong input");
                        break;
                }

                DisPlayeMap();
            }
        }

        static void DisPlayeMap()
        {
            for (int j = 0; j < map.GetLength(0); j++)
            {
                for (int i = 0; i < map.GetLength(1); i++)
                {
                    if (map[j, i] == 0)
                        Console.Write("□");
                    else if (map[j, i] == 1)
                        Console.Write("■");
                    else if (map[j, i] == 2)
                        Console.Write("▣");

                }
                Console.WriteLine();
            }
        }

        class Player
        {
            private int _x;
            private int _y;

            public Player(int x, int y)
            {
                _x = x;
                _y = y;
            }

            public void MoveLeft(int[,] map)
            {
                // 맵 범위를 넘어가는지 체크
                if (_x -1 < 0)
                    Console.WriteLine($"플레이어를 왼쪽으로 이동시킬 수 없습니다, (경계초과) 현재 위치 : {_x}, {_y}" );
                else if (map[_y, _x -1] != 0)
                    Console.WriteLine($"플레이어를 왼쪽으로 이동시킬 수 없습니다, (길이없음) 현재 위치 : {_x}, {_y}" );
                else
                {
                    map[_y, _x--] = 0;
                    map[_y, _x] = 2;
                    Console.WriteLine($"플레이어 왼쪽으로 한칸 이동함, 현재 위치 : {_x}, {_y}");
                }
            }
            public void MoveRight(int[,] map)
            {
                if (_x + 1 < 0)
                    Console.WriteLine($"플레이어를 오른쪽으로 이동시킬 수 없습니다. (경계 초과) 현재위치 : {_x}, {_y}");
                else if (map[_y, _x + 1] != 0)
                    Console.WriteLine($"플레이어를 오른쪽으로 이동시킬 수 없습니다. (길이 없음) 현재위치 : {_x}, {_y}");
                else
                {
                    map[_y, _x++] = 0;
                    map[_y, _x] = 2;
                    Console.WriteLine($"플레이어를 오른쪽으로 한칸 이동함, 현재위치 : {_x}, {_y}");

                }
            }
            public void MoveDown(int[,] map)
            {
                if (_y + 1 < 0)
                    Console.WriteLine($"플레이어를 아래로 이동시킬 수 없습니다. (경계 초과) 현재위치 {_x}, {_y}");
                else if (map[_y + 1, _x] != 0)
                    Console.WriteLine($"플레이어를 아래로 이동시킬 수 없습니다. (길이 없음) 핸재위치 {_x}, {_y}");
                else
                {
                    map[_y++, _x] = 0;
                    map[_y, _x] = 2;
                    Console.WriteLine($"플레이어를 아래로 한칸 이동함. 현재위치 : {_x}, {_y}");
                }
            }
            public void MoveUp(int[,] map)
            {
                if (_y - 1 < 0)
                    Console.WriteLine($"플레이어를 위로 이동시킬 수 없습니다. (경계 초과) 현재위치 {_x}, {_y}");
                else if (map[_y - 1, _x] != 0)
                    Console.WriteLine($"플레이어를 위로 이동시킬 수 없습니다. (길이 없음) 현재위치 {_x}, {_y}");
                else
                {
                    map[_y--, _x] = 0;
                    map[_y, _x] = 2;
                    Console.WriteLine($"플레이어를 위로 한칸 이동함, 현재위치 : {_x}, {_y}");
                }
            }

        }
    }
}
