﻿//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Console.WriteLine("Введите число N");
// int n = Convert.ToInt32(Console.ReadLine());

// for (int i=n; i>=1; i--)
// {
//     Console.Write(i+" ");
// }

//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

// void Summ (int m, int n)
// {
//     Console.Write(SumMN(m - 1, n));
// }

// int SumMN (int m, int n)
// {
//     int sum = m;
//     if (m >= n)
//         return 0;
//     else
//     {
//         m++;
//         sum = m + SumMN(m, n);
//         return sum;
//     }
// }

// Console.WriteLine("Введите число M");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число N");
// int n = Convert.ToInt32(Console.ReadLine());

// Summ(m, n);

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29

int A (int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return A(m - 1, 1);
    else return A(m - 1, A(m, n - 1));
}

Console.WriteLine("Введите число M");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());

int functionAkkerman = A(m, n);
Console.Write($"Функция Аккермана = {functionAkkerman} ");