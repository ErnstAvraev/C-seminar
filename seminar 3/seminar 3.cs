// Напишите программу, которая принимает на вход точки (X и Y)б причем X не равен 0 и Y не равен 0 и выдает к какой четверти принадлежит точка
// Вводим метод

void printQuarter(int a, int b)
{
  if (a > 0 && b > 0)
{
    Console.WriteLine("First quarter");
}
else if (a < 0 && b > 0)
{
    Console.WriteLine("Second quarter");
}
else if (a < 0 && b < 0)
{
    Console.WriteLine("Third quarter");
}
else if (a > 0 && b < 0)
{
    Console.WriteLine("forth quarter");
}
else 
{
    Console.WriteLine("Can't identify quarter");
}  
}


Console.WriteLine("Input coordinate x");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input coordinate y");
int y = Convert.ToInt32(Console.ReadLine());
printQuarter(x, y);


// Без метода
// if (x > 0 && y > 0)
// {
//     Console.WriteLine("First quarter");
// }
// else if (x < 0 && y > 0)
// {
//     Console.WriteLine("Second quarter");
// }
// else if (x < 0 && y < 0)
// {
//     Console.WriteLine("Third quarter");
// }
// else if (x > 0 && y < 0)
// {
//     Console.WriteLine("forth quarter");
// }
// else 
// {
//     Console.WriteLine("Can't identify quarter");
// }