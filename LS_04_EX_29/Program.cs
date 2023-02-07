// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
void ReadArray(int[] p_array)
{for (int i = 0; i < p_array.Length; i++)
   {Console.Clear();
    Console.Write($"Введите значение элемнта массива с номер {i} ");
    p_array[i] = int.Parse(Console.ReadLine()!);
   }
}

void WriteArray(int[] p_array)
{for (int i = 0; i < p_array.Length; i++)
   {Console.Write($"{p_array[i]} ");}
}

int[] v_array = new int[8];
Console.Clear();
ReadArray(v_array);
WriteArray(v_array);
