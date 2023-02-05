// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.
Console.Write("Введите кординату x0: ");
int x0 = int.Parse(Console.ReadLine()!);
Console.Write("Введите кординату y0: ");
int y0 = int.Parse(Console.ReadLine()!);
Console.Write("Введите кординату z0: ");
int z0 = int.Parse(Console.ReadLine()!);

Console.Write("Введите кординату x1: ");
int x1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите кординату y1: ");
int y1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите кординату z1: ");
int z1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Длинна заданного вектора ранв {0:f2}", Math.Sqrt(Math.Pow(x1-x0, 2)+Math.Pow(y1-y0, 2)+Math.Pow(z1-z0, 2)));
