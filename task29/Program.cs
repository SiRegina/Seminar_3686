//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Данные вводятся с консоли пользователем


int[] array = new int [8]; 

void EnterArray(int [] array)
{
    for (int i = 0; i<8; i++)
    {
        Console.Write("Введите " + (i+1) + " число: " );
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}
        
EnterArray(array);

Console.WriteLine(string.Join(", ",array));

