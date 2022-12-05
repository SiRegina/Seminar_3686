// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1



int number = new Random().Next(100,1000);

int digit1 = number/100;
int digit3 = number % 10;

int rez = (number - digit1*100 - digit3) / 10;    

Console.WriteLine($"Случайное число: {number}");
Console.WriteLine($"Итоговое число: {rez}");
