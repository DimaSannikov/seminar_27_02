﻿// Напишите программу которая выводит случайное число
// из отрезка (10, 99) и показывает наибольшую цифру этого числа

int number = new Random().Next(10, 100);

int firstDigit = number / 10;
int secondDigit = number % 10;

Console.WriteLine(number);
// Console.WriteLine(firstDigit);
// Console.WriteLine(secondDigit);

if(firstDigit > secondDigit)
{
    Console.WriteLine(firstDigit);
}
else
{
    Console.WriteLine(secondDigit);
}