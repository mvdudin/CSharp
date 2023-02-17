// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.


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

double GetColumnAverage(int[,] pArray, int pCol)
{
    if (pCol > -1 && pCol < pArray.GetLength(1))
    {
        double vAverage = 0;
        for (int i = 0; i < pArray.GetLength(0); i++)
        {
            vAverage += pArray[i, pCol];
        }
        return vAverage / pArray.GetLength(0);
    }
    return -1;
}

int[,] vArray = new int[4, 7];
Console.Clear();
FillRandomArray(vArray, 0, 10);
for (int vCol = 0; vCol < vArray.GetLength(1); vCol++)
{
    Console.WriteLine($"Cреднее арифметическое  столбца с номером {vCol+1} = {GetColumnAverage(vArray, vCol):f4}");
}

