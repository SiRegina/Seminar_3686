// Задача 35: Задайте одномерный массив из 123 случайных чисел в диапазоне [0, 150]. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

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
        if(array[i] <100 & array[i] > 9 )
        {
            count++;
        }  
    }
    return count;
}




const int LENGTH = 123;
const int LEFTRANGE = 0;
const int RIGHTRANGE = 151; 

int[] massive = GetRandomArray(LENGTH, LEFTRANGE, RIGHTRANGE);
int count = GetCount (massive);

Console.WriteLine ($" количество элементов массива в диапазоне  [10,99] {count}");