// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9

int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}


int Akkerman (int m, int n)
{
    if (m==0)
    {
        return n+1;
    }
    
    if (m>0 & n==0)
    {
        return Akkerman(m-1,1);
    }
    
    if (m>0 & n>0)
    {
        return Akkerman (m-1, Akkerman(m,n-1));
    }
    return 0;
}

int m = ReadInt("Введите число m: ");
int n = ReadInt("Введите число n: ");
System.Console.WriteLine(Akkerman(m,n));
