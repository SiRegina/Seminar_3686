// Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8


Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());


int i = number % 10;


if(number>999||number<100)
    {
        Console.WriteLine(number+ " Это не трехзначное число");
    }
    else
    {
        Console.Write("Последняя цифра от " + number + " это " + i);
    }


