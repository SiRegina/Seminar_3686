// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10


int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}


void PrintBinaryViev(int n)
{
    if(n<=0) return;
    PrintBinaryViev(n/2);
    Console.Write(n%2);
}


int number=ReadInt("Введите число: ");

PrintBinaryViev(number);