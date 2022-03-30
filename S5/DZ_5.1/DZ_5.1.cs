/* Задача 34. Задайте массив заполненный случайными положительными трёхзначными числами.
 Напишите программу, которая покажет количество чётных чисел в массиве*/

Console.WriteLine("Сколько элементов будет в массиве?");
int arrLen = Convert.ToInt32(Console.ReadLine());
int[] arr = new int [arrLen];
int len = arr.Length;

void NewMassive(int[] array)
{
    int index =  0;
    while (index < len)
    {
        array[index] = new Random().Next(100, 1000);
        Console.WriteLine(array[index]);
        index++;
    }
}

void EvenCount (int[] array)
{
    int count = 0;
    foreach (int i in array)
    {
        if (i % 2 == 0)
        {
            count++;
        }
    }
    // Вывод согласно правилам русского языка
    if (count == 0)
    {
        Console.WriteLine($"В массиве нет чётных чисел");
        return;
    }
    if (count % 10 == 1 & count != 11)
    {
        Console.WriteLine($"В массиве {count} чётное число");
        return;
    }
    if (count % 10 >= 2 & count % 10 <= 4 & (count % 100 != 11 & count % 100 != 12 & count % 100 != 13 & count % 100 != 14 ))
    {
        Console.WriteLine($"В массиве {count} чётных числа");
    }
    else
    {
        Console.WriteLine($"В массиве {count} чётных чисел");
    }
}

Console.WriteLine();
NewMassive(arr);
Console.WriteLine();
EvenCount(arr);
Console.WriteLine();