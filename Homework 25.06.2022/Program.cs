﻿//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число:");
int N = Convert.ToInt32(Console.ReadLine());

if (N > 1)
{
    int i = 1;
    while (i <= N)
    {
        if (i%2 != 0)
        {
            i++;
        }
        else
        {
            Console.Write(i + " ");
            i++;
        }
    }

}
else
{
    Console.WriteLine("Введенное число не удовлетворяет условиям");
}
