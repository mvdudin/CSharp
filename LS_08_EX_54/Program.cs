// Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

void SortRowDesc(int[,] pArray, int pRow)
{
    int vTemp;
    for (int i = 0; i < pArray.GetLength(1)-1; i++)
        for (int j = i + 1; j < pArray.GetLength(1); j++)
        {
            if (pArray[pRow, i] < pArray[pRow, j])
            {
                vTemp = pArray[pRow, i];
                pArray[pRow, i] = pArray[pRow, j];
                pArray[pRow, j] = vTemp;
            }
        }
}

Console.Clear();
int[,] vArray = new int[4, 4];
FillRandomArray(vArray, 0, 9);
PrintArray(vArray);
for (int vRow = 0; vRow < vArray.GetLength(0); vRow++)
{ SortRowDesc(vArray, vRow); }
Console.WriteLine();
PrintArray(vArray);