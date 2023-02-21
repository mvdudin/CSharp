// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void PrintDownToOne(int pN)
{
    Console.Write(pN);
    if (pN != 1)
    {
        Console.Write(",");
        PrintDownToOne(pN - 1);
    }
    else
    {
        Console.WriteLine();
    }
}

Console.Clear();
PrintDownToOne(8);

