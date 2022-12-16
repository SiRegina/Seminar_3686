// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.


int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}


void GetSumOfTwoSides(int a, int b, int c)
{
    if (a<(b+c) & b<(a+c) & c<(a+b))
    {
        Console.WriteLine ("Да");
    }
    else
    {
        Console.WriteLine ("Нет");      
    }

}

int A=ReadInt("Введите сторону 1: ");
int B=ReadInt("Введите сторону 2: ");
int C=ReadInt("Введите сторону 3: ");


GetSumOfTwoSides(A,B,C);
