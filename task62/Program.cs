// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] GetMatrix(int x, int y)
{
    int[,] matr = new int[x, y];
    int startI = 0;  //точка начала для i
    int finishI = 0; //точка конца для i
    int startJ = 0;  //точка начала для j
    int finishJ = 0; //точка конца для j
    int k = 1; //счетчик
    int i = 0;
    int j = 0;

    while (k <= x*y)
    {
        matr [i,j] = k;
        
        if (i == startI & j< y-finishJ-1)
        {
            ++j;
        }
        else 
        {
            if (j==y-finishJ-1 & i<x-finishI-1)
            {
                ++i;
            }
            else
            { 
                if (i==x-finishI-1 & j>startJ)
                {
                    --j;
                }
                else 
                {
                    --i;
                }
            }
        }

        if ((i==startI+1) & (j==startJ) & (startJ!= y-finishJ-1))
        {
            ++startI;
            ++finishI;
            ++startJ;
            ++finishJ;
        }
        ++k;
    }

    return matr;
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

int[,] matrix = GetMatrix(4,4);

PrintMatrix(matrix);
