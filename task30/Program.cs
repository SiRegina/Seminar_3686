﻿// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]


int[] array = new int [8];      //выделили память под 8 элементов

void FillArray(int[] array)
{
    int length=array.Length;
    for(int i=0; i<length; i++)
    {
        array[i]=new Random().Next(0,2);
    }
}

void PrintArray(int[] array)
{
    int length = array.Length;
    for(int i=0; i<length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    }
FillArray(array);
PrintArray(array);
