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

// Решение Михаила

// int num = Convert.ToInt32(Console.ReadLine());
// int n = num;
// int i = 0;
// int numA = 0;
// int numB = 0;

// while (num > 0)
// {
//     i++;
//     num /= 10;
// }
// Console.WriteLine($"Количество цифр введенного числа: {i}");

// int k = Convert.ToInt32(Math.Pow(10, i - 3));

// if (n < 100)
// {
//     Console.WriteLine("Третьей цифры нет");
// }
// else
// {
//     numA = n / k;
//     numB = numA % 10;
//     Console.WriteLine($"Третья цифра введенного числа: {numB}");
// }

// Решение с длинной числа и индексом

// Console.WriteLine("Введите число: ");
// string number = Console.ReadLine();
// long num;
// bool isnum = long.TryParse(number, out num);

// if (isnum)
// {
//     if (number[0] == '-' && number.Length == 3 || (number[0] != '-' && number.Length == 2))
//     {
//         Console.WriteLine("Третьей цифры нет");
//     }
// else if (number[0] == '-')
//     {
//         Console.WriteLine(number[3]);
//     }
// else
//     {
//         Console.WriteLine(number[2]);
//     }
// }
// else
// {
//     Console.WriteLine("Введены не цифры");
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

// решение Елены
// Console.Clear();
// Console.Write("Введите число: ");
// int num = int.Parse(Console.ReadLine());
// if (num > 7 || num < 1)
// {
//     Console.WriteLine("Неверный день недели");
// }
// if (num > 5)
// {
//     Console.WriteLine("Да");
// }
// else 
// {
//     Console.WriteLine("Нет");
// }

// Решение Дениса
// Console.Write($"Введите цифру соответствующую дню недели: ");
// int day = Convert.ToInt32(Console.ReadLine());

// int result = day % 7;

// switch (result)
// {
//     case 1: Console.Write($"{day} является понедельником"); break;
//     case 2: Console.Write($"{day} является вторником"); break;
//     case 3: Console.Write($"{day} является средой"); break;
//     case 4: Console.Write($"{day} является четвергом"); break;
//     case 5: Console.Write($"{day} является пятницей"); break;
//     case 6: Console.Write($"{day} является субботним выходным"); break;
//     case 0: Console.Write($"{day} является воскресным выходным"); break;
//     default: break;
// }