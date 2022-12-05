// Задача 16: Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.Write("Введите первое число: ");
double numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
double numberB = Convert.ToInt32(Console.ReadLine());

if(numberA==(numberB*numberB)||numberB==(numberA*numberA))
   {
   Console.WriteLine("Одно число является квадратом другого");
   }
else
    {
        Console.WriteLine("Одно число не является квадратом другого");
    }