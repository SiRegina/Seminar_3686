// Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4


Console.WriteLine("Введите число N: ");

int number = Convert.ToInt32(Console.ReadLine());
int n=1;

for (n = 1; n<= number; n++)
{
    Console.Write ( n*n+", ");
    // Console.WriteLine($"Квадраты чисел от 1 до {number} где {n}^2 {n*n}");
}
Console.WriteLine ("Квадрат чисел от 1 до " + number);
