/* Задача 72: Заданы 2 массива: info и data. В массиве info хранятся двоичные представления нескольких чисел (без разделителя).
В массиве data хранится информация о количестве бит, которые занимают числа из массива info.
Напишите программу, которая составит массив десятичных представлений чисел массива data с учётом информации из массива info.

Пример:
входные данные:

data = {0, 1, 1, 1, 1, 0, 0, 0, 1 }
info = {2, 3, 3, 1 }

выходные данные:1, 7, 0, 1

Комментарий:
первое число занимает 2 бита (01 -> 1);
второе число занимает 3 бита (111 -> 7);
третье число занимает 3 бита (000 -> 0;
четвёртое число занимает 1 бит (1 -> 1)*/


int[] data = { 0, 1, 1, 1, 1, 0, 0, 0, 1 };
int[] info = { 2, 3, 3, 1 };
int[] decNumbers = new int[info.Length];

void Separator(int[] num, int[] separator)
{
    int count = 0;

    for (int i = 0; i < separator.Length; i++)
    {
        int[] binNumbers = new int[separator[i]];
        for (int j = 0; j < separator[i]; j++)
        {
            binNumbers[j] = num[count];
            count++;
        }
        decNumbers[i] = Decimal(binNumbers);
    }
}

    int Decimal(int[] binArray)
    {
        double dec = 0;
        for (int i = 0; i < binArray.Length; i++)
        {
            dec += binArray[i] * Math.Pow(2, binArray.Length - i - 1);
        }
        return Convert.ToInt32(dec);
    }

    void PrintArray(int[] matr)
    {
        Console.WriteLine();
        for (int i = 0; i < matr.Length; i++)
        {
            if (matr[i] > 9) { Console.Write($"{matr[i]}  "); }
            else { Console.Write($"{matr[i]}   "); }
        }
        Console.WriteLine();
    }

    Separator(data, info);
    PrintArray(decNumbers);