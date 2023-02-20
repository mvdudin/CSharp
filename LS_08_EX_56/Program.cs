// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.


void FillRandomArray(int[,] pArray, int pMinValue, int pMaxValue)
{
    Random objRandom = new Random();

    for (int i = 0; i < pArray.GetLength(0); i++)
    {
        for (int j = 0; j < pArray.GetLength(1); j++)
        {
            pArray[i, j] = objRandom.Next(pMinValue, pMaxValue + 1);

        }
    }
}

void PrintArray(int[,] pArray)
{
    for (int i = 0; i < pArray.GetLength(0); i++)
    {
        for (int j = 0; j < pArray.GetLength(1); j++)
        {
            Console.Write($"{pArray[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int RowSum(int[,] pArray, int pRow)
{
    int vSum = 0;
    for (int i = 0; i < pArray.GetLength(1); i++)
    {
        vSum += pArray[pRow, i];
    }
    return vSum;
}

    Console.Clear();
    int[,] vArray = new int[4, 4];
    FillRandomArray(vArray, 0, 9);
    PrintArray(vArray);
    int vMaxRow = 0;
    int vMaxSum = RowSum(vArray, vMaxRow);
    int vSum;
    for (int vRow = 1; vRow < vArray.GetLength(0); vRow++)
    {  vSum = RowSum(vArray, vRow);
       if (vMaxSum < vSum)
        {vMaxSum = vSum;
        vMaxRow =vRow;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Номер строки с максимльной суммой элементов {vMaxRow}");