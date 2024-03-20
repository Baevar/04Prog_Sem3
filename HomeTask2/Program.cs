﻿/*Задача 2: Задайте массив на 10 целых чисел.
Напишите программу, которая определяет
количество чётных чисел в массиве.
массив [6 7 19 34 3 1 4 7 9 1] => 3
массив [1 8 43 4 55 60 3 2 1 3] => 4
*/


int[] arr = new int[10] { 10, 7, 15, 3, 56, 47, 36, 3, 90, 10 };

Console.WriteLine("Исходный массив данных:");

foreach (int i in arr)
{
    Console.Write(i + " ");
}

int count = 0;

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] % 2 == 0)
    {
        count++;
    }
}
Console.WriteLine($"\nКоличество четных чисел в заданном массиве={count}");