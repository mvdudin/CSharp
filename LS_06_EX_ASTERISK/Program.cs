// SНапишите программу, которая реализует обход введенного двумерного массива, 
// начиная с крайнего нижнего левого элемента против часовой стрелки.

//1 2 3
//4 5 6 -> 7 8 9 6 3 2 1 4 5
//7 8 9

int[, ]  v_array = new int[3, 3];
v_array[0,0] = 1; v_array[0,1] = 2; v_array[0,2] = 3;
v_array[1,0] = 4; v_array[1,1] = 5; v_array[1,2] = 6;
v_array[2,0] = 7; v_array[2,1] = 8; v_array[2,2] = 9;

int v_col = 0;
int v_row = v_array.GetLength(0)-1;


for(int ; row > -1; row-- ) 
{for(int col = 0; col < v_array.GetLength(1); col++ ) 
 {Console.Write(v_array[row, col]);}
}