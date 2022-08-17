// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите натуральное число А: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите натуральное число B: ");
int numberB = int.Parse(Console.ReadLine());

int Squareroot(int A, int B)
{
    int res = 1;
    for (int i = 1; i <= numberB; i++)
    {
        res = res * numberA;
    }
    return res;
}

int result = Squareroot(numberA, numberB);
Console.Write($"{numberA} в степени {numberB} равняется {result}");