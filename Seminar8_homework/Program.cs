// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// double[,] Create2DRandomArray (int rows, int columns, int minValue, int maxValue)
// {
//     double[,] myArray = new double[rows, columns];
//     for(int i = 0; i < rows; i++)
//     {
//         for(int j = 0; j < columns; j++)
//         {
//             myArray[i,j] = new Random().Next(minValue, maxValue + 1) + new Random().NextDouble();
//             myArray[i,j] = Math.Round(myArray[i,j], 2);
//         }
//     }
//     return myArray;
// }

// void Show2DArray (double[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
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

// Console.WriteLine ();
// Show2DArray (Create2DRandomArray (rows, columns, minValue, maxValue));




// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

// int[] RowsSums(int[,] array)
// {
//     int[] array1D = new int[array.GetLength(0)];
//     for(int i = 0; i < array.GetLength(0);i++)
//     {
//         for(int j = 0; j < array.GetLength(1);j++)
//             {
//                 array1D[i] = array1D[i] + array[i,j];
//             }
//                 {

//                     Console.WriteLine($"The sum of the row {i+1} elements is: {array1D[i]}");
//                 }
//     }
//     return array1D;
// }

// void MinRowsSumFinder(int[] array)
// {
//     int minSum = array[0];
//     int minRowNumber = 0;
//     for(int i = 0; i < array.Length; i++)
//     {
//         if(array[i] < minSum)
//         {
//             minSum = array[i];
//             minRowNumber = i;
//         }
//     }
//     Console.WriteLine($"Row with the least sum of elements is -> {minRowNumber + 1}");
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
// int[] array1D = RowsSums(myArray);
// Console.WriteLine ();
// MinRowsSumFinder(array1D);


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// // int[] CheckMatrix (int rows1, int columns1,int rows2, int columns2)
// // {
// //     if (rows1 != rows2 || columns1 != columns2)
// //     {
// //         break;
// //     }
// //         Console.WriteLine("Unable to Multiplicate two these Matrixes");
// // } 

// int[,] Matrix1Array (int rows1, int columns1, int minValue, int maxValue)
// {
//     int[,] Matrix1 = new int[rows1, columns1];
//     for(int i = 0; i < rows1; i++)
//     {
//         for(int j = 0; j < columns1; j++)
//         {
//             Matrix1[i,j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return Matrix1;
// }

// int[,] Matrix2Array (int rows2, int columns2, int minValue, int maxValue)
// {
//     int[,] Matrix2 = new int[rows2, columns2];
//     for(int i = 0; i < rows2; i++)
//     {
//         for(int j = 0; j < columns2; j++)
//         {
//             Matrix2[i,j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return Matrix2;
// }

// int[,] MultiMatrix(int[,] Matrix1, int[,] Matrix2)
// {
//     int[,] resMatrix = new int[Matrix1.GetLength(0), Matrix2.GetLength(1)];
//     // for(int i = 0; i < Matrix1.GetLength(0); i++)
//     // {
//     //     for(int j = 0; j < Matrix2.GetLength(1); j++)
//     //     { 
//     //         if(Matrix1.GetLength(1) != Matrix2.GetLength(0))
//     //         {
//     //             break;
//     //         }
//     //         Console.WriteLine("Unable to Multiplicate two these Matrixes");
//     //     }
//     // }
//     for(int i = 0; i < Matrix1.GetLength(0); i++)
//     {
//         for(int j = 0; j < Matrix2.GetLength(1); j++)
//         {
//             resMatrix[i,j] = 0;
//             for(int k = 0; k < Matrix1.GetLength(1); k++)
//             {
//                 resMatrix[i,j] += Matrix1[i,k] * Matrix2[k,j];
//             }
//         }
//     }
//     return resMatrix;
// }

// void ShowNewMatrix (int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// Console.Write("Insert Matrix1 rows number: ");
// int rows1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Insert Matrix1 columns number: ");
// int columns1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Insert Matrix2 rows number: ");
// int rows2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Insert Matrix2 columns number: ");
// int columns2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Insert minimum value:");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Insert maximum value:");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine();
// int[,] Matrix1 = Matrix1Array(rows1, columns1, minValue, maxValue);
// Console.WriteLine("Matrix1: ");
// ShowNewMatrix(Matrix1);

// Console.WriteLine();
// int[,] Matrix2 = Matrix2Array(rows2, columns2, minValue, maxValue);
// Console.WriteLine("Matrix2: ");
// ShowNewMatrix(Matrix2);

// Console.WriteLine();
// int[,] ResMatrix = MultiMatrix(Matrix1, Matrix2);
// Console.WriteLine("Multiplied Matrix is: ");
// ShowNewMatrix(ResMatrix);

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// int[,,] Create3DRandomArray (int x, int y, int z)
// {
//     int[,,] myArray = new int[x, y, z];
//     for(int i = 0; i < x; i++)
//     {
//         for(int j = 0; j < y; j++)
//         {
//             for(int k = 0; k < z; k++)
//             {
//                 myArray[i, j, k] = new Random().Next(-99,100);
//             }
//         }
//     }
//     return myArray;
// }

// void Show3DArray (int[,,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             for(int k = 0; k < array.GetLength(2); k++)
//             {
//                 Console.Write($"{array[i, j, k]}({i}, {j}, {k}) ");
//             }
//             Console.WriteLine();
//         }
//     }
// }

// Console.Write("Insert lenght of the 3D array: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Insert height of the 3D array: ");
// int y = Convert.ToInt32(Console.ReadLine());
// Console.Write("Insert width of the 3D array: ");
// int z = Convert.ToInt32(Console.ReadLine());

// int[,,] myArray = Create3DRandomArray(x, y, z);
// Console.WriteLine();
// Show3DArray(myArray);

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] FillArraySpiral(int rowP, int colP, int count, int[,] array)
{
        // заполнение периметра
    for (int j = 0; j < colP; j++)
    {
        array[0, j] = count;
        count++;
    }
    for (int i = 1; i < rowP; i++)
    {
        array[i, colP - 1] = count;
        count++;
    }
    for (int j = colP - 2; j >= 0; j--)
    {
        array[rowP - 1, j] = count;
        count++;
    }
    for (int i = rowP - 2; i > 0; i--)
    {
        array[i, 0] = count;
        count++;
    }
        // заполнение массива по спирали
    int row = 1;
    int col = 1;

    while (count < rowP * colP)
    {
        while (array[row, col + 1] == 0)        // >> 6
        {
            array[row, col] = count;
            count++;
            col++;
        }

        while (array[row + 1, col] == 0)        // v 5
        {
            array[row, col] = count;
            count++;
            row++;
        }

        while (array[row, col - 1] == 0)        // << 4
        {
            array[row, col] = count;
            count++;
            col--;
        }

        while (array[row - 1, col] == 0)        // ^ 8
        {
            array[row, col] = count;
            count++;
            row--;
        }
    }
        // Заменяем оставшийся 00 в центре крайним числом из последовтельности
    for (int i = 0; i < rowP; i++)
    {
        for (int j = 0; j < colP; j++)
        {
            if (array[i, j] == 0)
            {
                array[i, j] = count;
            }
        }
    }
    return array;
}

void Show2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10) Console.Write($" 0{array[i, j]}");
            else Console.Write($" {array[i, j]}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


int rowP = 4;
int colP = 4;
int count = 1;

int[,] array = new int[rowP, colP];

array = FillArraySpiral(rowP, colP, count, array);

Show2DArray(array);