// // Задания которые не успели решить на семинаре

// Создание массива

// int[] CreateRandomArray(int N, int start, int end) // Рандомный массив
// {
//     int[] RandomArray = new int[N];
//     for (int i = 0; i < N; i++)
//     {
//         RandomArray[i] = new Random().Next(start, end + 1);
//     }
//     return RandomArray;
// }

// int[] CreateArray() // Заданный пользователем
// {
//     Console.WriteLine("Введите количество элементов массива");
//     int size = Convert.ToInt32(Console.ReadLine());
//     int[] RandomArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         Console.WriteLine($"Введите {i + 1} элемент массива");
//         RandomArray[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return RandomArray;
// }

// void ShowArray(int[] array) // выводит массив в консоль
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + ", ");
//     }
//     Console.WriteLine();
// }


// Console.Clear();
// Console.WriteLine("Введите количество элементов в массиве");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите первое число случайно генерируемого диапазона");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите последнее число случайно генерируемого диапазона");
// int max = Convert.ToInt32(Console.ReadLine());      // для рандомного массива

// int[] myRandomArray = CreateRandomArray(num, min, max);
// ShowArray(myRandomArray);       //// для рандомного массива
// Console.WriteLine("-------------");
// int[] myArray = CreateArray();
// ShowArray(myArray); // для заданного пользователем массива


// // Напишите программу, котороая задает массив из 8 элементов и выводит их на экран

// Console.Clear();
// int[] array = GetRandomArray(8, 0, 100);
// Console.WriteLine($"[{String.Join(", ", array)}]");

// int[] GetRandomArray(int size, int minValue, int maxValue)
// {
//     int[] result = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(minValue, maxValue);
//     }

//     return result;
// }


// Напишите программу, которая выводит массив из 8 элементов
// заполненный 0 и 1 в случайном порядке.

// int[] array = GetBinaryArray(8);
// Console.WriteLine($"[{String.Join(",", array)}]");


// int[] GetBinaryArray(int size)
// {
//     int[] result = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(2);
//     }
//     return result;
// }


// // Задача 31.
// // Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// // Найдите сумму отрицательных и положительных элементов массива.
// // Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных равна 29, сумма отрицательных равна -20.


// int[] CreateRandomArray(int size, int min, int max)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + ", ");
//     }
//     Console.WriteLine();
// }

// int[] myArray=CreateRandomArray(12,-9,9);
// ShowArray(myArray);

// int sum_pos = 0;
// int sum_neg = 0;

// for (int i = 0; i < myArray.Length; i++)
// {
//     if(myArray[i]>0)
//     {
//         sum_pos += myArray[i];
//     }
//     else
//     {
//         sum_neg += myArray[i];
//     }
// }

// Console.WriteLine($"Сумма положительных: {sum_pos}. Сумма отрицательных: {sum_neg}");

// Console.WriteLine($"{myArray[11]} {myArray[1]}");


// // Задача 32.
// // Напишите программу замены элементов массива: положительные на отрицательные и наоборот.
// // Пример: [-4,-8,8,2] -> [4,8,-8,-2]

// int[] CreateRandomArray(int size, int min, int max)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + ", ");
//     }
//     Console.WriteLine();
// }
// int[] myArray=CreateRandomArray(20,-100,101);
// ShowArray(myArray);

// for (int i = 0; i < myArray.Length; i++)
// {
//     myArray[i]*=-1;
// }
// Console.WriteLine($"{String.Join(", ",myArray)}");

// // Задача 33.
// // Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// // Пример: 4; массив [6,7,19,345,3] -> нет
// //         3; массив [6,7,19,345,3] -> да

// int[] CreateRandomArray(int size, int min, int max)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + ", ");
//     }
//     Console.WriteLine();
// }

// bool numInArray(int[] array, int num)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] == num)
//         {
//             return true;
//         }
//     }
//     return false;
// }

// Console.Clear();
// int[] myArray = CreateRandomArray(20, -100, 101);
// ShowArray(myArray);

// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Это число есть в массиве? -> {numInArray(myArray, num)}");

// // Задача 35: Задайте одномерный массив из 123 случайных чисел.
// // Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// // Пример: [5,18,123,6,2] -> 1
// //         [1,2,3,6,2] -> 0
// //         [10,11,12,13,14] -> 5

// int[] CreateRandomArray(int size, int min, int max)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + ", ");
//     }
//     Console.WriteLine();
// }

// Console.Clear();
// int[] myArray = CreateRandomArray(123, -100, 101);
// ShowArray(myArray);

// int count = 0;
// for (int i = 0; i < myArray.Length; i++)
// {

//     if (myArray[i] >= 10 && myArray[i] <= 99)
//     {
//         count++;
//     }
// }
// Console.WriteLine($"Количество цифр лежащих в заданном диапазоне = {count}");

// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и тд.
// Результат запишите в новом массиве.
// Пример: [1 2 3 4 5] -> [5 8 3]
//         [6 7 3 6] -> [36 21]