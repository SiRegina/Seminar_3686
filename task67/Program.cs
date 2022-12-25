// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9



int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int SumNumber (int N)
{
    if (N==0)
    {
        return 0;
    }

    return N%10+SumNumber(N/10);
}

int N = ReadInt("Введите число: ");
System.Console.WriteLine(SumNumber(N));