// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да
// Массивы к задачам 32 и 33 можно сделать рандомными. В задаче 33 на экран выводится ТОЛЬКО одно сообщение: либо "да", либо "нет".

int[] GetRandomArray(int length, int leftRange, int rightRange)
{
    int[] array = new int[length]; 
    Random random = new Random();
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(leftRange, rightRange + 1);
    }
    return array;
}

int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

void GetFindArray(int N, int[] array)
{
    bool j = false;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]==N)
        {
            j=true;
        }
    }
    if (j == true)
    {

         Console.WriteLine($"число {N} - присутствует в массиве {string.Join(", ", array)}");  
        }
    else
        {
            Console.WriteLine($"число {N} - не присутствует в массиве {string.Join(", ", array)}");
        }  
    
}

int N=ReadInt("Введите число: ");
const int LENGTH = 5;
const int LEFTRANGE = -1000;
const int RIGHTRANGE = 1000; 

int[] massive = GetRandomArray(LENGTH, LEFTRANGE, RIGHTRANGE);
GetFindArray(N, massive);



