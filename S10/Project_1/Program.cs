// Вывесит числа Фибоначи с помощью рекурсии

// int Fibonacci(int a)
// {
//     if (a > 1)
//     {
//         int b = Fibonacci(a - 1) + Fibonacci(a - 2);
//         return b;
//     }
//     else
//     {
//         return a;
//     }
// }

// Console.WriteLine("Введите число:");
// int fibo = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();
// Console.WriteLine(0);
// for (int i = 1; i <= fibo; i++)
// {
//     Console.WriteLine($"{Fibonacci(i)} ");
// }


// Задача про друзей и собаку

// int count = 0;
// int distance = 10000;
// int firstFriendSpeed = 1;
// int secondFriendSpeed = 2;
// int dogSpeed = 5;


// int CountDogWork(int dist)
// {
//     int time;
//     bool friend = true;
//     while (dist > 10)
//     {
//         if (friend)
//         {
//             time = dist / (secondFriendSpeed + dogSpeed);
//             friend = false;
//             count++;
//         }
//         else
//         {
//             time = dist / (firstFriendSpeed + dogSpeed);
//             friend = true;
//             count++;
//         }
//         dist = dist - (firstFriendSpeed + secondFriendSpeed) * time;
//     }
//     return count;
// }

// Console.WriteLine(CountDogWork(distance));


// Задача 65. Задайте значения  M и N. Напишите программу, котрая выведет все натуральные числа в промежутке от M до N.

// Console.WriteLine("Введите число 1:");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число 2:");
// int b = Convert.ToInt32(Console.ReadLine());

// int Numbers(int x, int y)
// {
//     while (x <= y)
//     {
//         Console.Write($"{x} ");
//         return Numbers(x + 1, y);
//     }
//     return 0;
// }

// Numbers(a, b);


// Задача 67.Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

// Console.WriteLine("Введите число :");
// int a = Convert.ToInt32(Console.ReadLine());

// int SumNumbers(int num)
// {
//     int sum = 0;
//     while (num / 10 >= 1)
//     {
//         sum += num % 10;
//         num = num / 10;
//         SumNumbers(num/10);
//     }
//     return sum + num;
// }

// Console.WriteLine(SumNumbers(a));


// Задача 68.Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.


Console.WriteLine("Введите число m:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n:");
int b = Convert.ToInt32(Console.ReadLine());

int AckermannFunction(int m, int n)
{

    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return AckermannFunction(m - 1, 1);

    }
    else
    {
        return AckermannFunction(m - 1, AckermannFunction(m, n - 1));

    }

}

Console.WriteLine(AckermannFunction(a, b));