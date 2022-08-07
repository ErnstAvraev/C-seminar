// Console.WriteLine("Введите число a: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число b: " );
// int b = Convert.ToInt32(Console.ReadLine());
int a = new Random().Next(1, 100);
Console.WriteLine("Число а = " + a);
int b = new Random().Next(1, 100);
Console.WriteLine("Число b = "+ b);
int max = 0;
if (a > b) {
    max = a;
}
else {
    max = b;
}
Console.WriteLine("Максимальное число равно " + max);