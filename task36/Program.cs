// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


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

int GetSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    { 
        if( i % 2 != 0)
        {
            sum = sum + array[i];
        }  
    }
    return sum;
}


const int LENGTH = 4;
const int LEFTRANGE = 0;
const int RIGHTRANGE = 100; 

int[] massive = GetRandomArray(LENGTH, LEFTRANGE, RIGHTRANGE);
int sum = GetSum (massive);

Console.WriteLine ($" сумму элементов, стоящих на нечётных позициях массива [{string.Join(", ", massive)}] -> {sum}");