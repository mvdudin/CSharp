// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Clear();
Console.Write("Введите целое число: ");
int n = int.Parse(Console.ReadLine()!);
int b = Math.Abs(n);
if(b < 100) 
  {Console.WriteLine($"В числе {n} третьей цифры нет");
  }
else
  {int d = 0;
   while (b > 99)
     {d = b % 10;
      b = b / 10;
     }
   Console.WriteLine($"В числе {n} третья цифра {d}");
  }