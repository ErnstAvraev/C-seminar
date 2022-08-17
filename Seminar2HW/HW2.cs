// Задача 10

// int number = new Random().Next(100, 1000);
// Console.WriteLine(number);
// int secondNumber = number / 10 % 10; 
// Console.Write($"Вторая цифра в числе {number} -> {secondNumber}");

// Задача 13

// int number = new Random().Next(1, 10000);
// Console.WriteLine(number);

// number = Math.Abs(number);

// if (number < 100)
// {
//     Console.WriteLine("Нет третьего числа");
// }
// else
// {
//     while (number >= 1000)
//     {
//         number /= 10;
//     }
//     int trd = number % 10;
//     Console.WriteLine(trd);
// }

// Второе решение

// Console.Write("Введите число: ");
// int num = int.Parse(Console.ReadLine());
// if (num < 100);
// {
//     Console.WriteLine($"Третьей цифры нет");
// }
// int thirdNumber = num % 10;
// Console.WriteLine($"Третья цифра числа {num} -> {thirdNumber}");

// еще одно 

// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num < 0)
// {
//     num = num * -1;
// }
// if (num > 0 && num < 100)
// {
//     Console.WriteLine("Третьей цифры нет");
// }
// else
// {
//     while (num > 999)
//     {
//         num = num / 10;
//     }
//     int thirdNum = num % 10;
//     Console.WriteLine($"Третья цифра -> {thirdNum}");
// }

// Задача 15
// Console.WriteLine("Введите цифру");
// int a = Convert.ToInt32(Console.ReadLine());

// if (a>5 && a<8)
// {
//     Console.WriteLine("Выходной");
// }
// if (a>0 && a<6)
// {
//     Console.WriteLine("Будни");
// }
// if(a>7)
// {
//     Console.WriteLine("Не день недели");
// }
