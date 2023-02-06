// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную
//степень B. Реализовать функцию возведения в степень самостоятельно!

double MyPow(int p_a, int p_b) 
{double v_result = 1;
 for (int i=1; i <= p_b; i++)
   {v_result *= p_a;}
 return v_result;
}
Console.Clear();
Console.WriteLine(MyPow(3,2));
