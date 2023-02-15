// SНапишите программу, которая реализует обход введенного двумерного массива, 
// начиная с крайнего нижнего левого элемента против часовой стрелки.

void PrintArraySpiral(int[,] pArray)
{
    int minRow = 0;
    int maxRow = pArray.GetLength(0) - 1;

    int minCol = 0;
    int maxCol = pArray.GetLength(1) - 1;

    do
    {   //Row right
        for (int col = minCol; col <= maxCol; col++)
        { Console.Write($"{pArray[maxRow, col]}, "); }
        if (maxRow == minRow)
        { break; }
        else
        { maxRow--; }

        //Col up
        for (int row = maxRow; row >= minRow; row--)
        { Console.Write($"{pArray[row, maxCol]}, "); }
        if (maxCol == minCol)
        { break; }
        else
        { maxCol--; }

        // Row left 
        for (int col = maxCol; col >= minCol; col--)
        { Console.Write($"{pArray[minRow, col]}, "); }
        if (maxRow == minRow)
        { break; }
        else
        { minRow++; }

        //Col down
        for (int row = minRow; row <= maxRow; row++)
        { Console.Write($"{pArray[row, minCol]}, "); }
        if (maxCol == minCol)
        { break; }
        else
        { minCol++; }
    } while (true);
    Console.WriteLine();
}

int[,] vArray = new int[3, 3] {{1, 2, 3},{ 4,5,6},{ 7,8,9}};
Console.Clear();
PrintArraySpiral(vArray);

