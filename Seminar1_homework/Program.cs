﻿// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.WriteLine("Please insert 1st number");
// int a= Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Please insert 2nd number");
// int b= Convert.ToInt32(Console.ReadLine());
// if(a > b)
//     Console.WriteLine($"1st number {a} is greater then 2nd number {b}, -> max = {a}");
// else
//     Console.WriteLine($"2nd number {b} is greater then 1st number {a} or 1st & 2nd numbers are equal, -> max = {b}");


// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.WriteLine("Please insert 1st number");
// int a= Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Please insert 2nd number");
// int b= Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Please insert 2nd number");
// int c= Convert.ToInt32(Console.ReadLine());

// int max = a;
// if (max < b) max = b;
// if (max < c) max = c;
//     Console.WriteLine($"The greatest from three inserted numbers is {max}"); 


// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.WriteLine("Would you like to know if the number is even number? If so, please insert the number");
// int a = Convert.ToInt32(Console.ReadLine());

// int reminder = a % 2;
// if (reminder == 0)
//     Console.WriteLine("Yes. The number inserted is even number!");
// else
//     Console.WriteLine("No. The number inserted is odd number!");


// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// Console.WriteLine("Please insert the Number");
// int n = Convert.ToInt32(Console.ReadLine());

// int num = 1;
// while(n >= num)
// {
//     int rem = num % 2;
//     if (rem == 0)
//     {
//         Console.Write(num + " ");
//         num++; 
//     }
//     else
//         num++;
// }
