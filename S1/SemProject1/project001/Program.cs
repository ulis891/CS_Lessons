// // Задача 1: По двум заданным числам проверять является ли первое квадратом второго

// Console.WriteLine("Введите 1 число ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите 2 число ");
// int number2 = Convert.ToInt32(Console.ReadLine());
// int result = number2 * number2;
// if (result == number1)
// {
//     Console.WriteLine("Число 1 является квадратом числа 2");
// }

// else
// {
//     Console.WriteLine("Число 1 не является квадратом числа 2");
// }


// // Задача 2: По заданному номеру дня недели вывести его название

// string [] days = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресение"};

// Console.Write("Введите номер дня недели: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number > 7 || number < 1)
// {
//     Console.WriteLine("Недопустимое число");
// }
// else
// {
// number = number-1;
// Console.WriteLine(days[number]);
// }


//Задача 2: По заданному номеру дня недели вывести его название (2 вариант)
// int number = Convert.ToInt32(Console.ReadLine());
// switch(number){
//     case 1:
//     {
//         Console.WriteLine("Понедельник");
//         break;
//     }

//      case 2:
//     {
//         Console.WriteLine("Вторник");
//         break;
//     }

//      case 3:
//     {
//         Console.WriteLine("Среда");
//         break;
//     }

//      case 4:
//     {
//         Console.WriteLine("Четверг");
//         break;
//     }

//      case 5:
//     {
//         Console.WriteLine("Пятница");
//         break;
//     }

//      case 6:
//     {
//         Console.WriteLine("Суббота");
//         break;
//     }

//      case 7:
//     {
//         Console.WriteLine("Воскресение");
//         break;
//     }

//     default: 
//     Console.WriteLine("Неверные данные");
//     break;

// }




//Показать числа от -N до N
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int i = number; 
 while (i >= -number)
 {
     Console.Write(i);
    i--;
 }

//Показать числа от -N до N (Разные числа)
// Console.Write("Введите число 1: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число 2: ");
// // int number2 = Convert.ToInt32(Console.ReadLine());
// Console.Write($"выведены числа от {number1} до {number2}");

