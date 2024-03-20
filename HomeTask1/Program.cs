﻿/*Задача 1: Задайте одномерный массив из 10 целых
чисел от 1 до 100. Найдите количество элементов
массива, значения которых лежат в отрезке [20,90].
Пример: массив [10 21 14 93 23] => 2
*/


int[] arr = new int[10] { 12, 25, 20, 19, 8, 55, 4, 8, 190, 4 };

Console.WriteLine("Исходный массив данных:");

foreach (int i in arr)
{
    Console.Write(i + " ");
}

int count = 0;

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] >= 20 && arr[i] <= 90)
    {
        count++;
    }
}
Console.Write("\nКоличество элементов массива в диапазоне [20;90]=\n" + count);
Console.ReadKey();