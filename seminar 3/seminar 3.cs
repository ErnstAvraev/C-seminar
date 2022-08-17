// Напишите программу, которая принимает на вход точки (X и Y)б причем X не равен 0 и Y не равен 0 и выдает к какой четверти принадлежит точка
// Вводим метод

// void без использования return
// void printQuarter(int a, int b)
// {
//     if (a > 0 && b > 0)
//     {
//         Console.WriteLine("First quarter");
//     }
//     else if (a < 0 && b > 0)
//     {
//         Console.WriteLine("Second quarter");
//     }
//     else if (a < 0 && b < 0)
//     {
//         Console.WriteLine("Third quarter");
//     }
//     else if (a > 0 && b < 0)
//     {
//         Console.WriteLine("forth quarter");
//     }
//     else
//     {
//         Console.WriteLine("Can't identify quarter");
//     }
// }

// int с использованием return
// int returnQuarter(int a, int b)
// {
//     if (a > 0 && b > 0)
//     {
//         return 1;
//     }
//     else if (a < 0 && b > 0)
//     {
//         return 2;
//     }
//     else if (a < 0 && b < 0)
//     {
//         return 3;
//     }
//     else if (a > 0 && b < 0)
//     {
//         return 4;
//     }
//     else
//     {
//         return 0;
//     }
// }


// Console.WriteLine("Input coordinate x");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input coordinate y");
// int y = Convert.ToInt32(Console.ReadLine());
// printQuarter(x, y);

// если метод int
// Console.WriteLine(returnQuarter(x, y));
// int quarter = returnQuarter(x, y)
// Console.WriteLine($"Quarter: {quarter}");

// Без метода
// if (x > 0 && y > 0)
// {
//     Console.WriteLine("First quarter");
// }
// else if (x < 0 && y > 0)
// {
//     Console.WriteLine("Second quarter");
// }
// else if (x < 0 && y < 0)
// {
//     Console.WriteLine("Third quarter");
// }
// else if (x > 0 && y < 0)
// {
//     Console.WriteLine("forth quarter");
// }
// else 
// {
//     Console.WriteLine("Can't identify quarter");
// }

// // Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y)

// void range(int q)
// {
//     switch (q)
//     {
//         case 1: Console.Write("x > 0, y > 0"); break;
//         case 2: Console.Write("x < 0, y > 0"); break;
//         case 3: Console.Write("x < 0, y < 0"); break;
//         case 4: Console.Write("x > 0, y < 0"); break;
//         default: Console.Write("Число находится вне диапазона"); break;
//     }
// }

// Console.Clear();
// Console.WriteLine("Введите номер четверти от 1 до 4: ");
// int quart = Convert.ToInt32(Console.ReadLine());
// range(quart);




// Найти расстояние между 2 точками

// double segmentLength(int a, int b, int c, int d)
// {

//     double l = Math.Sqrt((a - c) * (a - c) + (b - d) * (b - d));
//     return l;
// }


// Console.Clear();
// Console.Write("Введите координату X1: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату Y1: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату X2: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату Y2: ");
// int y2 = Convert.ToInt32(Console.ReadLine());

// double length = segmentLength(x1, y1, x2, y2);
// Console.WriteLine($"Расстояние между точками {length}");

// квадраты чисел до числа N

// void sqr(int a)
// {
//     int count = 1;
//     while (count <= a)
//     {
//         Console.Write($"{Math.Pow(count, 2)} ");
//         count++;
//     }
// }
// Console.Clear();
// Console.WriteLine("Введите число: ");
// int x = Convert.ToInt32(Console.ReadLine());

// sqr(x);

// еще одно решение

// Console.Clear();
// Console.Write("Введите число N: ");
// int N = int.Parse(Console.ReadLine());

// for (int i = 1; i <= N; i++)
// {
//     Console.Write($"{(i)*(i)} ");
// }