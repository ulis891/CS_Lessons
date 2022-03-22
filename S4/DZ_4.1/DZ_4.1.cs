// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine();
Console.WriteLine("Введите число А: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число В: ");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

//Решение через модуль Math
double result = Math.Pow(A, B);
Console.WriteLine($"Число {A} в степени {B} является {result} (Решение через модуль Math)");
Console.WriteLine();

//Решение через цикл
result = 1;
if (B < 0)      //Проверяем какой знак у степени
{
    for (int i = 0; i < Math.Abs(B) ; i++)      //Считает при отрицательной степени
    {
        result *= A;
    }
    result = 1/result;
}
else
{
    for (int i = 0; i < B; i++)     //Считает при положителной степени
    {
        result *= A;
    }
}
Console.WriteLine($"Число {A} в степени {B} является {result} (Решение через цикл)");

Console.WriteLine();