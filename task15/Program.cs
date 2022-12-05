// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


Console.Write("Введите номер дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());


if (number<8 & number>0)
{
    if (number == 6 || number == 7)
    {
        Console.WriteLine($"{number} -> УРА! Сегодня ВЫХОДНОЙ!");
    }
    else
    {
        Console.WriteLine($"{number} -> Увы, сегодня не выходной, придется поработать, поробуете еще?");
    }
}
else
{
   Console.WriteLine("Введите число от 1 до 7");
}