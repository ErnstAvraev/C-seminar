// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// double[,] GetArray(int m, int n, int minValue, int maxValue)
// {
//     double[,] result = new double[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = Math.Round(new Random().NextDouble()+ new Random().Next(minValue,maxValue), 1);
//         }
//     }
//     return result;
// }

// void PrintArray(double[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++) // .GetLength(0) считает строки
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++) // .GetLength(1) считает столбцы
//         {
//             Console.Write($"{inArray[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// Console.Clear();

// Console.Write("Введите количество строк массива: ");
// int rows = int.Parse(Console.ReadLine()!);

// Console.Write("Введите количество столбцов массива: ");
// int columns = int.Parse(Console.ReadLine()!);

// double[,] array = GetArray(rows, columns, 0, 101); 
// PrintArray(array);


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// int[,] GetArray(int m, int n, int minValue, int maxValue)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++) // .GetLength(0) считает строки
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++) // .GetLength(1) считает столбцы
//         {
//             Console.Write($"{inArray[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void ElementInArray(int[,] newArray, int rowsNum, int columnNum)
// {
//     if (rowsNum > newArray.GetLength(0) || columnNum > newArray.GetLength(1))
//     {
//         Console.WriteLine("Элемента с заданными параметрами строки и столбца нет");
//     }
//     else
//     {
//         Console.WriteLine($"Искомый элемент = {newArray[rowsNum, columnNum]}");
//     }
// }

// Console.Write("Введите количество строк массива: ");
// int rows = int.Parse(Console.ReadLine()!);

// Console.Write("Введите количество столбцов массива: ");
// int columns = int.Parse(Console.ReadLine()!);

// int[,] array = GetArray(rows, columns, 0, 10); // 0, 10 - минимальное и максимальное значение чисел(диапазон)
// PrintArray(array);
// Console.WriteLine();

// Console.WriteLine("Введите строку элемента в массиве: ");
// int rowOfElement = int.Parse(Console.ReadLine()!);

// Console.WriteLine("Введите столбец элемента в массиве: ");
// int columnOfElement = int.Parse(Console.ReadLine()!);

// ElementInArray(array, rowOfElement, columnOfElement);


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


// int[,] GetArray(int m, int n, int minValue, int maxValue)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++) // .GetLength(0) считает строки
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++) // .GetLength(1) считает столбцы
//         {
//             Console.Write($"{inArray[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void AverageNumInColumn(int[,] array)
// {
//     int sum = 0;

//     for (int i = 0; i < array.GetLength(1); i++)
//     {
//        for (int j = 0; j < array.GetLength(0); j++)
//        {
//             sum+=array[j,i];
//        }
//     double average = (double)sum/array.GetLength(1);
//     Console.WriteLine($"Среднее арифметическое в столбце {i} равно {average}");
//     sum = 0;
//     }
// }

// Console.Write("Введите количество строк массива: ");
// int rows = int.Parse(Console.ReadLine()!);

// Console.Write("Введите количество столбцов массива: ");
// int columns = int.Parse(Console.ReadLine()!);

// int[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);
// Console.WriteLine();

// AverageNumInColumn(array);