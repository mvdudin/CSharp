// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
const int k_item = 0;
const int b_item = 1;

void ReadLineParam(double[] p_array, int p_line)
{Console.Write($"Введите коэф k{p_line}: ");
 p_array[k_item] = int.Parse(Console.ReadLine()!);
 Console.Write($"Введите коэф b{p_line}: ");
 p_array[b_item] = int.Parse(Console.ReadLine()!);
} 

bool CheckLines(double[] p_line1, double[] p_line2)
{if(p_line1[k_item] == p_line2[k_item])
 {if(p_line1[b_item] == p_line2[b_item])
  {Console.WriteLine("Заданные прямые совпадают");}
  else
  {Console.WriteLine("Заданные прямые параллельные");}
  return false;    
 }
 return true; 
}

double[] Intersections(double[] p_line1, double[] p_line2)
{ double[] v_result = new double[2];
  v_result[0] = (p_line2[b_item] - p_line1[b_item])/(p_line1[k_item] - p_line2[k_item]);
  v_result[1] = p_line1[k_item]*v_result[0] + p_line1[b_item];
  return v_result;
}

void WritePoint(double[] p_point)
{Console.WriteLine($"Координаты точки пересечения x={p_point[0]:f3},  y={p_point[1]:f3}");
}

double[] v_line1 = new double[2];
double[] v_line2 = new double[2];
Console.Clear();
ReadLineParam(v_line1, 1);
ReadLineParam(v_line2, 2);
if (CheckLines(v_line1, v_line2)) { WritePoint(Intersections(v_line1, v_line2));}

  