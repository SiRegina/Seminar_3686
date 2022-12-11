// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}


int Exponentiates(int number, int pow)
{
    int res=1;
    for (int i = 0; i<pow; i++)
    {
        res=res*number;
    }
    return res;
}

int A=ReadInt("Введите число: ");
int B=ReadInt("Введите степень, в которую будет возводиться число: ");


int result = Exponentiates(A,B);
Console.WriteLine ($"Число {A} в степени {B} = {result}");
