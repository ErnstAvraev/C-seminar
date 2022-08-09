// функция
// int Max(int arg1, int arg2, int arg3)
// {
//     int result = arg1;
//     if (arg2 > result) result = arg2;
//     if (arg3 > result) result = arg3;
//     return result;
// }


// int a1 = 11114225;
// int b1 = 21;
// int c1 = 39;
// int a2 = 12;
// int b2 = 2311;
// int c2 = 33;
// int a3 = 13;
// int b3 = 23111;
// int c3 = 33;


// Стихийный метод 8 строк кода
// int max = a1;
// if (b1 > max) max = b1;
// if (c1 > max) max = c1;

// if (a2 > max) max = a2;
// if (b2 > max) max = b2;
// if (c2 > max) max = c2;

// if (a3 > max) max = a3;
// if (b3 > max) max = b3;
// if( c3 > max) max = c3;

// int max1 = Max(a1,b1,c1);
// int max2 = Max(a2,b2,c2);
// int max3 = Max(a3,b3,c3);
// int max = Max(max1, max2, max3);

// int max = Max(
//     Max(a1,b1,c1),
//     Max(a2,b2,c2),
//     Max(a3,b3,c3));


// Console.WriteLine("максимальное число " +max);


// Массивы

// int Max(int arg1, int arg2, int arg3)
// {
//     int result = arg1;
//     if (arg2 > result) result = arg2;
//     if (arg3 > result) result = arg3;
//     return result;
// }

// int [] array = {11,21,31,41,15,61,71,18,19,};
// array[0] = 12;
// Console.WriteLine(array[4]); можно обратится к определенному индексу массива

// int max = Max(
//     Max(array[0],array[1],array[2]),
//     Max(array[3],array[4],array[5]),
//     Max(array[6],array[7],array[8])
// );Console.WriteLine(max);

// Задача на поиск из массива и отображение индекса элемента

// int [] array = {1, 12, 31, 4, 18, 15, 16, 17, 18};

// int n = array.Length;
// int find =18;

// int index = 0;

// while (index < n)
// {
//     if (array[index] == find)
//     {
//         Console.WriteLine(index);
//         break;
//     }
//     index++;
// }