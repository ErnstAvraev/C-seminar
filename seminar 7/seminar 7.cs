// // Решение Елены для семинара 6 домашка задача 41

// Console.Clear();

// Console.Write("Введите числа через пробел: ");
// int[] numbers = GetArrayFromString(Console.ReadLine());
// Console.WriteLine($"Количество чисел больше 0 -> {GetCountPositiveElements(numbers)}");
// Console.WriteLine();

// int[] GetArrayFromString(string stringArray)
// {
//     string[] numS = stringArray.Split(' ', StringSplitOptions.RemoveEmptyEntries);
//     int[] result = new int[numS.Length];
//     for (int i = 0; i < result.Length; i++)
//     {
//         result[i] = int.Parse(numS[i]);
//     }
//     return result;
// }

// int GetCountPositiveElements(int[] array)
// {
//     int count = 0;
//     foreach(var item in array)
//     {
//         if(item>0) count++;
//     }
//     return count;
// }

// // задача 43. Решение Елены

// Console.Clear();
// Console.WriteLine("Введите через пробел b1, k1, b2, k2: ");
// string[] f = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
// double b1 = double.Parse(f[0]);
// double k1 = double.Parse(f[1]);
// double b2 = double.Parse(f[2]);
// double k2 = double.Parse(f[3]);

// Console.WriteLine(String.Join(" ", GetPoint(b1, k1, b2, k2)));

// double[] GetPoint(double inB1, double inK1, double inB2, double inK2)
// {
//     double[] result = new double[2];
//     result[0] = (inB2 - inB1) / (inK1 - inK2);
//     result[1] = inK1 * result[0] + inB1;
//     return result;
// }

// // Еще одно решение через двумерный массив
// // Метод создает и заполняет двумерный массив координатами X и Y двух прямых вида y = kx + b
// // первыя строка принимает значение Х(общая для двух прямых)
// // втораяя строка принимает значение Y первой прямой
// // третья строка принимает значение Y второй прямой
// int[,] FillArray(int size, int k1, int b1, int k2, int b2, int x)
// {
//     int[,] array = new int[3, size];
//     for (int i = 0; i < size; i++)
//     {
//         array[0, i] = x + i;
//         array[1, i] = k1 * (x + i) + b1;
//         array[2, i] = k2 * (x + i) + b2;
//     }
//     return array;
// }
// // метод возвращает значение функции вида y = kx + b, принимая на входе значени координаты х и коэффициентов k и b
// double YOfLine(double x, int k, int b)
// {
//     double y = k * x + b;
//     return y;
// }

// Console.Clear();
// Console.Write("Введите коэффициент k для первой прямой: ");
// int k1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите коэффициент b для первой прямой: ");
// int b1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите коэффициент k для второй прямой: ");
// int k2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите коэффициент b для второй прямой: ");
// int b2 = Convert.ToInt32(Console.ReadLine());

// if (k1 == k2)
// {
//     Console.WriteLine("Прямые параллельны");
// }
// else
// {
//     int minBorder = 0;
//     int maxBorder = 100;

//     double diffMin = YOfLine(minBorder, k1, b1) - YOfLine(minBorder, k2, b2);
//     double diffMax = YOfLine(maxBorder, k1, b1) - YOfLine(maxBorder, k2, b2);

//     while ((diffMax * diffMin) > 0)
//     {
//         if (Math.Abs(diffMax) > Math.Abs(diffMin))
//         {
//             maxBorder = minBorder;
//             minBorder -= 100;
//         }
//         else
//         {
//             minBorder = maxBorder;
//             maxBorder += 100;
//         }
//         diffMin = YOfLine(minBorder, k1, b1) - YOfLine(minBorder, k2, b2);
//         diffMax = YOfLine(maxBorder, k1, b1) - YOfLine(maxBorder, k2, b2);
//     }

//     int[,] newArray = FillArray(maxBorder - minBorder, k1, b1, k2, b2, minBorder);
//     for (int i = 0; i < newArray.GetLength(1); i++)
//     {
//         if (newArray[1, i] == newArray[2, i])
//         {
//             Console.WriteLine($"Координаты точки пересечения: ({newArray[0, i]}, {newArray[1, i]})");
//         }
//     }
//     Console.WriteLine("Проверка координат точки пересечения математическим методом: ");
//     double xCrossPoint = (double)(b2 - b1) / (k1 - k2);
//     Console.WriteLine($"X = {xCrossPoint}, Y = {YOfLine(xCrossPoint, k2, b2)}");
//     Console.WriteLine($"X = {xCrossPoint}, Y = {YOfLine(xCrossPoint,k1,b1)}");
// }


// // Задайте двумерный массив m x n,
// // заполненный случайными целыми числами

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
//             Console.Write($"{inArray[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// Console.Clear();

// Console.Write("Введите количество строк массива: ");
// int rows = int.Parse(Console.ReadLine()!);

// Console.Write("Введите количество столбцов массива: ");
// int columns = int.Parse(Console.ReadLine()!);

// int[,] array = GetArray(rows, columns, 0, 10); // 0, 10 - минимальное и максимальное значение чисел(диапазон)
// PrintArray(array);


// // Задача 48. Задайте двумерный массив m на n,
// // каждый элемент в массиве находится по формуле: Amn = m + n
// // выведите полученный массив на экран

// int[,] GetArray(int m, int n, int minValue, int maxValue)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = i + j;
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

// Console.Clear();

// Console.Write("Введите количество строк массива: ");
// int rows = int.Parse(Console.ReadLine()!);

// Console.Write("Введите количество столбцов массива: ");
// int columns = int.Parse(Console.ReadLine()!);

// int[,] array = GetArray(rows, columns, 0, 10); // 0, 10 - минимальное и максимальное значение чисел(диапазон)
// PrintArray(array);

// // Задача 49: Задайте двумерный массив.
// // Найдите элементы, у которых оба индекса четные,
// // и замените эти элементы на их квадраты

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

// void EvenIndexSquareElement(int[,] array)
// {

//     for (int i = 2; i < array.GetLength(0); i++)
//     {
//         for (int j = 2; j < array.GetLength(1); j++)
//         {
//             if (i % 2 == 0 && j % 2 == 0)
//             {
//                 array[i, j] = array[i, j] * array[i, j];
//             }
//         }
//     }
// }
// Console.Clear();

// Console.Write("Введите количество строк массива: ");
// int rows = int.Parse(Console.ReadLine()!);

// Console.Write("Введите количество столбцов массива: ");
// int columns = int.Parse(Console.ReadLine()!);

// int[,] array = GetArray(rows, columns, 0, 10); // 0, 10 - минимальное и максимальное значение чисел(диапазон)
// PrintArray(array);
// Console.WriteLine();

// EvenIndexSquareElement(array);
// PrintArray(array);



// // Задача 51: Задайте двумерный массив. 
// // Найдите элементы, у которыъ оба индекса одинаковые,
// // и просуммируйте их значения(0,0; 1,1; 2,2)

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

// void EqualIndexSum(int[,] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (i == j)
//             {
//                 sum += array[i, j];
//             }
//         }
//     }
//     Console.Write($"Сумма чисел под одинаковыми индексами равна {sum}");
// }
// Console.Clear();

// Console.Write("Введите количество строк массива: ");
// int rows = int.Parse(Console.ReadLine()!);

// Console.Write("Введите количество столбцов массива: ");
// int columns = int.Parse(Console.ReadLine()!);

// int[,] array = GetArray(rows, columns, 0, 10); // 0, 10 - минимальное и максимальное значение чисел(диапазон)
// PrintArray(array);
// Console.WriteLine();

// EqualIndexSum(array);