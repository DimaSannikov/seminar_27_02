// Напишите программу, которая принимает на вход цифру, обозначающую
// день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите число от 1 до 7: ");
int digit = int.Parse(Console.ReadLine());

if(digit <= 7 & digit >= 1)
{
    switch(digit)
    {
        case 1:
            Console.Write("Понедельник - ");
            break;
        case 2:
            Console.Write("Вторник - ");
            break;
        case 3:
            Console.Write("Среда - ");
            break;
        case 4:
            Console.Write("Четверг - ");
            break;
        case 5:
            Console.Write("Пятница - ");
            break;
        case 6:
            Console.Write("Суббота - ");
            break;
        case 7:
            Console.Write("Воскресенье - ");
            break;
    }
    if(digit >= 6)
    {
        Console.WriteLine("выходной день");
    }
    else
    {
        Console.WriteLine("будний день");
    }
}
else
{
    Console.WriteLine("Введите число в заданном диапазоне");
}
