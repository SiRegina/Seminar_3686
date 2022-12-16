// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

int [] array = {1,2,3,4,5};
int [] newarray = new int[array.Length];
for (int i = 0; i < newarray.Length; i++)
{
    newarray[i] = array[i];
}

array[2] = 15;

   Console.WriteLine($"[{string.Join(", ", array)}]");
   Console.WriteLine($"[{string.Join(", ", newarray)}]");
