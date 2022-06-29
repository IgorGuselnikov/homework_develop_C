//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите первое число:");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int secondNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число:");
int thirdNumber = Convert.ToInt32(Console.ReadLine());
int max = 0;

if (firstNumber > secondNumber && firstNumber > thirdNumber)
{
    max = firstNumber;
    Console.WriteLine("Максимальное число из трех:" + firstNumber);
}
else if (secondNumber > firstNumber && secondNumber > thirdNumber)
{
    max = secondNumber;
    Console.WriteLine("Максимальное число из трех:" + secondNumber);
}
else
{
    max = thirdNumber;
    Console.WriteLine("Максимальное число из трех:" + thirdNumber);    
}