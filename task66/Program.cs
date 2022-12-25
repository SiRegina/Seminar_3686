// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30



int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}


int SumNumber (int M,  int N)
{
    if (M>N) return 0;
    return N+SumNumber(M, --N);
}

int M = ReadInt("Введите число M: ");
int N = ReadInt("Введите число N: ");
if (M<N)
{
    System.Console.WriteLine(SumNumber(M,N));
}
