// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным
int day;
do
  {Console.Clear();
   Console.Write("Введите номер дня недели: ");
    day = int.Parse(Console.ReadLine()!);
  }
while (day < 1 | day > 7);
Console.Write($"День недели с номером {day} ");
if (day > 5)
  {Console.WriteLine("выходной день");}
else  
  {Console.WriteLine("рабочий день");}