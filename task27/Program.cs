// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int GetSumOfNumber(int number)
{
    int sum = 0;
    while (number!=0)
    {
        int n =number;  
        n = n % 10;
        sum = sum + n;
        number/=10;
    }
    return sum;
}

int A=ReadInt("Введите число: ");

int result = GetSumOfNumber(A);
Console.WriteLine ($"Сумма цифр в числе {A} = {result}");