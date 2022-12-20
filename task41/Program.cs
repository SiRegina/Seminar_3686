// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. Ввод чисел останавливается при помощи ввода стоп-слова "stop"
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

int count =0;
while (true)
{
    string? N = Console.ReadLine();
    if (N=="stop")
    {
        break;
    }
    else
    {
        int M = Convert.ToInt32(N);
        if (M>0)
        {
            count++;
        }
    }
}

Console.WriteLine (count);


 

//  string ReadNumb(string messages)
// {
//     Console.Write(messages);
//     return Console.ReadLine();
// }

// int Counter()
//     {
//       string number = ReadNumb("Введите число или stop: ");
//       if(number == "stop") return 0;
//       int count = Counter();
//       if(int.TryParse(number, out int number2) == true && number2 > 0) count++;
//       return count;
//     }
// int res = Counter();
// Console.WriteLine($"Результат:  {res} чисел");