/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
 M = 1; N = 15 -> 120 M = 4; N = 8. -> 30*/

Console.WriteLine("Введите число 1:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2:");
int b = Convert.ToInt32(Console.ReadLine());
int sum = 0;

int SumNumbers(int x, int y)
{  
    if (y >= x)
    {
        sum += y;
        SumNumbers(x, y - 1);
    }
    return sum;
}

Console.WriteLine(SumNumbers(a, b));