// Задача 14: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет
// 46 -> нет

Console.Write("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

if(numberA%7 == 0 & numberA%23 ==0)
   {
        Console.WriteLine($"{numberA} делится на 7 и 23");
    }
else
    {
        Console.WriteLine($"{numberA}  не делится одновременно на 7 и 23 ");
    }


    