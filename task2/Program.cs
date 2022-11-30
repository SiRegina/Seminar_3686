// Задача 2: Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7, min = 5
// a = 2 b = 10 -> max = 10, min = 2
// a = -9 b = -3 -> max = -3, min = -9



Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if(numberA>numberB)
{
    Console.WriteLine("max = " + numberA + ", min =" + numberB);
}
else
{
    if(numberA<numberB)
    {
    Console.WriteLine("max = " + numberB + ", min =" + numberA);
    }
    else
    {
    Console.WriteLine("Эти числа равны"); 
    }
}   