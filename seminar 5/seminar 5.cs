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