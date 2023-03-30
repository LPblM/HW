// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// int [] CreateRandomArray (int size)
// {
//     int[] newArray = new int[size];
//     for (int i=0; i < size; i++)
//     {
//         newArray[i] = new Random().Next(99, 1000);
//     }
//     return newArray;
// }

// void ShowArray (int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array [i] + " ");
//     }
//     Console.WriteLine ();
// }

// int EvenNumbersFinder (int[] array)
// {
//     int count = 0;
//     for (int i=0; i< array.Length; i++)
//     {
//     if (array[i] % 2 == 0)
//         {
//             count ++;
//         }
//     }
//     return count;
// }

// Console.WriteLine ("Insert array size:");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray (size);
// ShowArray (myArray);
// int res = EvenNumbersFinder (myArray);
// Console.WriteLine ($"The quantity of even numbers in the Array: {res}");

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

// int [] CreateRandomArray (int size, int minValue, int maxValue)
// {
//     int[] newArray = new int[size];
//     for (int i=0; i < size; i++)
//     {
//         newArray[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return newArray;
// }

// void ShowArray (int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array [i] + " ");
//     }
//     Console.WriteLine ();
// }

// int EvenIndexSum (int[] array)
// {
//     int sum = 0;
//     for (int i=0; i< array.Length; i++)
//     {
//     if (i % 2 != 0)
//         {
//             sum = array[i]+sum;
//         }
//     }
//     return sum;
// }

// Console.WriteLine ("Insert array size:");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Insert minimum value:");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Insert maximum value:");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray (size, minValue, maxValue);
// ShowArray (myArray);
// int res = EvenIndexSum (myArray);
// Console.WriteLine ($"The Sum of odd indexes numbers: {res}");

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

 double [] CreateRandomArray (int size, int minValue, int maxValue)
{
    double[] newArray = new double[size];
    for (int i=0; i < size; i++)
    {
        newArray[i] = (new Random().Next(minValue, maxValue + 1) + (new Random().NextDouble()));
    }
    return newArray;
}

void ShowArray (double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array [i] + " ");
    }
    Console.WriteLine ();
}

double FindMaxMinDifference (double[] array)
{
    double max = array [0];
    double min = array [0];
    int i = 1;
        while (i < array.Length)
            {
                if (max < array[i])
                max = array [i];
                if (min > array[i])
                min = array[i];
                i++;
            }
    return (max - min);
}

Console.WriteLine ("Insert array size:");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Insert minimum value:");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Insert maximum value:");
int maxValue = Convert.ToInt32(Console.ReadLine());

double[] myArray = CreateRandomArray (size, minValue, maxValue);
ShowArray (myArray);
double res = FindMaxMinDifference (myArray);
Console.WriteLine ($"The difference between Max and Min: {res}");