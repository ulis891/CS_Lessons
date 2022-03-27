// Задача 36. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

Console.WriteLine();
Console.WriteLine("Сколько элементов будет в массиве?");
int arrLen = Convert.ToInt32(Console.ReadLine());
int[] arr = new int [arrLen];
int len = arr.Length;

void NewMassive(int[] array)
{
    int index =  0;
    while (index < len)
    {
        array[index] = new Random().Next(-99, 100);
        Console.Write(arr[index] + " ");
        index++;
    }
    Console.WriteLine();
}

void SumOddIndexElements (int[] array)
{
    int result = 0;
    for (int i = 1; i < len; i++)
    {
        result += array[i];
        i++;
    }
    Console.WriteLine($"Сумма элементов на стоящих на нечётной позиции равна: {result}");;
}

Console.WriteLine();
NewMassive(arr);
Console.WriteLine();
SumOddIndexElements(arr);
Console.WriteLine();