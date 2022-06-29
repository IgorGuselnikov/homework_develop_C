//int value = Convert.ToInt32(Console.ReadLine());
//int result = value * value;

//Console.WriteLine("Квадрат данного числа равен:" + result);



// Вторая задача

Console.WriteLine("Введите первое целое число: ");
int squareNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(squareNumber == number * number)
{
    Console.WriteLine("Первое число является квадратом второго");
}
else 
{
    Console.WriteLine("Первое число не является квадратом второго");   
}
