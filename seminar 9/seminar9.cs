// // ЗАДАЧА 63
// // Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

// string RowOfNumbers(int start, int end)
// {
//     if (start == end) return start.ToString();
//     return (start + " " + RowOfNumbers(start + 1, end));
// }

// Console.Clear();
// Console.WriteLine("Введите число N: ");
// int n = int.Parse(Console.ReadLine()!);

// Console.WriteLine(RowOfNumbers(1, n));


// // ЗАДАЧА 65:
// // Задайте значения M и N. Напишите программу, которая выведет все натуральные числа впромежутке M до N.

// string RowOfNumbers1(int start, int end)//m<n
// {
//     if (start == end) return start.ToString();
//     return (start + " " + RowOfNumbers1(start + 1, end));
// }

// string RowOfNumbers2(int start, int end)//m>n
// {
//     if (start == end) return start.ToString();
//     return (start + " " + RowOfNumbers2(start - 1, end));
// }

// void PrintNumbers1(int start, int end)//m<n
// {
//     Console.Write($"{start} ");
//     if (start == end) return;
//     PrintNumbers1(start + 1, end);
// }

// void PrintNumbers2(int start, int end)//m>n
// {
//     Console.Write($"{start} ");
//     if (start == end) return;
//     PrintNumbers2(start - 1, end);
// }

// Console.Clear();
// Console.WriteLine("Введите число M: ");
// int m = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите число N: ");
// int n = int.Parse(Console.ReadLine()!);

// if (m < n)
// {
//     Console.WriteLine(RowOfNumbers1(m, n));
//     Console.WriteLine();
//     PrintNumbers1(m, n);
// }
// if (m > n)
// {
//     Console.WriteLine(RowOfNumbers2(m, n));
//     Console.WriteLine();
//     PrintNumbers2(m, n);
// }


// // Напишите программу которая принимает число и возвращает сумму его цифр

// int SumOfNumbersInNumber(int number)
// {
//     int sum = 0;
//     if (number < 1) return sum;
//     return sum += number % 10 + SumOfNumbersInNumber(number / 10);
// }

// Console.WriteLine("Введите число x: ");
// int x = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Сумма цифр в числе равна {SumOfNumbersInNumber(x)}");

// // solution by Elena

// Console.Clear();
// Console.WriteLine(("Введите число: "));
// int m = int.Parse(Console.ReadLine()!);

// Console.WriteLine($"{m} -> {SumNumbers(m)}");

// int SumNumbers(int number)
// {
//     if (number == 0) return 0;
//     return (number % 10 + SumNumbers(number / 10));
// }

// int SumNumbers(int number)
// {
//     int sum = 0;
//     if(number==0) return 0;     // развернутое решение
//     sum = number%10 + SumNumbers(number/10);
//     return sum;
// }


// // Напишите программу, коорая на вход принимает два числа А и Б,
// //  и возводит А в степень Б

// Console.Clear();
// Console.WriteLine("Введите число А: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите число Б: ");
// int b = int.Parse(Console.ReadLine()!);

// Console.WriteLine($"{Pow(a,b)}");

// int Pow(int number, int rank)
// {
//     if(rank ==0) return 1;
//     return(number*Pow(number, rank-1));
// }
