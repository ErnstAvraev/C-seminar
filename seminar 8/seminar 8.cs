// Задача 53
// Задайте двумерный массивю Напишите программу, которая поменяет первую 
// и последнюю строку массива

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
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Console.Write($"{inArray[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// // int[,] ChangeFirstLineWithLastLine(int[,] notFixedArray, int rows, int columns)
// // {
// //     int[,] fixedArray = new int[rows, columns];
// //     for (int i = 0; i < rows; i++)
// //     {
// //         for (int j = 0; j < columns; j++)
// //         {
// //             if (i == 0)
// //             {
// //                 fixedArray[i, j] = notFixedArray[rows - 1, j];
// //             }
// //             else if (i == rows - 1)
// //             {
// //                 fixedArray[i, j] = notFixedArray[0, j];
// //             }
// //             else
// //             {
// //                 fixedArray[i, j] = notFixedArray[i, j];
// //             }
// //         }
// //     }
// //     return fixedArray;
// // }

// // решение Елены

// void ChangeRows(int[,] inArray)
// {
//     int rowCount = inArray.GetLength(0)-1;
//     for (int i = 0; i < inArray.GetLength(1); i++)
//     {
//         int k = inArray[0,i];
//         inArray[0,i] = inArray[rowCount,i];
//         inArray[rowCount,i] = k;
//     }
// }
// //
// Console.Write("Введите количество строк массива: ");
// int rows = int.Parse(Console.ReadLine()!);

// Console.Write("Введите количество столбцов массива: ");
// int columns = int.Parse(Console.ReadLine()!);

// Console.Write("Введите минимальное значение элементов массива: ");
// int minValue = int.Parse(Console.ReadLine()!);

// Console.Write("Введите максимальное значение элементов массива: ");
// int maxValue = int.Parse(Console.ReadLine()!);

// int[,] array = GetArray(rows, columns, minValue, maxValue);

// PrintArray(array);
// Console.WriteLine();

// // int[,] fixedArray = ChangeFirstLineWithLastLine(array, rows, columns);

// ChangeRows(array); // решение Елены

// PrintArray(array);



// Задача 55
// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
// В случае, если это не возможно, программа должна вывести сообщение для пользователя.

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
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Console.Write($"{inArray[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void ChangeLineAndColumns(int[,] array)
// {
//     int[,] array2 = new int[array.GetLength(0), array.GetLength(1)];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array2[j,i]=array[i,j];
//         }
//     }
//     Console.WriteLine();
//     PrintArray(array2);
// }

// Console.Write("Введите количество строк массива: ");
// int rows = int.Parse(Console.ReadLine()!);

// Console.Write("Введите количество столбцов массива: ");
// int columns = int.Parse(Console.ReadLine()!);

// Console.Write("Введите минимальное значение элементов массива: ");
// int minValue = int.Parse(Console.ReadLine()!);

// Console.Write("Введите максимальное значение элементов массива: ");
// int maxValue = int.Parse(Console.ReadLine()!);

// if(rows==columns)
// {
//     int[,] array = GetArray(rows,columns,minValue,maxValue);
//     PrintArray(array);
//     ChangeLineAndColumns(array);
// }
// else
// {
//     Console.WriteLine("Невозможно выполнить, количество строк не равно количеству столбцов");
// }

// // Задача 57
// // Составить частотный словарь элементов двумерного массива.
// // Частотный словарь содержит информацию о том, сколько раз встречается элемент вводных данных.

// int[,] GetArray(int m, int n)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(1, 10);
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Console.Write($"{inArray[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void Frequency(int[,] array)
// {
//     int[,] arrayCalc = new int[2, 10] { { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }, { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 } };
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             arrayCalc[1, array[i, j]] += 1;
//         }
//     }
//     Console.WriteLine();
//     PrintArray(arrayCalc);
// }

// Console.Write("Введите количество строк массива: ");
// int rows = int.Parse(Console.ReadLine()!);

// Console.Write("Введите количество столбцов массива: ");
// int columns = int.Parse(Console.ReadLine()!);

// int [,] array = GetArray(rows,columns);
// PrintArray(array);
// Frequency(array);


// Задача 59
// Задайте двумерный массив из целлых чисел. 
// Напишите программу, которая удалит строку и столбец, на пересечении которых
// расположен наименьший элемент массива.

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
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Console.Write($"{inArray[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void FindMinValue(int[,] array)
// {
//     int min = array[0, 0];
//     int minIndexRow = 0;
//     int minIndexColumn = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] < min)
//             {
//                 min = array[i, j];
//                 minIndexRow = i;
//                 minIndexColumn = j;
//             }
//         }
//     }
//     Console.WriteLine($"Координаты минимального значения: строка {minIndexRow}, столбец {minIndexColumn}, минимальное значение {min}");

//     int[,] fixedArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
//     for (int i = 0; i < fixedArray.Length; i++)
//     {
//         for (int j = 0; j < fixedArray.Length; i++)
//         {

//         }
//     }

// }


// Console.Write("Введите количество строк массива: ");
// int rows = int.Parse(Console.ReadLine()!);

// Console.Write("Введите количество столбцов массива: ");
// int columns = int.Parse(Console.ReadLine()!);

// Console.Write("Введите минимальное значение элементов массива: ");
// int minValue = int.Parse(Console.ReadLine()!);

// Console.Write("Введите максимальное значение элементов массива: ");
// int maxValue = int.Parse(Console.ReadLine()!);

// int[,] firstArray = GetArray(rows, columns, minValue, maxValue);

// PrintArray(firstArray);

// FindMinValue(firstArray);

// Задача 61
// вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника