// Задача 50. Напишите программу, которая на вход принимает
// позиции элемента в двумерном массиве, и возвращает 
// значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


Console.WriteLine("Первую размерность массив");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Вторая размерность массив");
int colomns = Convert.ToInt32(Console.ReadLine());



int[,] matrix= new int[3,4];


for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
matrix[i,j]= new Random().Next(0,10);
Console.Write(matrix[i,j]+" ");
}
Console.WriteLine();
}

Console.WriteLine();
Console.WriteLine();

 if (rows-1 < matrix.GetLength(0) && colomns-1 < matrix.GetLength(1)) 
 {
    Console.WriteLine(matrix[rows-1, colomns-1]);
 }
else 
{
    Console.WriteLine($"({rows};{colomns}) - числа с такими индексами нет в массиве");
}
