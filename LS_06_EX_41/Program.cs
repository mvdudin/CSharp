// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

void ReadArray(int[] p_array)
{
  for (int i = 0; i < p_array.Length; i++)
   {Console.Write($"Введите элемент массива с номером {i}: ");
     p_array[i] = int.Parse(Console.ReadLine()!);
   }
} 

void WriteArray(int[] p_array)
{for (int i = 0; i < p_array.Length; i++)
   {Console.Write($"{p_array[i]} ");}
 Console.WriteLine();
}

int PositiveItems(int[] p_array)
{int v_result = 0;
 for (int i = 0; i < p_array.Length; i++)
   {if (p_array[i] > 0)
      {v_result++;}
   }
 return v_result;
}

Console.Clear();
Console.Write("Введите количество элементов массива: ");
int v_length = int.Parse(Console.ReadLine()!);
int[] v_array = new int[v_length];
ReadArray(v_array);
Console.WriteLine("Ваш массив");
WriteArray(v_array);
Console.WriteLine($"Количество элементов массива больше нуля равно {PositiveItems(v_array)}");