﻿/*Задание 4*. Совместная работа
[если позволит тайминг]
Дано натуральное трёхзначное число. Создайте массив, состоящий из
цифр этого числа. Младший разряд числа должен располагаться на 0-
м индексе массива, старший – на 2-м.
Пример
456 => [6 5 4]
781 => [1 8 7]
*/


Console.WriteLine("Введите натуральное трехзначное число");

int num = Convert.ToInt32(Console.ReadLine());

if (num >= 100 && num <= 999)
{
    int[] arrNum = new int[3];

    Console.WriteLine("Результат помещения числа в массив:");

    for (int i = 0; i < arrNum.Length; i++)
    {
        arrNum[i] = num % 10;
        num /= 10;
        Console.Write($"{arrNum[i]} ");
    }

}
else
{
    Console.WriteLine("Ошибка ввода");
}
