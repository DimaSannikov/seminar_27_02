// Напишите программу, которая принимает на вход трёхзначное
// число и на выходе показывает вторую цифру этого числа.

Console.Write("Введите трехзначное число: ");
int digit = int.Parse(Console.ReadLine());

if(digit < 1000 & digit > 99)
{
    int firstDigit = digit % 100;
    int secondDigit = firstDigit / 10;

    // Console.WriteLine(digit);
    // Console.WriteLine(firstDigit);
    Console.WriteLine(secondDigit);
}
else
{
    Console.WriteLine("Число не является трехзначным");
}


