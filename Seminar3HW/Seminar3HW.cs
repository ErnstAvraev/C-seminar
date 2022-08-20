// // // Задача 19
// // // Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// // // 14212 -> нет
// // // 12821 -> да
// // // 23432 -> да

// void palindrom(int x)
// {
//     if (x > 9999 && x < 100000)
//     {
//         if (x / 10000 == x % 10 && x / 1000 % 10 == x / 10 % 10)
//         {
//             Console.WriteLine($"Число является палиндромом ");
//         }

//         else
//         {
//             Console.WriteLine("Число не является палиндромом");
//         }
//     }
//     else
//     {
//         Console.WriteLine("Число выходит из диапазона допустимых значений");
//     }
// }

// Console.WriteLine("Введите 5-ти значное число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// palindrom(a);

// // Задача 21
// // Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// // A (3,6,8); B (2,1,-7), -> 15.84
// // A (7,-5, 0); B (1,-1,9) -> 11.53

// double segmentLength(int a, int b, int c, int d, int e, int f)
// {
//     double length = Math.Round(Math.Sqrt(Math.Pow((a - d), 2) + Math.Pow((b - e), 2) + Math.Pow((c - f), 2)), 2);
//     return length;
// }

// Console.Clear();
// Console.WriteLine("Введите координаты X1: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты Y1: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты Z1: ");
// int z1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координаты X2: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты Y2: ");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты Z2: ");
// int z2 = Convert.ToInt32(Console.ReadLine());

// double length = segmentLength(x1, y1, z1, x2, y2, z2);
// Console.WriteLine($"Расстояние между точками: {length}");


// // Задача 23
// // Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// // 3 -> 1, 8, 27
// // 5 -> 1, 8, 27, 64, 125

void cube(int num)
{
    for (int i = 1; i <= num; i++)
    {
        Console.Write($"{Math.Pow(i, 3)} ");
    }
}

Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
cube(N);