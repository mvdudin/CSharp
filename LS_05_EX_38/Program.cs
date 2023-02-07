// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива

void FillRandomArray(double[] p_array)
{Random vRnd = new Random();
 for (int i = 0; i < p_array.Length; i++)
   {p_array[i] = vRnd.Next(1, 11);}
} 

void WriteArray(double[] p_array)
{for (int i = 0; i < p_array.Length; i++)
   {Console.Write($"{p_array[i]:f2} ");}
 Console.WriteLine();
}

double MaxMinItemsDiff(double[] p_array)
{int v_min_item_index = 0;
 int v_max_item_index = 0;
 for (int i = 1; i < p_array.Length; i++)
   {if (p_array[i] < p_array[v_min_item_index])
      {v_min_item_index = i;}
    else if (p_array[i] > p_array[v_max_item_index])
      {v_max_item_index = i;}  
   }
  return p_array[v_max_item_index] - p_array[v_min_item_index];
}

Console.Clear();
Console.Write("Введите количество элементов массива: ");
int v_length = int.Parse(Console.ReadLine()!);
double[] v_array = new double[v_length];
FillRandomArray(v_array);
Console.WriteLine("Массив заполненный случайными числами");
WriteArray(v_array);
Console.WriteLine($"разницу между максимальным и минимальным элементов массива равна {MaxMinItemsDiff(v_array):f2}");
