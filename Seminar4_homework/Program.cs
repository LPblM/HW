// Урок 4. Функции
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16



// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

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


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

int [] CreateRandomArray (int size, int minValue, int maxValue)
{
    int [] newArray = new int [size];
    for (int i = 0; i < size; i++)
    {
        newArray [i] = new Random().Next(minValue, maxValue + 1);
    }
    return newArray;
}

void ShowArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array [ i ] + " ");
    }
    Console.WriteLine ();
}
Console.WriteLine ("Insert array size:");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Insert minimum value:");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Insert maximum value:");
int maxValue = Convert.ToInt32(Console.ReadLine());

ShowArray (CreateRandomArray (size, minValue, maxValue));