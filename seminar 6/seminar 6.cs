// // Задача 39: Напишите программу, которая перевернет одномерный массив
// // [1 2 3 4 5] -> [5 4 3 2 1]

// int[] ReverseArray(int[] input)
// {
//     int[] result = new int[input.Length];

//     for (int i = 0, j = input.Length - 1; i < input.Length; i++, j--)
//     {
//         result[i] = input[j];
//     }
//     return result;
// }

// void PrintArray(int[] input)
// {
//     for (int i = 0; i < input.Length; i++)
//     {
//         Console.Write(input[i] + ", ");
//     }
// }

// int[] input = new int[] { 1, 2, 3, 4, 5 };
// var result = ReverseArray(input);
// PrintArray(result);

// // Задача 40: Напишите программу, которая принимает на вход 3 числа и проверяет, может ли существовать треугольник со сторонами такой длины.
// // Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
// bool IsTriangleExists(int A, int B, int C)
// {
//     if (A < B + C && B < A + C && C < A + B)
//     {
//         Console.WriteLine("Такой треугольник может существовать");
//         return true;
//     }
//     else
//     {
//         Console.WriteLine("Такой треугольник не может существовать");
//         return false;
//     }
// }

// Console.Clear();
// Console.WriteLine("Enter A: ");
// int A = int.Parse(Console.ReadLine()!);// ! в конце строки гарантирует правильность ввода данных, убирает желтые строки
// Console.WriteLine("Enter B: ");
// int B = int.Parse(Console.ReadLine()!);

// Console.WriteLine("Enter C: ");
// int C = int.Parse(Console.ReadLine()!);

// IsTriangleExists(A,B,C);

// if (IsTriangleExists(A,B,C))
// {
//     Console.WriteLine("Yes");
// }
// else
// {
//     Console.WriteLine("No"); // еще одно решение, вывод данных
// }

// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.

// void Binary (int x)
// {
//     string BinaryCode = Convert.ToString(x, 2);
//     Console.WriteLine($"Введенное число ({x}) в двоичном коде будет выглядеть следующим образом: {BinaryCode}");
// }

// Console.Clear();
// Console.WriteLine("Введите число: ");
// int num = int.Parse(Console.ReadLine()!);

// Console.WriteLine();

// Binary(num);

// // Еще одно решение

string DecimalToBinary(int input)
{
    var result = string.Empty;
    var devider = 2;

    int resultLength = 1;
    int temp = input;

    while (temp / devider > 0)
    {
        resultLength++;
        temp /= devider;
    }

    int[] resultArray = new int[resultLength];

    int index = resultLength - 1;

    while (index >= 0)
    {
        resultArray[index] += input % devider;
        index--;
        input /= devider;
    }

    for (int i = 0; i < resultArray.Length; i++)
    {
        result += resultArray[i];
    }
    return result;
}


Console.WriteLine("Введите десятичное число: ");
int number = int.Parse(Console.ReadLine()!);


var result = DecimalToBinary(number);

Console.WriteLine("Двоичное представление числа " + number + " есть число " + result);