// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int[] GetRandomArray(int length, int leftRange, int rightRange)
{
    int[] array = new int[length]; 
    Random random = new Random();
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(leftRange, rightRange);
    }
    return array;
}

int GetCount(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    { 
        if(array[i] % 2 == 0 )
        {
            count++;
        }  
    }
    return count;
}


const int LENGTH = 8;
const int LEFTRANGE = 100;
const int RIGHTRANGE = 1000; 

int[] massive = GetRandomArray(LENGTH, LEFTRANGE, RIGHTRANGE);
int count = GetCount (massive);

Console.WriteLine ($" количество чётных чисел в массиве [{string.Join(", ", massive)}] -> {count}");