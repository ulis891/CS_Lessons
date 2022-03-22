// Принимает число А и выводит сумму чисел от 1 до А

// Console.WriteLine("Введите число");
// int A = Convert.ToInt32(Console.ReadLine());
// int B = 0;
// for (int i = 1; i <= A; i++)
// {
//     B += i;
// }
// Console.WriteLine(B);

// // Или

// Console.WriteLine(A*(A+1)/2);

// //Показывает колличество знаков в введённом числе
// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// num = Math.Abs(num);
// string ABCnum = Convert.ToString(num);
// Console.WriteLine(ABCnum.Length);

// //Или

// int n = 0;
// foreach (int i in ABCnum)
// {
//     n += 1;
// }
// Console.WriteLine(n);



// //Напишите цикл, который принимает на вход два числа и возводит 2 число в натуральную степень равную 1 числу

// Console.WriteLine("Введите число А: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число В: ");
// int y = Convert.ToInt32(Console.ReadLine());
// double result = Math.Pow (y, x);
// Console.WriteLine(result);

// //Или

// int z = 1;
// for (int i = 0; i < x; i++)
// {
//     z *= y;
// }
// Console.WriteLine(z);



// //  Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

// Console.WriteLine("Введите число: ");
// int x = Math.Abs(Convert.ToInt32(Console.ReadLine()));
// long resualt = 1;
// for (int i = 1; i <= x; i++)
// {
//     resualt = resualt * i;
// }
// Console.WriteLine(resualt);


//Выводит массив из 8 элементов, заполненный 0 и 1 в случайном порядке

int [] arr = new int [8];
int index = 0;
    
while (index < arr.Length)
{
    arr[index] = new Random().Next(0, 2);
    Console.Write($"{arr[index]} ");
    index++;
}

