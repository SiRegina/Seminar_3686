// Задача 38: Задайте массив натуральных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

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


int GetDiff(int[] array)
{
    int min = array[0];
    int max = array[0];
    int diff = 0;
    for (int i = 0; i < array.Length; i++)
    { 
        if(array[i]<min)
        {
           min = array[i];
        } 

         if(array[i]>max)
        {
           max = array[i];
        }  
    }
    diff = max-min;
    return diff;
}


const int LENGTH = 5;
const int LEFTRANGE = 1;
const int RIGHTRANGE = 100; 

int[] massive = GetRandomArray(LENGTH, LEFTRANGE, RIGHTRANGE);
int diff = GetDiff (massive);

Console.WriteLine ($"разница между максимальным и минимальным элементов массива [{string.Join(", ", massive)}] -> {diff}");