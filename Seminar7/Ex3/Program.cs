// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3

Console.WriteLine("Первую размерность массив");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Вторая размерность массив");
int colomns = Convert.ToInt32(Console.ReadLine());

int sum = 0;
double arithmeticMean = 0;


int[,] matrix= new int[rows,colomns];

for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
matrix[i,j]= new Random().Next(0,10);
Console.Write(matrix[i,j]+" ");

}
Console.WriteLine();
}


System.Console.WriteLine();

for (int j = 0; j < matrix.GetLength(1); j++)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sum = sum + matrix[i,j];
    }
    arithmeticMean = (double)sum/rows;

    sum=0;

    System.Console.Write(arithmeticMean +"  ");
}
