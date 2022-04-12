// Задача 62: Заполните спирально массив 4 на 4(массив заполняется по часовой стрелке от периферии к центру).


Console.WriteLine();
int rows;
Console.WriteLine("Сколько строк и столбцов будет в массиве?");
Console.WriteLine("нажмите Enter для создания массива 4 на 4!");
string input = Console.ReadLine();
if (input == string.Empty)
{
    rows = 4;
}
else
{
    rows = Convert.ToInt32(input);
}

int[,] FillArraySpiral(int n)
{
    int number = 1;
    int[,] array = new int[n, n];
    int count = 0;
    int row; int column;
    while (number <= n * n)
    {
        for (column = count; column < n - count; column++)
        {
            array[count, column] = number++;
        }
        for (row = count + 1; row < n - count; row++)
        {
            array[row, n - count - 1] = number++;
        }
        for (column = n - count - 2; column > count; column--)
        {
            array[n - count - 1, column] = number++;
        }
        for (row = n - count - 1; row > count; row--)
        {
            array[row, count] = number++;
        }
        count++;
    }
    return array;
}

void PrintArray(int[,] matr)
{
    Console.WriteLine();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] > 9) { Console.Write($"{matr[i, j]}  "); }
            else { Console.Write($"{matr[i, j]}   "); }

        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.WriteLine();
PrintArray(FillArraySpiral(rows));