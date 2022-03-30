// многомерные массивы

// string[,] table = new string [2,5];
// table[1,2] = "word";
// for (int rows = 0; rows < 2; rows++)
// {
//     for (int colums = 0; colums < 5; colums++)
//     {
//         Console.WriteLine($"-{table[rows, colums]}-");
//     }
// }

// void PrintArray (int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"-{matr[i, j]}- ");
//         }
//         Console.WriteLine();
//     }
// }

// void FillArray (int [,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)  //
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i, j] = new Random().Next(1 , 10);
//         }
//         Console.WriteLine();
//     }
// }

// // async void PrintImage (int[,] image)
// // {
// //     for (int i = 0; i < image.GetLength(0); i++)
// //     {
// //         for (int j = 0; j < image.GetLength(1); j++)
// //         {
// //             if (image[i, j] == 0) Console.Write($" ");
// //             else Console.Write("+")

// //             Console.Write($"-{image[i, j]}- ");
// //         }
// //         Console.WriteLine();
// //     }
// // }

// // void FillImage (int row, int col)
// // {
// //     if (pic[row, col] == 0)
// //     {
// //         pic[row, col] = 1;
// //         FillImage (int row-1, int col);
// //         FillImage (int row, int col-1);
// //         FillImage (int row+1, int col);
// //         FillImage (int row, int col+1);
// //     }
// // }
// int[,] matrix = new int [3,4]; //[строки (GetLenght(0)), столбцы (GetLenght(1))]
// PrintArray(matrix);
// FillArray(matrix);
// PrintArray(matrix);


// double Factorial (int n)
// {
//     if (n==1) return 1;
//     else return n * Factorial(n-1);
// }
 
//  Console.WriteLine(Factorial(3));


double Fibonachi (int x)
{
    if (x == 1 || x == 2) return 1;
    else return Fibonachi(x-1) + Fibonachi(x-2);
}

for (int i = 1; i < 10; i++)
{
    Console.WriteLine($"{i} = {Fibonachi(i)}");
}