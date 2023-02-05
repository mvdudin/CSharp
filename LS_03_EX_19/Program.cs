// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом
int n = 0;
while (n < 10000 | n > 99999)
  {Console.Clear();
   Console.Write("Введите целое пятизначное число: ");
   n = int.Parse(Console.ReadLine()!);
  };
int x = n;
int d = 10000;
while (x > 10)
  { if (x/d != x%10) 
      {Console.WriteLine($"Число {n} не палиндромом");
       System.Environment.Exit(1);
      }
    else
     {x = (x%d)/10;
      d /= 100;
     } 
  } 
Console.WriteLine($"Число {n} палиндромом");