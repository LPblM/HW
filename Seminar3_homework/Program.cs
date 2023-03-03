// Урок 3. Базовые алгоритмы. Продолжение
// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

// void Palindrome(int rn)
// {
//     int first = rn / 10000;
//     int last = rn % 10;
//     if (first == last)
//     {
//         int second = rn / 1000 % 10;
//         int penultimate = rn / 10 % 10;
//             if (second == penultimate)
//             Console.WriteLine($"Number {rn} is the Palindrome");
//     }
//     else
//     Console.WriteLine($"Number {rn} is NOT a Palindrome");
// }
// int rn = new Random().Next(10000, 100000);
// // int rn = 43534;
// Palindrome(rn);



// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

double FindDistance(double x1, double y1, double x2, double y2)
{
    return Math.Round(Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2)), 2);
}

Console.WriteLine("Input coordinate X of A point: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input coordinate Y of A point: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input coordinate X of B point: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input coordinate Y of B point: ");
double y2 = Convert.ToDouble(Console.ReadLine());

double distance = FindDistance(x1, y1, x2, y2);
Console.WriteLine($"Distance between A and B is {distance}");



// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// void CubTable(int rn)
// {
//     int num = 1;
//     while( rn >= num ) 
//         {
//         int cube = num * num * num;
//         Console.Write(cube + " ");
//         num++; 
//         } 
// }

// Console.WriteLine("Please insert the number");
// int rn = Convert.ToInt32(Console.ReadLine());

// CubTable(rn);