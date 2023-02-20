// Написать функцию Sqrt(x) - квадратного корня, которая принимает на вход целочисленное значение x и 
// возвращает целую часть квадратного корня от введенного числа

int IntSqrt(int x , int k)
{if (x < k)
    {return 0;}
  else
    { return (1 + IntSqrt(x - k, k + 2));}
}
 

Console.Clear();
Console.WriteLine(IntSqrt(256, 1));