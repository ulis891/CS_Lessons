// Задача 41: Пользователь вводит с клавиатуры или задает самостоятельно M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine();
Console.WriteLine("Сколько чисел будет в проверенно?");
int Len = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[] arr = new int [Len];


void newArray(int Length)
{
    for (int i = 0; i < Length; i++)
    {
        Console.WriteLine($"Введите число №{i+1}: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
    }
}

int PositiveNum (int[] array)
{   
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

void PrintAnswer(int num)
{
    if (num == 0)
    {
        Console.WriteLine($"В массиве нет положительных чисел");
        return;
    }
    if (num % 10 == 1 & num != 11)
    {
        Console.WriteLine($"В массиве {num} положительное число");
        return;
    }
    if (num % 10 >= 2 & num % 10 <= 4 & (num % 100 != 11 & num % 100 != 12 & num % 100 != 13 & num % 100 != 14 ))
    {
        Console.WriteLine($"В массиве {num} положительных числа");
        }
    else
    {
        Console.WriteLine($"В массиве {num} положитлеьных чисел");
    }
}

newArray(Len);
PrintAnswer(PositiveNum(arr));