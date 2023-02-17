// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

void FillRandomArray(double[,] pArray, double pMinValue, double pMaxValue)
{
    Random objRandom = new Random();
    
    for (int i = 0; i < pArray.GetLength(0); i++)
    {
        for (int j = 0; j < pArray.GetLength(1); j++)
        {
            pArray[i, j] = objRandom.NextDouble() * (pMaxValue - pMinValue) + pMinValue;

        }

    }


}

void PrintArray(double[,] pArray)
{
    for (int i = 0; i < pArray.GetLength(0); i++)
    {
        for (int j = 0; j < pArray.GetLength(1); j++)
        {
            Console.Write($"{pArray[i, j]:f4}\t");

        }
        Console.WriteLine();
    }
}

double [,] vArray = new double[4,5];
Console.Clear();
FillRandomArray(vArray, 10, 15);
PrintArray(vArray);