// string mes1 = "", mes2 = ""; // объявление и инициализация
// Console.WriteLine("Введите целое число ");

// // ввод строки и преобразование в целое число

// int n = int.Parse(Console.ReadLine());
// if (n>=0) mes1 ="положительное";
// else mes1 = "отрицательное";
// if (n%2==0) mes2 = "четное";
// else mes2 = "нечетное";
// Console.WriteLine("Число {0} {1} {2}", n, mes1, mes2);
// Console.ReadKey();



// Random rnd = new Random(); // создаем экземпляр класса Random
// // генерируем случайное целое число в интервале -40, 40
// int n = rnd.Next(-40, 40);
// // используем тернарный оператор
// string mes1 = (n >= 0) ? "положительное" : "отрицательное";
// string mes2 = (n % 2 == 0) ? "четное" : "нечетное";
// Console.WriteLine("Число {0} {1} {2}", n, mes1, mes2);
// Console.ReadKey();



// string mes;
// Console.WriteLine("Введите день недели: Пн, Вт, Ср, Чт, Пт, Сб, Вс");
// string day = Console.ReadLine();
// switch (day)
// { case "Сб": mes = "Иду в гости"; break;
// case "Вс": mes = "Отдыхаю"; break;
// default: mes = "Работаю"; break;
// }
// Console.WriteLine(mes);
// Console.ReadKey();



// string myLog = "qwerty", myPas = "asdf";
// string mes = "", mesYes = "Добро пожаловать!", mesNo = "Вход воспрещен!";
// Console.Write("Введите логин: ");
// string log = Console.ReadLine(); // вводим логин
// // проверяем длину и совпадение логина
// if (log.Length < 6) mes = "Логин очень короткий!\n" + mesNo;
// else if (log != myLog) mes = "Неверный логин!\n" + mesNo;
// else
// // в случае истинности логина вводим и проверяем пароль
// { Console.Write("Введите пароль: ");
// string pas = Console.ReadLine(); // вводим пароль
// mes = (pas == myPas) ? mesYes : "Неверный пароль!\n" + mesNo;
// }
// Console.WriteLine(mes); // выводим сообщения
// Console.ReadKey();



// double A, B, res=0; bool ok=true;
// Console.Write("Введите число А: ");
// string sA = Console.ReadLine(); // ввод строки
// if (!double.TryParse(sA, out A))
// { Console.WriteLine("Не число!"); A = 1; }; // преобразование в число

// Console.Write("Введите число B: ");
// string sB = Console.ReadLine();
// if (!double.TryParse(sB, out B))
// { Console.WriteLine("Не число!"); B = 1; }

// Console.Write("Введите знак операции (+-*/) ");
// string op = Console.ReadLine();

// switch (op)
// { case "+": res = A + B; break;
// case "-": res = A - B; break;
// case "*": res = A * B; break;
// case "/": res = A / B; break;
// default: ok = false; break;
// }
// if (ok)
// Console.WriteLine("{0} {1} {2} = {3}", A, op, B, res); //вывод
// else Console.WriteLine("Недопустимая операция");
// Console.ReadKey();

// void FillArray(int[] collection)
// {
//     int length = collection.Length;
//     int index = 0;
//     while (index < length)
//     {
//         collection[index] = new Random().Next(100, 1000);
//         index++;
//     }
// }
// void PrintArray(int[] col)
// {
//     int count = col.Length;
//     int position = 0;
//     while (position < count)
//     {
//         Console.Write($"{col[position]}, ");
//         position++;
//     }
// }
// void EvenNum(int[] a)п
// {
//     int count = 0;
//     for (int i = 0; i < a.Length; i++)
//     {

//         if (a[i] % 2 == 0)
//         {
//             count++;
//         }
//     }
//     Console.WriteLine($"Количество четных чисел в массиве = {count}");
// }
// void OddNumSum(int[] arr)
// {
//     int sum = 0;
//     for (int index = 0; index < arr.Length; index++)
//     {

//         if (arr[index] % 2 != 0)
//         {
//             sum = sum + arr[index];
//         }
//     }
//     Console.WriteLine($"Сумма нечетных чисел в массиве = {sum}");
// }
// void MaxMin(int[] ar)
// {
//     int max = ar[0];
//     int min = ar[0];
//     for (int ind = 0; ind < ar.Length; ind++)
//     {
//         if (ar[ind] > max)
//         {
//             max = ar[ind];
//         }
//         if (ar[ind] < min)
//         {
//             min = ar[ind];
//         }
//     }
//     Console.WriteLine($"Максимальное число = {max}");
//     Console.WriteLine($"Минимальное число = {min}");
//     Console.WriteLine($"Разница между максимаоьным и минимаоьным = {max - min}");
// }

// int[] array = new int[10];
// FillArray(array);
// PrintArray(array);
// Console.WriteLine();
// EvenNum(array);
// OddNumSum(array);
// MaxMin(array);