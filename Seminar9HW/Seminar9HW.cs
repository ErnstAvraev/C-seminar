// // Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// // M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// // M = 4; N = 8. -> ""4, 6, 7, 8""

// string ShowNumberMN(int a, int b)
// {
//     if (a <= b) return $"{a} " + ShowNumberMN(a + 1, b);
//     else return String.Empty;
// }

// string ShowNumberNM(int a, int b)
// {
//     if (b <= a) return $"{a} " + ShowNumberNM(a - 1, b);
//     else return String.Empty;
// }

// Console.Clear();
// Console.WriteLine("Ввелите число M: ");
// int m = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Ввелите число N: ");
// int n = int.Parse(Console.ReadLine()!);

// if (m < n)    Console.WriteLine(ShowNumberMN(m, n));

// else    Console.WriteLine(ShowNumberNM(m, n));

// // Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// // M = 1; N = 15 -> 120
// // M = 4; N = 8. -> 30

// int SumFromMToN(int a, int b)
// {
//     if (a <= b) return a + SumFromMToN(a + 1, b);
//     else return 0;
// }

// int SumFromNToM(int a, int b)
// {
//     if (b <= a) return b + SumFromNToM(a, b + 1);
//     else return 0;
// }

// Console.Clear();
// Console.WriteLine("Ввелите число M: ");
// int m = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Ввелите число N: ");
// int n = int.Parse(Console.ReadLine()!);

// if (m < n) Console.WriteLine(SumFromMToN(m, n));
// else Console.WriteLine(SumFromNToM(m, n));

// // Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// // m = 2, n = 3 -> A(m,n) = 29

// int Ackerman(int n, int m)
// {
//     if (n == 0)
//         return m + 1;
//     else
//     if ((n != 0) && (m == 0))
//         return Ackerman(n - 1, 1);
//     else
//         return Ackerman(n - 1, Ackerman(n, m - 1));
// }

// Console.Clear();
// Console.WriteLine("Ввелите число M: ");
// int m = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Ввелите число N: ");
// int n = int.Parse(Console.ReadLine()!);

// if (m < 0 || n < 0) Console.WriteLine("Введите не отрицательные числа!");
// else Console.WriteLine(Ackerman(m, n));