// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
int n = 0;
int i = 2;
while (a <= 1)
  {Console.Clear();
   Console.Write("Введите целое число N больше 1: ");
   n = int.Parse(Console.ReadLine()!);
  }
Console.WriteLine($"Список четных чисел от 1 до {n}");
while (i <= n)
  {Console.Write($"{i} ");
   i+=2;
  }
Console.WriteLine();  