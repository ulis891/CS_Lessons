// Задача 38. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.WriteLine();
Console.WriteLine("Сколько элементов будет в массиве?");
int arrLen = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
double[] arr = new double [arrLen];
int len = arr.Length;

void NewDoubleMassive(double[] array)
{
    int index =  0;
    while (index < len)
    {
        array[index] = new Random().NextDouble() * 10;
        Console.Write($"{arr[index]:f3}" + " ");
        index++;
    }
    Console.WriteLine();
}

void MinMax (double[] array)
{
    int MaxIndex = 0;
    int MinIndex = 0;
    double result;
    for (int i = 1; i < len; i++)
    {
        if (array[i] > array[MaxIndex])
        {
            MaxIndex = i;
        }
        if (array[i] < array[MinIndex])
        {
            MinIndex = i;
        }
    }
    result = array[MaxIndex] - array[MinIndex];
    Console.WriteLine($"Разница между максимальным ({array[MaxIndex]:f3}) и минимальным ({array[MinIndex]:f3}) значением в массиве равняется: {result:f3}");
}

NewDoubleMassive(arr);
Console.WriteLine();
MinMax(arr);
Console.WriteLine();
