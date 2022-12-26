// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


int[,,] GetMatrix(int x, int y, int z)
{
    int[,,] matr = new int[x, y,z];
    System.Console.WriteLine("Введите массив ");
    for(int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                matr[i, j, k] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }

    return matr;
}

void PrintMatrix(int[,,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                Console.Write($"{matr[i, j, k]} ({i},{j},{k}) ");
            }
        }
    }
}

int[,,] matrix = GetMatrix(2, 2, 2);
PrintMatrix(matrix);


