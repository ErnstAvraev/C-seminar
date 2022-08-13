
// int number = new Random().Next(10, 100);
// Console.WriteLine(number);

// if (number/10 > number%10)
// {
//     Console.WriteLine(number/10);
// }
// else
// {
//     Console.WriteLine(number%10);
// }

// // задача 11

// int number = new Random().Next(100, 1000);
// Console.WriteLine(number);

// Console.Write($"{number/100}{number%10}");

// // задача 12

// Console.WriteLine("Введите число a ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число b ");
// int b = Convert.ToInt32(Console.ReadLine());

// int a = new Random().Next(1, 100);
// Console.WriteLine(a);
// int b = new Random().Next(1, 100);
// Console.WriteLine(b);

// if (b % a == 0)
// {
//     Console.WriteLine("Кратно");
// }
// else
// {
//     Console.WriteLine($"Не кратно, остаток равен {b % a}");
// }

// Задача 14

// Console.WriteLine("Введите число a");
// int a = Convert.ToInt32(Console.ReadLine());

// int a = new Random().Next(1, 1000);
// Console.WriteLine(a);

// решение из группы

// if ((a % 7 == 0) && (a % 23 == 0))
// {
//     Console.WriteLine($"да");
// }
// else
// {
//     Console.WriteLine($"нет");
// }
// if (a % 7 == 0)
// {
//     if (a % 23 == 0)
//     {
//         Console.WriteLine("да");
//     }
//     else
//     {
//         Console.WriteLine("нет");
//     }
// }
// else
// {
//     Console.WriteLine("нет");
// }

// Задача 16

// Console.WriteLine("Введите число a ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число b ");
// int b = Convert.ToInt32(Console.ReadLine());

// int a = new Random().Next(1, 1001);
// Console.WriteLine(a);
// int b = new Random().Next(1, 1001);
// Console.WriteLine(b);

// if (a * a == b)
// {
//     Console.WriteLine("второе число является квадратом первого");
// }
// else if (b * b == a)
// {
//     Console.WriteLine("первое число является квадратом второго");
// }
// else
// {
//     Console.WriteLine("числа не являются квадратами друг друга");
// }

// Доп задание 1

// int a = new Random().Next(19, 100);
// Console.WriteLine(a);
// Console.WriteLine("введите число d");
// int d = Convert.ToInt32(Console.ReadLine());

// if (a % d == 0)
// {
//     Console.WriteLine("Делится без остатка");
// }
// else
// {
//     Console.WriteLine("Не делится без остатка");
// }

// д/з
// задача 1
int number = new Random().Next(100, 1000);
Console.WriteLine(number);
Console.Write($"{number%100*1/10}");