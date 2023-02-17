// апишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

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

bool IsItemExists(double[,] pArray, int pRow, int pCol)
{
    return pRow < pArray.GetLength(0) && pCol < pArray.GetLength(1) && pRow > -1 && pCol > -1;
}

int vRow = -1;
int vCol = 0;
double[,] vArray = new double[4, 5];

Console.Clear();
FillRandomArray(vArray, 10, 15);
if (IsItemExists(vArray, vRow, vCol))
{
    Console.WriteLine($"Элемент [{vRow},{vCol}] = {vArray[vRow, vCol]:f4}");
}
else
{
    Console.WriteLine($"Элемент [{vRow},{vCol}] не найден ");

}
