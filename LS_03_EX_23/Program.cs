// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
Console.Clear();
Console.Write("Введите целое число N: ");
int n = int.Parse(Console.ReadLine()!);
int i = 1;
Console.WriteLine($"Таблица кубов чисел от 1 до {n}");
while(i <= n)
  { 
   Console.Write(Math.Pow(i, 3));
   if (i<n){Console.Write(", ");}
   i+=1;
  }  
  Console.WriteLine();