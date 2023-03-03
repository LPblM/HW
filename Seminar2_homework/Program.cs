// Урок 2. Базовые алгоритмы
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// int SecondDigit(int num)
// {
//     int hun = num / 10;
//     int ten = hun % 10;
//     return ten;
// }
// int randomnum = new Random().Next(100, 1000);

// int result = SecondDigit(randomnum);
// Console.WriteLine($"The Second digit in {randomnum} number -> {result}");



// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

// int ThirdDigit(int rn)
// {
//     int zero = rn % 1000;
//     if (zero == 0)
//     return 0;
//     else
//     {
//         int digit = rn / 1000;
        
// }

// int rn = new Random().Next();
// {
//     if (rn < 100 && rn < -100) 
//     Console.WriteLine($"There in not third digit in the inserted number {rn}");
// }

// int result = ThirdDigit(rn);
// Console.WriteLine($"The Third digit in {rn} number -> {result}");

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

void Weekend(int day)
{
    if ( day >= 1 && day <= 5 )
    Console.WriteLine("The Day inserted is not a Weekend!");
        if ( day == 6 || day == 7 )
        Console.WriteLine("The Day inserted is a Weekend!");
            // else 
            // Console.WriteLine($"The Day inserted is {day}, but only 7 days in a week! Please insure you submit correct Day number and try another time!");
}
Console.WriteLine("Please insert day number, from 1 to 7");
int day = Convert.ToInt32(Console.ReadLine());

Weekend(day);
// 6 -> да
// 7 -> да
// 1 -> нет

