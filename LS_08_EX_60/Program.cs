// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

void FillRandomArray(int[,,] pArray)
{
    int vValue = 0;
    for (int i = 0; i < pArray.GetLength(0); i++)
    {
        for (int j = 0; j < pArray.GetLength(1); j++)
        {
            for (int k = 0; k < pArray.GetLength(2); k++)
            {
                pArray[i, j, k] = vValue;
                vValue++;
            }

        }

    }

}

void PrintArray(int[,,] pArray)
{
    for (int k = 0; k < pArray.GetLength(2); k++)
    {
        for (int i = 0; i < pArray.GetLength(0); i++)
        {
            for (int j = 0; j < pArray.GetLength(1); j++)
            {
                Console.Write($"{pArray[i, j, k]}({i},{j},{k}))\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}

int vI = 3;
int vJ = 2;
int vK = 4;
int[,,] vArray = new int[vI, vJ, vK];

Console.Clear();
if (vArray.GetLength(0) * vArray.GetLength(1) * vArray.GetLength(2) > 90)
{
    Console.WriteLine("Количество элементов массива больше количества целых двухзначных чисел!");
}
else
{
    FillRandomArray(vArray);
    PrintArray(vArray);
}