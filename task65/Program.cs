// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}


void PrintNumber (int N, int i)
{

    if (i>N) return;
    System.Console.Write($"{i}, ");
    i++;
    PrintNumber(N, i);
}

int M = ReadInt("Введите число M: ");
int N = ReadInt("Введите число N: ");
if (M<N)
{
    PrintNumber(N,M);
}

