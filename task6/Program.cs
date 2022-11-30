// Задача 6: Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());


int i = number % 2;


if(i == 0)
    {
        Console.WriteLine(number+ " Это четное число");
    }
    else
    {
Console.WriteLine(number+ " Это нечетное число");
    }
