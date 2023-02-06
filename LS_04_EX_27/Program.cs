// Напишите функцию и запустите ее, которая принимает на вход число и выдаёт сумму цифр в числе.
double DigitSum(int p_number)
{double v_result = 0;
 while ( p_number > 0)
 { v_result += p_number%10;
   p_number /= 10; 
 }
return v_result;
}
Console.Clear();
Console.WriteLine(DigitSum(9012));