// // HW 
// // Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// // 3, 5 -> 243 (3⁵)
// // 2, 4 -> 16


// void power(double num1, double num2)
// {
//     double result = Math.Pow(num1, num2);
//     Console.WriteLine(result);
// }

// Console.Clear ();
// Console.WriteLine("Введите число A: ");
// double a = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите число B: ");
// double b = Convert.ToDouble(Console.ReadLine());
// power(a,b);


// Еще одно решение от Елены


// Console.Clear();
// Console.WriteLine("Введите число: ");
// int A = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите степень: ");
// int B = int.Parse(Console.ReadLine());

// Console.WriteLine($"{A} в степени {B} = {Pow(A, B)}");

// int Pow(int num, int rank)
// {
//     if (rank == 0) return 1;

//     int result = num;
//     for (int i = 2; i <= rank; i++)
//     {
//         result *= num;
//     }
//     return result;
// }


// // Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// // 452 -> 11
// // 82 -> 10
// // 9012 -> 12


// int ammountNum(int a) //Считаем количество разрядов
// {
//     int i = 0;
//     while (a > 0)
//     {
//         a /= 10;
//         i++;
//     }
//     return i;
// }

// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int res = num;
// int result = 0;
// int[] arr = new int[ammountNum(num)];

// for (int i = 0; i != arr.Length; i++) // записываем значения в массив 
// {
//     res %= 10;
//     num /= 10;
//     arr[i] = res;
//     res = num;
// }
// for (int j = 0; j != arr.Length; j++)
// {
//     result = arr[j] + result;
// }

// Console.WriteLine(result);
