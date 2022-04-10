// Задача 62: Заполните спирально массив 4 на 4(массив заполняется по часовой стрелке от периферии к центру).


Console.WriteLine();
Console.WriteLine("Сколько строк будет в массиве?");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Сколько столбцов будет в массиве?");
int colums = Convert.ToInt32(Console.ReadLine());
int[,] table = new int[rows, colums];
int num = 1;
int iIndex = 0;
int jIndex = 0;
int saveColumsIndex;
int saveRowIndex;


void Spiral(int[,] matr)
{
    if (num < matr.GetLength(0) * matr.GetLength(1))
    {
        int saveColumsIndex = 0;
        int j = jIndex;
        for (int i = j; i < matr.GetLength(1); i++)
        {
            matr[j, i] = num;
            num++;
            jIndex = i;
        }
        for (int i = matr.GetLength(0) - jIndex; i < matr.GetLength(0); i++)
        {
            matr[i, jIndex] = num;
            num++;
            saveColumsIndex = i;
        }
        jIndex = saveColumsIndex;
        for (int i = jIndex-1; i >= matr.GetLength(1) - jIndex-1; i--)
        {
            matr[jIndex, i] = num;
            num++;
            saveColumsIndex = i;
        }
        jIndex = saveColumsIndex;
        for (int i = jIndex; i > matr.GetLength(1); i--)
        {
            matr[i, jIndex] = num;
            num++;
            saveColumsIndex = i;
        }
        jIndex = saveColumsIndex;
    }
}





// void FillArray(int[,] matr)
// {
//     int num = 1;
//     int saveRowIndex = 0;
//     int saveColumsIndex = 0;

//     for (int i; i < matr.GetLength(1); i++)
//     {
//         matr[i, j] = num;
//         num++;
//         saveRowIndex = i;
//         saveColumsIndex = j;
//     }

// }

// void MoveRight(int[,] matr, int iPosition, int jPosition)
// {
//     for (int i = iPosition; i < matr.GetLength(1); i++)
//     {
//         if (num < matr.GetLength(0) * matr.GetLength(1))
//         {
//             int j = jPosition;
//             matr[j, i] = num;
//             num++;
//             saveRowIndex = i;
//             saveColumsIndex = j;
//         }
//         else
//         {
//             break;
//         }
//         MoveDown(matr, saveRowIndex, saveColumsIndex);
//     }



// }

// void MoveDown(int[,] matr, int iPosition, int JPosition)
// {
//     for (int i = iPosition; i < matr.GetLength(1); i++)
//     {
//         if (num < matr.GetLength(0) * matr.GetLength(1))
//         {
//             int j = jPosition;
//             matr[i, j] = num;
//             num++;
//             saveRowIndex = i;
//             saveColumsIndex = j;
//         }
//         else
//         {
//             break;
//         }
//         // MoveDown(matr, saveRowIndex, saveColumsIndex);
//     }
// }

// // void MoveLeft(int[,] matr, int iPosition, int JPosition)
// // {
// //     for (int i; i < matr.GetLength(1); i++)
// //     {
// //         matr[i, j] = num;
// //         num++;
// //         saveRowIndex = i;
// //         saveColumsIndex = j;
// //     }
// // }

// // // void MoveUp(int[,] matr, int iPosition, int JPosition)
// // {
// //     for (int i; i < matr.GetLength(1); i++)
// //     {
// //         matr[i, j] = num;
// //         num++;
// //         saveRowIndex = i;
// //         saveColumsIndex = j;
// //     }
// // }


// for (int i = 0; i < length; i++)
// {
//     for (int j = 0; j < length; j++)
//     {
//         if (matr[i, j] == 0 & j < matr.GetLength(1))
//         {
//             matr[i, j] = num;
//             num++;
//             jIndex = j;
//         }
//     }
//     for (int j = jIndex; j < length; j++)
//     {

//     }
// }




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

Spiral(table);
Console.WriteLine();
Console.WriteLine("Изначальный массив:");
PrintArray(table);