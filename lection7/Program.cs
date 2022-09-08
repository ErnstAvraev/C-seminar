﻿// Важно для рекурсии!
//  - описать условие выхода

// числа от a до b(a<=b)

// string NumberFor(int a, int b)
// {
//     string result = string.Empty;
//     for (int i = a; i <= b; i++)
//     {
//         result += $"{i} ";
//     }
//     return result;
// }

string NumberRec(int a, int b)
{
    if (a <= b) return $"{a} " + NumberRec(a + 1, b);
    else return String.Empty;
}

// Console.WriteLine(NumberFor(1, 10));
Console.WriteLine(NumberRec(1, 10));

// // числа от a до b(a>=b)

// string NumberFor(int a, int b)
// {
//     string result = string.Empty;
//     for (int i = a; i >= b; i--)
//     {
//         result += $"{i} ";
//     }
//     return result;
// }

// string NumberRec(int a, int b)
// {
//     if (a <= b) return NumberRec(a + 1, b) + $"{a} ";
//     else return String.Empty;
// }

// // Console.WriteLine(NumberFor(1, 10));
// Console.WriteLine(NumberRec(1, 10));

// // сумма чисел от 1 до n

// int SumFor(int n) // итеративный подход
// {
//     int result = 0;
//     for (int i = 1; i <= n; i++) result += i;
//     return result;
// }

int SumRec(int n) // рекурсивный подход
{
    if(n==0) return 0;
    else return n + SumRec(n-1);
}

// Console.WriteLine(SumFor(10));
// Console.WriteLine(SumRec(10));

// // Факториал числа

// int FactorialFor(int n)
// {
//     int result = 1;
//     for (int i = 1; i <= n; i++) result*=i;
//     return result;
// }

// int FactorialRec(int n)
// {
//     if(n==0) return 1;
//     if(n==1) return 1;
//     else return n*FactorialRec(n-1);
// }

// Console.WriteLine(FactorialFor(10));
// Console.WriteLine(FactorialRec(10));

// Вычислить а в степени n

// int PowerFor(int a, int n)
// {
//     int result = 1;
//     for (int i = 1; i <= n; i++) result *= a;
//     return result;
// }

// int PowerRec(int a, int n)
// {
//     //return n == 0 ? 1 : PowerRec(a, n - 1) * a; //можно записать так
//     if (n == 0) return 1;
//     else return PowerRec(a, n - 1) * a;
// }

// int PowerRecMath(int a, int n)
// {
//     if(n==0) return 1;
//     else if (n%2==0) return PowerRecMath(a*a, n/2);
//     else return PowerRecMath(a,n-1)*a;
// }

// Console.WriteLine(PowerFor(2, 10));
// Console.WriteLine(PowerRec(2, 10));
// Console.WriteLine(PowerRecMath(2, 10));

// перебор слов
// В некотором машинном алфавите имеются четыре буквы "а", "и", "с", "в".
// Покажите все слова, состоящие из Т букв, которые можно построить из букв этого алфавита

// char[] s = { 'а', 'и', 'с', 'в' };

// int count = s.Length;

int n = 1;

// for (int i = 0; i < count; i++)
// {
//     for (int j = 0; j < count; j++)
//     {
//         for (int k = 0; k < count; k++)
//         {
//             for (int l = 0; l < count; l++)
//             {
//                 Console.WriteLine($"{n++,-5}{s[i]}{s[j]}{s[k]}{s[l]}");
//             }
//         }
//     }
// }

void FindWords(string alphabet, char[] word, int length = 0)
{
    if(length==word.Length)
    {
        Console.WriteLine($"{n++} {new String(word)}"); return;
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        FindWords(alphabet,word,length+1);
    }
}

FindWords("аисв", new char[2]);