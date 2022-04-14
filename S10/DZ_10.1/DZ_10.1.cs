/* Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N в обратном порядке. 
M = 1; N = 5. -> «5, 4, 3, 2, 1»*/

Console.WriteLine("Введите число 1:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2:");
int b = Convert.ToInt32(Console.ReadLine());

void Numbers(int x, int y)
{
    if (x <= y)
    {
        Console.Write($"{y} ");
        Numbers(x, y - 1);
    }
}


Numbers(a, b);