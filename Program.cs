// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// 1-й способ

// int size = 6;
// int count = 0;

// Console.WriteLine("Введите  числа  массива: ");
// for (int i = 0; i < size; i++)
// {
// int number = Convert.ToInt32(Console.ReadLine());
// if (number > 0) count++;
// }

// Console.WriteLine();
// if (count == 1)
// Console.WriteLine ($"Пользователь ввел {count} положительное число");
// else if (count <=4) 
// {Console.WriteLine ($"Пользователь ввел {count} положительных числа");}
// else {Console.WriteLine ($"Пользователь ввел {count} положительных чисел");}

// *******************************************************************
// 2-й способ - если нужен массив

// int size = 6;
// int count = 0;

// int[] GetArray(int size)
// {
//     int[] res = new int[size];
//     Console.WriteLine("Введите числа массива: ");
//         for (int i = 0; i < size; i++)
//     {
//          res[i] = Convert.ToInt32(Console.ReadLine());
//          if (res[i] > 0) count++;
//     }
//     return res;
// }


// int[] array = GetArray(size);
// PrintArray(array);

// Console.WriteLine();
// if (count == 1)
// Console.WriteLine ($"Пользователь ввел {count} положительное число");
// else if (count <=4) 
// {Console.WriteLine ($"Пользователь ввел {count} положительных числа");}
// else {Console.WriteLine ($"Пользователь ввел {count} положительных чисел");}



// void PrintArray(int[] arr)
// {
//     Console.WriteLine($"Массив: [{String.Join("; ", arr)}]");
// }




// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// int b1, b2, k1, k2;

Console.Write("Введите число b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (b2-b1) / (k1-k2);
double y = k1 * x + b1;

Console.WriteLine();
Console.WriteLine($"Точка пересечения двух прямых при переменных b1 = {k1}, k1 = {k1}, b2 = {b2}, k2 = {k2} => ({x}, {y})");

