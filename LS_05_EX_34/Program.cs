// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

void FillRandomArray(int[] p_array)
{Random vRnd = new Random();
 for (int i = 0; i < p_array.Length; i++)
   {p_array[i] = vRnd.Next(100, 1000);}
} 

void WriteArray(int[] p_array)
{for (int i = 0; i < p_array.Length; i++)
   {Console.Write($"{p_array[i]} ");}
 Console.WriteLine();
}

int EvenNumberedItems(int[] p_array)
{int v_result = 0;
 for (int i = 0; i < p_array.Length; i++)
   {if (p_array[i] % 2 == 0)
      {v_result++;}
   }
  return v_result;
}

Console.Clear();
Console.Write("Введите количество элементов массива: ");
int v_length = int.Parse(Console.ReadLine()!);
int[] v_array = new int[v_length];
FillRandomArray(v_array);
Console.WriteLine("Массив заполненный случайными положительными трёхзначными числами");
WriteArray(v_array);
Console.WriteLine($"В массиве {EvenNumberedItems(v_array)} четных элементов");