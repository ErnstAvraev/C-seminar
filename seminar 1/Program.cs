Console.WriteLine("Введите число");
 int number = Convert.ToInt32(Console.ReadLine());

// int sqrt = number * number;
// number *= number;
int sqrt1 = Convert.ToInt32(Math.Pow(number, 2));

// Console.WriteLine("Число в квадрате: " + sqrt);
// Console.WriteLine("Число в квадрате: " + number);
Console.WriteLine("Число в квадрате: " + sqrt1);