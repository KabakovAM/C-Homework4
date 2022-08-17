// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите натуральное число: ");
int number = int.Parse(Console.ReadLine());

int SumDigits(int num)
{
    int res = 0;
    while (num > 0)
    {
        res = res + num % 10;
        num = num / 10;
    }
    return res;
}

int result = SumDigits(number);
Console.Write($"Сумма цифр числа {number} равняется {result}");
