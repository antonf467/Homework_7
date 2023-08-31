// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Console.WriteLine("Первую размерность массив");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Вторая размерность массив");
// int colomns = Convert.ToInt32(Console.ReadLine());

// double [,] matrix= new double[rows,colomns]

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
// for (int j = 0; j < matrix.GetLength(1); j++)
// {
// matrix[i,j]= new Random().NextDoble()*10;
// Console.Write(matrix[i,j]+" ");
// }
// Console.WriteLine();
// }




// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// int[,] matrix = new int[6,8];

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i,j] = new Random().Next(0,51);
//         Console.Write(matrix[i,j]+" ");
//     }
//     System.Console.WriteLine();
// }
// System.Console.WriteLine();



// System.Console.WriteLine("Введие номер строки от 0 до 5");
// int rows = Convert.ToInt32(Console.ReadLine());

// if (rows >= 0 && rows < 6)
// {
//     System.Console.WriteLine("Введие номер столбца от 0 до 7");
//     int colomns = Convert.ToInt32(Console.ReadLine());

//     if (colomns >= 0 && colomns < 7)
//     {
//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             for (int j = 0; j < matrix.GetLength(1); j++)
//             {
//                 if (i == rows && j == colomns)
//                 {
//                     Console.Write($"Найденое число {matrix[i,j]}");
//                 }
//             }
//         }
//     }
//     else
//     {
//         System.Console.WriteLine("Такого номера столбца в массиве нет");
//         return;
//     }
// }
// else
// {
//     System.Console.WriteLine("Такого номера строки в массиве нет");
//     return;
// }
// System.Console.WriteLine();

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3

System.Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите количество столбцов");
int colomns = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[rows,colomns];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = new Random().Next(0,10);
        Console.Write(matrix[i,j]+" ");
    }
    System.Console.WriteLine();
}

int sum = 0;
double average = 0;

for (int j = 0; j < matrix.GetLength(1); j++)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sum+=matrix[i,j];
    }
    average = (double)sum / rows;
    System.Console.WriteLine($"Среднее арифметическое столбца {j + 1} равно {average}" );
    sum = 0;
}
