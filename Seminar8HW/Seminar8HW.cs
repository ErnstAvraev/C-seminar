// // Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // В итоге получается вот такой массив:
// // 7 4 2 1
// // 9 5 3 2
// // 8 4 4 2

// int[,] GetArray(int m, int n, int min, int max)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(min, max + 1);
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

// void BubbleSort(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.Length / 2; j++)
//         {
//             for (int t = j + 1; t < inArray.GetLength(1); t++)
//             {
//                 if (inArray[i, t] > inArray[i, j])
//                 {
//                     int temp = inArray[i, j];
//                     inArray[i, j] = inArray[i, t];
//                     inArray[i, t] = temp;
//                 }
//             }
//         }
//     }
// }

// Console.Write("Введите количество строк массива: ");
// int rows = int.Parse(Console.ReadLine()!);

// Console.Write("Введите количество столбцов массива: ");
// int columns = int.Parse(Console.ReadLine()!);
// int[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);
// BubbleSort(array);
// Console.WriteLine();
// PrintArray(array);

// // Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // 5 2 6 7
// // Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// int[,] GetArray(int m, int n, int min, int max)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(min, max + 1);
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

// void MinSumRowNumber(int[,] array)
// {
//     int row = 0;
//     int minSum = 0;
//     for (int i = 0; i < array.GetLength(1); i++)
//     {
//         minSum += array[0, i];
//     }
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         int sum = 0;
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             sum += array[i, j];
//         }
//         if (minSum > sum)
//         {
//             minSum = sum;
//             row = i;
//         }
//     }
//     Console.WriteLine($"Строка с минимальной суммой - {row}, минимальная сумма = {minSum}");
// }

// Console.Write("Введите количество строк массива: ");
// int rows = int.Parse(Console.ReadLine()!);

// Console.Write("Введите количество столбцов массива: ");
// int columns = int.Parse(Console.ReadLine()!);
// int[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);
// MinSumRowNumber(array);

// // Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// // Например, даны 2 матрицы:
// // 2 4 | 3 4
// // 3 2 | 3 3
// // Результирующая матрица будет:
// // 18 20
// // 15 18

// int[,] GetArray(int m, int n, int min, int max)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(min, max + 1);
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

// int[,] MultiplicationOfMatrix(int[,] matrix1, int[,] matrix2)
// {
//     int[,] resultMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
//     for (int i = 0; i < matrix1.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix2.GetLength(1); j++)
//         {
//             for (int k = 0; k < matrix1.GetLength(1); k++)
//             {
//                 resultMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
//             }
//         }
//     }
//     return resultMatrix;
// }
// Console.Write("Введите количество строк массива 1: ");
// int rows1 = int.Parse(Console.ReadLine()!);

// Console.Write("Введите количество столбцов массива 1: ");
// int columns1 = int.Parse(Console.ReadLine()!);

// Console.Write("Введите количество строк массива 2: ");
// int rows2 = int.Parse(Console.ReadLine()!);

// Console.Write("Введите количество столбцов массива 2: ");
// int columns2 = int.Parse(Console.ReadLine()!);
// if (rows1 != columns2)
// {
//     Console.WriteLine("Нельзя умножить матрицы, введите параметры так, чтобы количество строк(столбцов) первой совпадало с количеством столбцов(строк) второй!");
// }

// int[,] array1 = GetArray(rows1, columns1, 0, 10);
// int[,] array2 = GetArray(rows2, columns2, 0, 10);
// PrintArray(array1);
// Console.WriteLine();
// PrintArray(array2);
// Console.WriteLine();
// PrintArray(MultiplicationOfMatrix(array1, array2));

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// int[,,] GetArray(int[] sizes, int min, int max)
// {
//     int[,,] result = new int[sizes[0], sizes[1], sizes[2]];
//     for (int i = 0; i < result.GetLength(0); i++)
//     {
//         for (int j = 0; j < result.GetLength(1); j++)
//         {
//             int k = 0;
//             while (k < result.GetLength(2))
//             {
//                 int element = new Random().Next(min, max + 1);
//                 if (FindElement(result, element)) continue;
//                 result[i, j, k] = element;
//                 k++;
//             }
//         }
//     }
//     return result;
// }

// bool FindElement(int[,,] array, int el)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 if(array[i,j,k]==el) return true;
//             }
//         }
//     }
//     return false;
// }

// void PrintArray(int[,,]array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 Console.Write($"{array[i,j,k]} ({i},{j},{k})");
//             }
//             Console.WriteLine();
//         }
//         Console.WriteLine();
//     }
// }

// Console.Clear();
// Console.Write("Введите размеры массива через пробел: ");
// string[] nums = Console.ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
// int[,,] array = GetArray(new int[] { int.Parse(nums[0]), int.Parse(nums[1]), int.Parse(nums[2]) }, 10, 99);
// PrintArray(array);


// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// int[,] GetArray(int size)
// {
//     int[,] result = new int[size, size];
//     int i = 0;
//     int j = 0;
//     int rowE = size - 1;
//     int columnE = size - 1;
//     int rowS = 0;
//     int columnS = 0;
//     bool left = true;
//     bool top = true;
//     int count = 0;
//     while (count < size * size)
//     {
//         count++;
//         result[i, j] = count;
//         // going right
//         if (left && top)
//         {
//             if (j == columnE)
//             {
//                 rowS++;
//                 top = true;
//                 left = false;
//                 i++;
//                 continue;
//             }
//             else
//             {
//                 j++;
//                 continue;
//             }
//         }
//         // going down
//         if (!left && top)
//         {
//             if (i == rowE)
//             {
//                 columnE--;
//                 top = false;
//                 left = false;
//                 j--;
//                 continue;
//             }
//             else
//             {
//                 i++;
//                 continue;
//             }
//         }
//         // going left
//         if (!left && !top)
//         {
//             if (j == columnS)
//             {
//                 rowE--;
//                 top = false;
//                 left = true;
//                 i--;
//                 continue;
//             }
//             else
//             {
//                 j--;
//                 continue;
//             }
//         }
//         // going top
//         if (left && !top)
//         {
//             if (i == rowS)
//             {
//                 columnS++;
//                 top = true;
//                 left = true;
//                 j++;
//                 continue;
//             }
//             else
//             {
//                 i--;
//                 continue;
//             }
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// Console.Clear();
// Console.Write("Введите размер матрицы: ");
// int size = int.Parse(Console.ReadLine()!);
// int[,] matrix = GetArray(size);
// PrintArray(matrix);