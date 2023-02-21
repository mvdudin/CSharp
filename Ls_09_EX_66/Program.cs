// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120

int Sum(int pM, int pN)
{
    if (pM == pN)
    {
        return pN;
    }
    else
    {
        return pM + Sum(pM + 1, pN);
    }
}

Console.Clear();
Console.WriteLine(Sum(1,15));
