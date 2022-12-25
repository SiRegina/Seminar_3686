// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

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

int N = ReadInt("Введите число: ");
PrintNumber(N,1);

