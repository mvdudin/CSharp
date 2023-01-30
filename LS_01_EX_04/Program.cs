// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Clear();
Console.Write("Введите число a: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите число b: ");
int b = int.Parse(Console.ReadLine()!);
Console.Write("Введите число c: ");
int c = int.Parse(Console.ReadLine()!);

if(a >= b)
  {if (a >= c )
     {Console.WriteLine($"Максимально число {a}");}
   else  
     {Console.WriteLine($"Максимально число {c}");}
  }
else
  {if (b >= c) 
     {Console.WriteLine($"Максимально число {b}");}
   else 
     {Console.WriteLine($"Максимально число {c}");}
  }

