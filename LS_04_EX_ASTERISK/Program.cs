// Напишите функцию, которая принимает одно число - высоту елочки и рисует ее в консоли звездочками.
void PrintChristmasTree(int p_height)
{Console.Clear();
 for (int r=1;r<=p_height;r++) 
   { for (int c=1; c<=p_height-r; c++)
       {Console.Write(" ");
       }
     for (int a=1; a<=2*r-1; a++)
       {Console.Write("*");}   
     Console.WriteLine();
   }
}
PrintChristmasTree(10);