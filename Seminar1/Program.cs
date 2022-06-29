//int value = Convert.ToInt32(Console.ReadLine());
//int result = value * value;

//Console.WriteLine("Квадрат данного числа равен:" + result);



// Вторая задача

/*Console.WriteLine("Введите первое целое число: ");
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
*/

// Третья задача

Console.WriteLine("введите день недели");
int dayNumber = Convert.ToInt32(Console.ReadLine());

if (dayNumber >= 1 && dayNumber <=7)
{
    if (dayNumber == 1)
    {
        Console.WriteLine("Понедельник");
    }
    if (dayNumber == 2)
    {
        Console.WriteLine("Вторник");
    }
    if (dayNumber == 3)
    {
        Console.WriteLine("Среда");
    }
    if (dayNumber == 4)
    {
        Console.WriteLine("Четверг");
    }
    if (dayNumber == 5)
    {
        Console.WriteLine("Пятница");
    }
    if (dayNumber == 6)
    {
        Console.WriteLine("Суббота");
    }
    if (dayNumber == 7)
    {
        Console.WriteLine("Воскресенье");
    }
}
else
{
    Console.WriteLine("Введено неверное число недели");
}