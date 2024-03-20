/*Задайте массив. Напишите программу, которая определяет,
присутствует ли заданное число в массиве. Программа
должна выдать ответ: Да/Нет.
Примеры
[1 3 4 19 3], 8 => Нет
[-4 3 4 1], 3 => Да */

int[] arrNum = new int[]{2,7,11,5,1,14,6,7};

Console.WriteLine("Введите искомое число:");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Исходный массив данных");

int count = 0;
for (int i=0; i< arrNum.Length; i++)
{
    Console.Write(arrNum[i] + " ");
    if (num == arrNum[i])
    {
        count++;
    }
}
if (count > 0)
{
Console.WriteLine("\nЗаданное число ПРИСУТСТВУЕТ в массиве данных");
}
else 
{
Console.WriteLine("\nЗаданное число ОТСУТСТВУЕТ в массиве данных");
}
