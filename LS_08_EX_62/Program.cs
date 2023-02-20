// Напишите программу, которая заполнит спирально массив 4 на 4.

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

void FillArraySpiral(int[,] pArray)
{
    int minRow = 0;
    int maxRow = pArray.GetLength(0) - 1;

    int minCol = 0;
    int maxCol = pArray.GetLength(1) - 1;
    int vValue = 1;
    do
    {   //Row right
        for (int col = minCol; col <= maxCol; col++)
        {
            pArray[minRow, col] = vValue; /*Console.Write($"{pArray[minRow, col]}, ");*/
            vValue++;
        }
        if (maxRow == minRow)
        { break; }
        else
        { minRow++; }

        //Col down
        for (int row = minRow; row <= maxRow; row++)
        {
            pArray[row, maxCol] = vValue;/*Console.Write($"{pArray[row, maxCol]}, ");*/
            vValue++;
        }

        if (maxCol == minCol)
        { break; }
        else
        { maxCol--; }

        // Row left 
        for (int col = maxCol; col >= minCol; col--)
        {
            pArray[maxRow, col] = vValue;/*Console.Write($"{pArray[maxRow, col]}, ");*/
            vValue++;
        }
        if (maxRow == minRow)
        { break; }
        else
        { maxRow--; }

        //Col up
        for (int row = maxRow; row >= minRow; row--)
        {
            pArray[row, minCol] = vValue; /*Console.Write($"{pArray[row, minCol]}, ");*/
            vValue++;
        }
        if (maxCol == minCol)
        { break; }
        else
        { minCol++; }
    } while (true);
}

int[,] vArray = new int[5, 7];
Console.Clear();
FillArraySpiral(vArray);
PrintArray(vArray);


