
// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
void Fibonacci (int[] massive)
{
    massive[0] = 0;
    massive[1] = 1;
    for (int i = 2; i < massive.Length; i++)
    {
        massive[i] = massive[i-1]+massive[i-2];
    }
    Console.WriteLine($"[{string.Join(", ", massive)}]");
}

int number=ReadInt("Введите число: ");
int [] massive = new int[number];
Fibonacci(massive);