// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

// double [,] Create2DRandomArray (int rows, int columns, int minValue, int maxValue)
// {
//     double[,] myArray = new double [rows, columns];
//     for (int i=0; i < rows; i++)
//     {
//         for (int j=0; j < columns; j++)
//         {
//             myArray[i,j] = (new Random().Next(minValue, maxValue + 1) + (new Random().NextDouble()));
//         }
//     }
//     return myArray;
// }

// void Show2DArray (double[,] array)
// {
//     for (int i=0; i < array.GetLength(0); i++)
//     {
//         for (int j=0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }


// Console.WriteLine ("Insert array rows number:");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Insert array columns number:");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Insert minimum value:");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Insert maximum value:");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// double[,] myArray = Create2DRandomArray (rows, columns, minValue, maxValue);
// Show2DArray (myArray);

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

// int [,] Create2DRandomArray (int rows, int columns, int minValue, int maxValue)
// {
//     int[,] myArray = new int [rows, columns];
//     for (int i=0; i < rows; i++)
//     {
//         for (int j=0; j < columns; j++)
//         {
//             myArray[i,j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return myArray;
// }

// void Show2DArray (int[,] array)
// {
//     for (int i=0; i < array.GetLength(0); i++)
//     {
//         for (int j=0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int ArrayDigitByIndex(int[,] array, int rindex, int cindex)
// {
//     int n = 0;
//     if ( rindex > array.GetLength(0) -1 | cindex > array.GetLength(1) | rindex < 0 | cindex < 0 )
//     {
//         Console.WriteLine($"Index {rindex}, {cindex} does not exists in the Array");
//     }
//     else
//     {
//         n = array[rindex, cindex];
//     } 
//     return n; 
// }

// Console.WriteLine ("Insert array rows number:");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Insert array columns number:");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Insert minimum value:");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Insert maximum value:");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Insert Row index:");
// int rindex = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Insert Column index:");
// int cindex = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine ();
// int[,] myArray = Create2DRandomArray (rows, columns, minValue, maxValue);
// Show2DArray (myArray);
// Console.WriteLine ();
// int Number = ArrayDigitByIndex(myArray, rindex, cindex);
// Console.WriteLine ($"The number with index {rindex}, {cindex} is-> {Number}");


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// int [,] Create2DRandomArray (int rows, int columns, int minValue, int maxValue)
// {
//     int[,] myArray = new int [rows, columns];
//     for (int i=0; i < rows; i++)
//     {
//         for (int j=0; j < columns; j++)
//         {
//             myArray[i,j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return myArray;
// }

// void Show2DArray (int[,] array)
// {
//     for (int i=0; i < array.GetLength(0); i++)
//     {
//         for (int j=0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void ColumnsAverages (int[,] array)
// {
//     double sum = 0;
//     for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int i = 0; i < array.GetLength(0); i++)
//                 {
//                     sum = (sum + array[i,j])/array.GetLength(1);
//                 }
//                     Console.WriteLine ($"The Column {j+1} average is {sum}");
//                     sum = 0;
//         }
// }

// Console.WriteLine ("Insert array rows number:");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Insert array columns number:");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Insert minimum value:");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Insert maximum value:");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine ();
// int[,] myArray = Create2DRandomArray (rows, columns, minValue, maxValue);
// Show2DArray (myArray);
// Console.WriteLine ();
// ColumnsAverages(myArray);