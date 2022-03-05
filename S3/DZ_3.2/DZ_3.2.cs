/* Задача 21: Напишите программу, которая принимает на вход координаты двух точек
 и находит расстояние между ними в 3D пространстве.*/

Console.WriteLine("Введите значение X1: ");
int numberX1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение Y1: ");
int numberY1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение Z1: ");
int numberZ1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение X2: ");
int numberX2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение Y2: ");
int numberY2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение Z2: ");
int numberZ2 = Convert.ToInt32(Console.ReadLine());

double result = 
Math.Sqrt((numberX2-numberX1)*(numberX2-numberX1) +
          (numberY2-numberY1)*(numberY2-numberY1) +
          (numberZ2-numberZ1)*(numberZ2-numberZ1));

Console.WriteLine($"Расстояние между точками: {result:f3}");