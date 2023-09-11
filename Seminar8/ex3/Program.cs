//Задача 58: Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


Console.WriteLine("Введите первую размерность массива");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите вторую размерность первого массива");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите вторую размерность второго массива");
int c = Convert.ToInt32(Console.ReadLine());

int[,] matrix1= new int[a,b];

int[,] matrix2= new int[b,c];

int[,] matrixResult= new int[a,c];

void CreateArray(int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
array[i,j]= new Random().Next(0,10);
}
}
}

void PrintArray(int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
Console.Write(array[i,j]+ " ");
}
Console.WriteLine();
}
}

CreateArray(matrix1);
CreateArray(matrix2);
PrintArray(matrix1);
System.Console.WriteLine();
PrintArray(matrix2);

void MultMatrix (int[,] array1, int[,] array2, int[,] array3)
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            array3 [i,j] = 0;
            for (int k = 0; k < array2.GetLength(0); k++)
            {
                array3 [i,j] += array1[i,k]*array2[k,j];
            }
        }
    }
    
}


MultMatrix (matrix1, matrix2, matrixResult);

System.Console.WriteLine();
PrintArray(matrixResult);




