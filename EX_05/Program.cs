// Напишите программу, которая принимает на вход два числа и
// проверяет, является ли одно число квадратом другого.

Console.Write("Введите число 1: ");
int digit1 = int.Parse(Console.ReadLine());

Console.Write("Введите число 2: ");
int digit2 = int.Parse(Console.ReadLine());

if(digit1 == Math.Pow(digit2, 2))
{
    Console.WriteLine($"Число 2 - {digit2} является квадратом числа 1 - {digit1}");
}
else
{
    if(digit2 == Math.Pow(digit1, 2))
    {
        Console.WriteLine($"Число 1 - {digit1} является квадратом числа 2 - {digit2}");
    }
    else
    {
        Console.WriteLine($"Числа не являются квадратами друг друга");
    }
}

