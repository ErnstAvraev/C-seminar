
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

Console.WriteLine("Введите число a");
int a = Convert.ToInt32(Console.ReadLine());

// int a = new Random().Next(1, 1000);
// Console.WriteLine(a);

if (a % 7 == 0)
{
    if (a % 23 == 0)
    {
        Console.WriteLine("да");
    }
    else
    {
        Console.WriteLine("нет");
    }
}
else
{
    Console.WriteLine("нет");
}
