// Задача 10

// int number = new Random().Next(100, 1000);
// Console.WriteLine(number);
// Console.Write($"{number%100*1/10}");

// Задача 13

int number = new Random().Next(1, 10000);
Console.WriteLine(number);

number = Math.Abs(number);

if (number<100)
{
    Console.WriteLine("Нет третьего числа");
}
else 
{
    while (number>=1000)
    {
        number /= 10;
    }
    int trd = number%10;
    Console.WriteLine(trd);
}

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
