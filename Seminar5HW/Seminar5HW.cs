// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// void FillArray(int[] collection)
// {
//     int length = collection.Length;
//     int index = 0;
//     while (index < length)
//     {
//         collection[index] = new Random().Next(100, 1000);
//         index++;
//     }
// }

// void PrintArray(int[] col)
// {
//     int count = col.Length;
//     int position = 0;
//     while (position < count)
//     {
//         Console.Write($"{col[position]}, ");
//         position++;
//     }
// }

// void EvenNum(int[] a)
// {
//     int count = 0;
//     for (int i = 0; i < a.Length; i++)
//     {

//         if (a[i] % 2 == 0)
//         {
//             count++;
//         }
//     }
//     Console.WriteLine($"Количество четных чисел в массиве = {count}");
// }

// int[] array = new int[10];
// FillArray(array);
// PrintArray(array);
// Console.WriteLine();
// EvenNum(array);

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

// void FillArray(int[] collection)
// {
//     int length = collection.Length;
//     int index = 0;
//     while (index < length)
//     {
//         collection[index] = new Random().Next(-100, 101);
//         index++;
//     }
// }
// void PrintArray(int[] col)
// {
//     int count = col.Length;
//     int position = 0;
//     while (position < count)
//     {
//         Console.Write($"{col[position]}, ");
//         position++;
//     }
// }

// void OddNumSum(int[] arr)
// {
//     int sum = 0;
//     for (int index = 0; index < arr.Length; index++)
//     {

//         if (index % 2 != 0)
//         {
//             sum = sum + arr[index];
//         }
//     }
//     Console.WriteLine($"Сумма нечетных чисел в массиве = {sum}");
// }

// int[] array = new int[10];
// FillArray(array);
// PrintArray(array);
// Console.WriteLine();
// OddNumSum(array);

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

// double[] CreateRandomArray(int size, int min, int max)
// {
//     double[] array = new double[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = Math.Round(new Random().NextDouble() * 100 - 30, 2);
//     }
//     return array;
// }

// void ShowArray(double[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + ", ");
//     }
//     Console.WriteLine();
// }

// void MaxMin(double[] ar)
// {
//     double max = ar[0];
//     double min = ar[0];
//     for (int ind = 0; ind < ar.Length; ind++)
//     {
//         if (ar[ind] > max)
//         {
//             max = ar[ind];
//         }
//         if (ar[ind] < min)
//         {
//             min = ar[ind];
//         }
//     }
//     Console.WriteLine($"Максимальное число = {max}");
//     Console.WriteLine($"Минимальное число = {min}");
//     Console.WriteLine($"Разница между максимаоьным и минимаоьным = {max - min}");
// }

// Console.Clear();
// double[] myArray = CreateRandomArray(10, 1, 100);
// ShowArray(myArray);
// MaxMin(myArray);