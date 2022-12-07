// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите координаты точки по Х для первого числа");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты точки по У для первого числа");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты точки по Z для первого числа");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты точки по Х для второго числа");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты точки по У для второго числа");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты точки по Z для второго числа");
int z2 = Convert.ToInt32(Console.ReadLine());




double res1 = Math.Pow (x2-x1, 2);
double res2 = Math.Pow (y2-y1, 2);
double res3 = Math.Pow (z2-z1, 2);

double resSqrt = Math.Sqrt (res1+res2+res3);

Console.WriteLine ($"{resSqrt:f2}");