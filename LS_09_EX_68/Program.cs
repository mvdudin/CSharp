// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
double Ackermann(double pM, double pN)
{
    if (pM == 0)
    { return pN + 1; }
    else if (pN == 0)
    { return Ackermann(pM - 1, 1); }
    else
    { return Ackermann(pM - 1, Ackermann(pM, pN - 1)); }

}

Console.Clear();
Console.WriteLine(Ackermann(3, 4));
