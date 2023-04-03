// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3


// int [] CreateArray (int size)
// {
//     int[] newArray = new int[size];
//     for (int i=0; i < size; i++)
//     {
//         int e = i+1;
//         Console.WriteLine($"Please insert {e} digit");
//         int n = Convert.ToInt32(Console.ReadLine());
//         newArray[i] = n;
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

// int PosNumbersFinder (int[] array)
// {
//     int count = 0;
//     for (int i=0; i< array.Length; i++)
//     {
//     if (array[i] > 0)
//         {
//             count ++;
//         }
//     }
//     return count;
// }

// Console.WriteLine ("How many digits you wish to input?");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateArray (size);
// ShowArray (myArray);
// int res = PosNumbersFinder (myArray);
// Console.WriteLine ($"You have inserted {res} positive digits");

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


// int [] CreateArray (int size)
// {
//     int[] newArray = new int[size];
//     for (int i=0; i < size; i++)
//     {
//         int e = i+1;
//         Console.WriteLine($"Please insert {e} digit");
//         int n = Convert.ToInt32(Console.ReadLine());
//         newArray[i] = n;
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

// double CrossPointFinderX (int a, int b, int c, int d)
// {
//     int resxc = (c-a)/(b-d);
//     double resxd = (c-a)/(b-d);
//     double resx = resxc + resxd;
//     return (resx);
// }
// double CrossPointFinderY (double resx, int c, int d)
// {
//     double resy = resx * d + c;
//     return (resy);
// }

// Console.WriteLine ("We will find the cross point of two straightlines y = k1 * x + b1, y = k2 * x + b2. Please input b1 number");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Please input k1 number");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Please input b2 number");
// int c = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Please input k2 number");
// int d = Convert.ToInt32(Console.ReadLine());

// double resx = CrossPointFinderX (a, b, c, d);
// Console.WriteLine ($"Crosspoint coordinate X : {resx}");
// double resy = CrossPointFinderY (resx, c, d);
// Console.WriteLine ($"Crosspoint coordinate Y : {resy}");