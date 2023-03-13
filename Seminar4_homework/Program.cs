// Урок 4. Функции
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

// int Exp (int a, int b)
// {
//     int count = 1;
//     int exp = a;
//     while(count <b)
//     {
//         exp = a * exp;
//         count++;
//     }
//     return exp;
// }

// bool CheckB (int b)
// {
//     if ( b <= 0 )     
//     {
//         Console.WriteLine($"ERROR: Number B cannot have zero or negative value. Please try again."); 
//         return false;
//     }
//     return true;
// }

// Console.WriteLine ("Insert number A:");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Insert number B:");
// int b = Convert.ToInt32(Console.ReadLine());

// if (CheckB(b))
// {
//     Console.WriteLine($"Number {a} in power {b} is {Exp (a,b)}");
// }


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

// void DigitsSum (int rn)
// {
//     int sum = 0;
//     int current = Math.Abs(rn);
//     while (current > 0 )
//     {     
//         int rem = current % 10;
//         sum = sum + rem ;
//         current = current / 10;
//     }
//     Console.WriteLine($"Digits sum of {rn} number is {sum}");
// }
// Console.WriteLine("Please insert the number");
// int rn = Convert.ToInt32(Console.ReadLine());
// // int rn = 9012;
// DigitsSum(rn);


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

// int [] CreateRandomArray (int size, int minValue, int maxValue)
// {
//     int [] newArray = new int [size];
//     for (int i=0; i < size; i++)
//     {
//         newArray [i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return newArray;
// }

// void ShowArray (int [] array)
// {
//     Console.Write ("[");
//     for(int i = 0; i < array.Length - 1; i++)
//     {
//         Console.Write($"{array [i]}, ");
//     }
//     Console.Write ($"{array[array.Length-1]}]");
// }

// bool CheckSize (int size)
// {
//     while ( size <= 0 )
//     {
//         Console.WriteLine($"Error: Array size {size} cannot have zero or negative value. Please try again.");
//         return false;
//     }
//     return true;
// }

// Console.WriteLine ("Insert array size:");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Insert minimum value:");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Insert maximum value:");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// if (CheckSize (size))
// {
//     ShowArray (CreateRandomArray (size, minValue, maxValue));
// }