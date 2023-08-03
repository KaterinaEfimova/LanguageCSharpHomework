// Напишите программу, которая принимает на вход 
// координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите координату Х первой точки: ");
int X1 =Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y первой точки: ");
int Y1 =Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z первой точки: ");
int Z1 =Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату Х второй точки: ");
int X2 =Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y второй точки: ");
int Y2 =Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z второй точки: ");
int Z2 =Convert.ToInt32(Console.ReadLine());


double s=Math.Sqrt((Math.Pow((X2-X1),2) + Math.Pow((Y2-Y1),2) + Math.Pow((Z2-Z1),2)));



System.Console.WriteLine(s);