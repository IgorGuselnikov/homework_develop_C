// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите первое число:");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int secondNumber = Convert.ToInt32(Console.ReadLine());
int min = 0;
int max = 0;

if (firstNumber > secondNumber)
{
    max = firstNumber;
    min = secondNumber;
    Console.WriteLine("Максимальное число из двух:" + firstNumber);
    Console.WriteLine("Минимальное число из двух:" + secondNumber);
}
else if (firstNumber < secondNumber)
{
    max = secondNumber;
    min = firstNumber;
    Console.WriteLine("Максимальное число из двух:" + secondNumber);
    Console.WriteLine("Минимальное число из двух:" + firstNumber);
}
else
{
    Console.WriteLine("Введенные числа равны, необходимо обязательно вводить разные числа!");    
}