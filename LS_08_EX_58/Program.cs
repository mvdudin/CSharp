// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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


int[,] ArrayProduct(int[,] pMatrix1, int[,] pMatrix2)
{
    int[,] vResult = new int[pMatrix1.GetLength(0), pMatrix2.GetLength(1)];
    for (int i = 0; i < pMatrix1.GetLength(0); i++)
    {
        for (int j = 0; j < pMatrix2.GetLength(1); j++)

        {
            vResult[i, j] = 0;
            for (int k = 0; k < pMatrix1.GetLength(1); k++)
            {
                vResult[i, j] += pMatrix1[i, k] * pMatrix2[k, j];
            }
        }
    }
    return vResult;
}


Console.Clear();
int[,] vMatrix1 = new int[3, 2];
int[,] vMatrix2 = new int[2, 4];
FillRandomArray(vMatrix1, 1, 5);
FillRandomArray(vMatrix2, 1, 5);
Console.WriteLine("Матрица №1");
PrintArray(vMatrix1);
Console.WriteLine("Матрица №2");
PrintArray(vMatrix2);
if (vMatrix1.GetLength(1) == vMatrix2.GetLength(0))
{
    Console.WriteLine("Произведение Матрица №1 * Матрица №2");
    PrintArray(ArrayProduct(vMatrix1, vMatrix2));
}
else
{
    Console.WriteLine("Матрицы не совместимы");
}

