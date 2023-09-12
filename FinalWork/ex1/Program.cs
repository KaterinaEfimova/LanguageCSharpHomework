// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от
// N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


System.Console.WriteLine("Введите натуральное чисо n ");
int n = Convert.ToInt32(Console.ReadLine());

int[] lineArray = new int [n];

void PrintArray (int [] array)
{
    for (int i = 0; i < n; i++)
    {
       Console.Write(array[i]+" "); 
    }
}

void createArray (int [] array)
{
    for (int i = 0; i < n; i++)
    {
        array [i] = n-i;
    }
    PrintArray (lineArray);
}

createArray (lineArray);



