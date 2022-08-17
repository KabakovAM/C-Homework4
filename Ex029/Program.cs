// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void FillArray(int[] array2)
{
    int length2 = array2.Length;
    Random rnd = new Random();
    for (int i = 0; i < length2; i++)
    {
        array2[i] = rnd.Next(1, 100);
    }
}

void PrintArray(int[] array3)
{
    int length3 = array3.Length;
    int i = 0;
    Console.Write("[");
    while (i < length3 - 1)
    {
        Console.Write($"{array3[i]}, ");
        i++;
    }
    Console.Write($"{array3[i]}]");
}

int[] array = new int[8];
FillArray(array);
PrintArray(array);