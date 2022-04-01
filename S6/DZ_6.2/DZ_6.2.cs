/* Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем или задаются вручную.*/

Console.ResetColor();
Console.WriteLine();
Console.WriteLine("Для уравнений  y=k1*x+b1  и  y=k2*x+b2  введите следующие значения: ");
Console.WriteLine();
Console.WriteLine("Введите значенине k1");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значенине b1");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значенине k2");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значенине b2");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();
double x;
double y;
if (k1 == k2)
{
    if (b1 == b2)
    {
        Console.WriteLine("Прямые одинаковые");
    }
    else
    {
        Console.WriteLine("Прямые параллельные");
    }
}
else
{
    if (b1 == b2)
    {
        Console.WriteLine($"Точкой пересечения двух прямых является координата ({0} .  {b1})");
    }
    else
    {
        x = (b2-b1)/(k1-k2);
        y = k2 * x + b2;
        Console.WriteLine($"Точкой пересечения двух прямых является координата ({x:f2} .  {y:f2})");        
    }
}
Console.WriteLine();
