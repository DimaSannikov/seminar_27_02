// Напишите программу, которая принимает на вход число
// и проверяет, кратно ли оно одновременно 7 и 23.

Console.Write("Введите число: ");
int digit = int.Parse(Console.ReadLine());

int num7 = digit % 7;
int num23 = digit % 23;

if(num7 == 0 & num23 == 0)
{
    Console.WriteLine($"Число {digit} кратно 7 и 23");
}
else
{
    Console.WriteLine($"Число {digit} не кратно ни 7, ни 23");
}