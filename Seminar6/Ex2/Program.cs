//  Напишите программу, которая найдёт точку пересечения двух прямых,
//  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения
//  b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine("Введите k1");
float k1 = Convert.ToSingle(Console.ReadLine());

Console.WriteLine("Введите b1");
float b1 = Convert.ToSingle(Console.ReadLine());

Console.WriteLine("Введите k2");
float k2 = Convert.ToSingle(Console.ReadLine());

Console.WriteLine("Введите b2");
float b2 = Convert.ToSingle(Console.ReadLine());

if (k1==k2)
{
    Console.WriteLine("Прямые параллельны, пересечений нет");
}
else
{
    float x = (b2-b1)/(k1-k2);
    float y = k1*x-b1;
    Console.WriteLine($"Прямые пересекаются в точке ({x};{y})");
}