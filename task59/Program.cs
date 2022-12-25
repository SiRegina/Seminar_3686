// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7


int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GetRandomMatrix(int rows, int columns, int leftRange = 0, int rightRange = 10)
{
    int[,] matr = new int[rows, columns];

    var rand = new Random();
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }

    return matr;
}

int[,] GetNewMatrix(int[,] matr)
{
    int min = matr[0,0];
    int imin = 0;
    int jmin = 0;
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (min>matr[i, j])
            {
                min = matr [i,j];
                imin = i;
                jmin = j;
            }   
        }
    }
    int [,] newArray = new int [matr.GetLength(0)-1, matr.GetLength(1)-1];
    int k1=0;
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        int k2=0;
        if (i== imin)
        {
            continue;
        }
        
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (j== jmin)
            {
            continue;
            }
            newArray [k1,k2] = matr[i,j];
            k2++;
        }
        k1++;
    }

    return newArray;
}


void PrintMatrix(int[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + " ");
        }
    }
}

int rowsCount = ReadInt("Введите число строк");
int columnsCount = ReadInt("Введите число столбцов");
int[,] matrix = GetRandomMatrix(rowsCount, columnsCount);
PrintMatrix(matrix);
System.Console.WriteLine();
int[,] newArray = GetNewMatrix(matrix);
PrintMatrix(newArray);



// void PrintRepeats(int[,] matr)
// {
//     int[] counters = new int[100];

//     for(int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             counters[matr[i, j]]++;
//         }
//     }

//     for(int i = 0; i < counters.Length; i++)
//     {
//         if (counters[i] > 0)
//         {
//             Console.WriteLine($"Элемент {i} повторяется {counters[i]} раз ");
//         }
//     }
// }
// PrintRepeats(matrix);