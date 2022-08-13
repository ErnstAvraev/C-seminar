// Задача 2
// Console.WriteLine("Введите число a: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число b: ");
// int number2 = Convert.ToInt32(Console.ReadLine());

// int a = new Random().Next(1, 100);
// Console.WriteLine("Число а = " + a);
// int b = new Random().Next(1, 100);
// Console.WriteLine("Число b = "+ b);


// if (number1 > number2)
// {
//     Console.WriteLine("a больше b");
// }
// else if (number1 < number2)
// {
//     Console.WriteLine("b больше a");
// }
// else
// {
//     Console.WriteLine("a равно b");
// }

// Задача 4
// Console.WriteLine("Введите число a: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число b: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число c: ");
// int c = Convert.ToInt32(Console.ReadLine());

// int a = new Random().Next(1, 100);
// Console.WriteLine("Число а = " + a);
// int b = new Random().Next(1, 100);
// Console.WriteLine("Число b = "+ b);
// int c = new Random().Next(1, 100);
// Console.WriteLine("Число c = " + c);

// int max = 0;

// if (a > max)
// {
//     max = a;
// }
// if (b > max)
// {
//     max = b;
// }
// if (c > max)
// {
//     max = c;
// }
// Console.WriteLine($"Максимальное число = {max}");

// Задача 6

// Console.WriteLine("Введите число ");
// int a = Convert.ToInt32(Console.ReadLine());

// int a = new Random().Next(1, 100);
// Console.WriteLine("Число a = " + a);

// if (a % 2 == 0)
// {
//     Console.WriteLine("Число четное");
// }
// else
// {
//     Console.WriteLine("Число нечетное");
// }
// if (a % 2 != 0)
// {
//     Console.WriteLine("Число нечетное");
// }
// else
// {
//     Console.WriteLine("Число четное");
// }

// Задача 8
// Console.Clear();
// Console.WriteLine("Введите число ");
// int N = Convert.ToInt32(Console.ReadLine());

// int N = new Random().Next(1, 100);
// Console.WriteLine("Число N = " + N);

// // Мое решение

// int i = 0;

// if (N % 2 != 0)
// {
//     while (i < N - 1)
//     {
//         i += 2;
//         Console.WriteLine(i);
//     }
// }
// else
// {
//     while (i < N)
//     {
//         i += 2;
//         Console.WriteLine(i);
//     }
// }

// // Решение Елены 1

// int i = 1;
// while (i <= N)
// {
//     if (i % 2 == 0)
//     {
//         Console.Write($"{i} "); //Console.Write(i + " ");
//     }
//     i++;
// }
// Console.WriteLine();

// // Решение Елены 2

// int k = 2;
// while (k <= N)
// {
//     Console.Write($"{k} ");
//     k += 2;
// }