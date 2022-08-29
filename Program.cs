// задача 19
// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// int first = num / 10000;
// int second = (num - first * 10000) / 1000;
// int therd = (num - first * 10000 - second * 1000) / 100;
// int fourty = (num - first * 10000 - second * 1000 - therd * 100) / 10;
// int fifty = num % 10;

// if (first == fifty & second == fourty)
// { 
//     Console.WriteLine("да");
// }
// else
// {
//     Console.WriteLine("нет");
// }

// задача 21
// Console.WriteLine("Введите х1");
// double x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите y1");
// double y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите z1");
// double z1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите х2");
// double x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите y2");
// double y2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите z2");
// double z2 = Convert.ToInt32(Console.ReadLine());

// double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
// Console.WriteLine(result);

//задача 23
Console.WriteLine("Введите число");
double num = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= num; i++)
{
    Console.Write(Math.Pow(i, 3));
    Console.Write(", ");
}