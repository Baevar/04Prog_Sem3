/*Задача 4**(не обязательно): Дано натуральное
число в диапазоне от 1 до 100 000. Создайте массив,
состоящий из цифр этого числа. Старший разряд
числа должен располагаться на 0-м индексе
массива, младший – на последнем. Размер массива
должен быть равен количеству цифр.
425 => [4 2 5]
8741 => [8 7 4 1]
4 => [4]
*/
Console.WriteLine("Введите число");

int num = Convert.ToInt32(Console.ReadLine());
int numCount = num;

int count = 1;
while (numCount > 9 || numCount <-9)
{
    numCount /= 10;
    count++;
}

int[] arr = new int[count];

int dec = 10;

int j = 0;

while (j < count)
{
    arr[count - j - 1] = (num % dec);
    num /=10;
    j++;
}

Console.WriteLine("Число разложенное по цифрам:");

for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i] + " ");
}
Console.WriteLine();
Console.ReadKey();