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
// void EvenNum(int[] a)п
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
// void OddNumSum(int[] arr)
// {
//     int sum = 0;
//     for (int index = 0; index < arr.Length; index++)
//     {

//         if (arr[index] % 2 != 0)
//         {
//             sum = sum + arr[index];
//         }
//     }
//     Console.WriteLine($"Сумма нечетных чисел в массиве = {sum}");
// }
// void MaxMin(int[] ar)
// {
//     int max = ar[0];
//     int min = ar[0];
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

// int[] array = new int[10];
// FillArray(array);
// PrintArray(array);
// Console.WriteLine();
// EvenNum(array);
// OddNumSum(array);
// MaxMin(array);