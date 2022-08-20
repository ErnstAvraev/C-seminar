// seminar 4

// задача 24: напишите программу, которая принимает на вход число А и выдает сумму чисел от 1 до А.
// 7 -> 28
// 4-> 10
// 8 -> 36

// int GetSumNums(int number)
// {
//     int sum = 0;

//     for (int i = 1; i <= Math.Abs(number); i++)
//     {
//         sum += i;
//     }
//     return sum;
// }

// Console.Clear();
// Console.Write("Введите число: ");
// int num = int.Parse(Console.ReadLine());
// Console.WriteLine($"Сумма цифр от 1 до введенного числа: {GetSumNums(num)}");

// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// void number(int x)
// {
//     int count = 0;
//     while (x != 0)
//     {
//         x /= 10;
//         count++;
//     }
//     Console.WriteLine($"Количество цифр в числе: {count}");
// }

// Console.WriteLine("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// number(a);