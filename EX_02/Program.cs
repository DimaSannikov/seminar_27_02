// Напишите программу, которая выводит случайное трехзначное 
// число и удаляет вторую цифру этого числа.

int number = new Random().Next(100, 1000);

int firstDigit = number / 100;
int secondDigit = number % 10;

Console.WriteLine(number);
// Console.WriteLine(firstDigit);
// Console.WriteLine(secondDigit);

int newDigit = firstDigit * 10 + secondDigit;

Console.WriteLine(newDigit);