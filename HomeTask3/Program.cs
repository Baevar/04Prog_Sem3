/*Задача 3: Задайте массив из вещественных чисел с
ненулевой дробной частью. Найдите разницу между
максимальным и минимальным элементов массива. 
массив [2.2 0.4 9.11 7.2 78.98] => 78.58
массив [1.22 4.5 3.33] => 3.28*/


double[] arr = new double[10] { 11.2, 12.4, -7.2, 1.4, 5.5, 8.1, 19.2, 7.7, 0.1, 9};

Console.WriteLine("Исходный массив данных");

foreach (double i in arr)
{
    Console.Write(i + " ");
}

double max = arr[0], min = arr[0];

for(int i=1; i < arr.Length; i++)
{
if(arr[i] > max) {max = arr[i];}

if(arr[i] < min) {min = arr[i];}
}
double diff = max - min;

Console.WriteLine($"\nРазница между максимальным и минимальным элементами массива={diff}");
Console.ReadKey();