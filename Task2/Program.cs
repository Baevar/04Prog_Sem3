﻿/*Задайте массив из 10 элементов, заполненный числами из
промежутка [-10, 10]. Замените отрицательные элементы на
положительные, а положительные на отрицательные.
Пример
[1 -5 6]
=> [-1 5 -6]*/

int[] arrNum = new int[] { -1, 9, 0, 4, -6, -4, 3, 7, -8, -10 };

Console.WriteLine("Исходный массив данных:");

foreach (int k in arrNum)
{
    Console.Write(k + " ");
}

Console.WriteLine("\nИнверсный массив данных:");

int[] reverse = new int [arrNum.Length];

for (int i = 0; i < arrNum.Length; i++)
{
reverse[i] = arrNum[i] * -1;
Console.Write(reverse[i] + " ");
}


// Решение с семинара

// int [] arr = new int [10] {-5, -3, 2, 4, 5, -2, -7, 8, 10, 2};

// for (int i = 0; i < arr.Length; i++)
// {
//     arr[i] *= -1;
// }

// for (int i = 0; i < arr.Length; i++)
// {
//     Console.Write(arr[i] + " ");    
// }