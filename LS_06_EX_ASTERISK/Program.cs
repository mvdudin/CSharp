// SНапишите программу, которая реализует обход введенного двумерного массива, 
// начиная с крайнего нижнего левого элемента против часовой стрелки.

//1 2 3
//4 5 6 -> 7 8 9 6 3 2 1 4 5
//7 8 9

int[,] array = new int[3, 4];
array[0, 0] = 1; array[0, 1] = 2; array[0, 2] = 3; array[0, 3] = 4;
array[1, 0] = 5; array[1, 1] = 6; array[1, 2] = 7; array[1, 3] = 9;
array[2, 0] = 9; array[2, 1] = 10; array[2, 2] = 11; array[2, 3] = 12;

int minRow = 0;
int maxRow = array.GetLength(0)-1;

int minCol = 0;
int maxCol = array.GetLength(1)-1;

do
{
    for (int col = minCol; col <= maxCol; col++)
    { Console.Write($"[{maxRow},{col}] = {array[maxRow, col]} "); } 
    maxRow--;
    for (int row = maxRow ; row >= minRow; row--)
    { Console.Write($"[{row},{maxCol}]={array[row, maxCol]} "); }
    maxCol--;
    for (int col = maxCol; col >= minCol; col--)
    { Console.Write($"[{minRow},{col}]={array[minRow, col]} "); }
    minRow++;
    for (int row = minRow; row <= maxRow; row++)
    { Console.Write($"[{row}, {minCol}]={array[row, minCol]}, "); }
    minCol++;
}
while (minCol > maxCol || minRow > maxRow);


