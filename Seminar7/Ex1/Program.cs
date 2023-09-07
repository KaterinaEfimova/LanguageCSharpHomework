// Задача 47. Задайте двумерный массив размером 
// m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Введите первую размерность массива");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите вторую размерность массива");
int colomns = Convert.ToInt32(Console.ReadLine());

double[,] matrix = new double[rows, colomns];

for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
matrix[i,j]= new Random().NextDouble()*10;
Console.Write(matrix[i,j]+" ");
}
Console.WriteLine();
}
