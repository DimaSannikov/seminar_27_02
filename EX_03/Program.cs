// Напишите программу, которая будет принимать на вход два числа
// и выводить, является ли второе число кратным первому. 
// Если число 1 не кратно числу 2, то программа выводит остаток
// от деления.

Console.Write("Введите число 1: ");
int digit1 = int.Parse(Console.ReadLine());

Console.Write("Введите число 2: ");
int digit2 = int.Parse(Console.ReadLine());

int num = digit1 % digit2;

if(num == 0)
{
    Console.WriteLine($"Число кратно {digit2}");
}
else
{
    Console.WriteLine($"Число некратно {digit2}");
    Console.WriteLine($"Остаток от деления {num}");
}
