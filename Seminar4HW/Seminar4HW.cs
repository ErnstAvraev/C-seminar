// HW 
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


// void power(double num1, double num2)
// {
//     double result = Math.Pow(num1, num2);
//     Console.WriteLine(result);
// }

// Console.Clear ();
// Console.WriteLine("Введите число A: ");
// double a = Math.Abs((Convert.ToDouble(Console.ReadLine())));
// Console.WriteLine("Введите число B: ");
// double b = Math.Abs(Convert.ToDouble(Console.ReadLine()));
// power(a,b);



// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


int ammountNum(int a)
{
    int i = 0;
    while (a > 0)
    {
        a /= 10;
        i++;
    }
    return i;
}

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int res = num;
int result = 0;
int[] arr = new int[ammountNum(num)];

for (int i = 0; i != arr.Length; i++) // записываем значения в массив
{
    res %= 10;
    num /= 10;
    arr[i] = res;
    res = num;
}
for (int j = 0; j != arr.Length; j++)
{
    result = arr[j] + result;
}

Console.WriteLine(result);