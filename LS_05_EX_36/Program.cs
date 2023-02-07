
//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

void FillRandomArray(int[] p_array)
{Random vRnd = new Random();
 for (int i = 0; i < p_array.Length; i++)
   {p_array[i] = vRnd.Next(1, 11);}
} 

void WriteArray(int[] p_array)
{for (int i = 0; i < p_array.Length; i++)
   {Console.Write($"{p_array[i]} ");}
 Console.WriteLine();
}

int NotEvenNumberedItemsSum(int[] p_array)
{int v_result = 0;
 for (int i = 1; i < p_array.Length; i+=2)
   {v_result += p_array[i];
   }
  return v_result;
}

Console.Clear();
Console.Write("Введите количество элементов массива: ");
int v_length = int.Parse(Console.ReadLine()!);
int[] v_array = new int[v_length];
FillRandomArray(v_array);
Console.WriteLine("Массив заполненный случайными числами");
WriteArray(v_array);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях равна {NotEvenNumberedItemsSum(v_array)}");