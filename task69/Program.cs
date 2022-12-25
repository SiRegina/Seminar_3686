// Задача 69: Напишите программу, которая на вход принимает два числа A и B, 
//и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8


int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}


int PowNumber (int A, int B)
{
    if (B==0)
    {
        return 1;
    }
    return A*PowNumber(A,B-1);
    
}

int A = ReadInt("Введите число A: ");
int B = ReadInt("Введите число B: ");
System.Console.WriteLine(PowNumber(A,B));