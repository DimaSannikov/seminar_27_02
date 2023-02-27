// Напишите программу, которая выводит третью цифру заданного
// числа или сообщает, что третьей цифры нет.

Console.Write("Введите число: ");
int digit = int.Parse(Console.ReadLine());
int num = 0;

if(digit > 99)
{
    while(digit > 99)
    {
        num = digit % 10;
        digit /= 10;
    }
    Console.WriteLine(num);
}
else
{
    Console.WriteLine("Введенное число состоит менее чем из трех цифр");
}