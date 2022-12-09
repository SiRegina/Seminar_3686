// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

// Считывает целое число от пользователя
int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}


int GetProizvToNumber(int number)
{
    int proizv = 1;
    for(int i=1; i <= number; i++)
    {
        proizv *=i;
    }
    return proizv;
}

int N=ReadInt("Введите число: ");


int result = GetProizvToNumber(N);
Console.WriteLine ($"Произведение чисел от 1 до {N} = {result}");
