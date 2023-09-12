// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

System.Console.WriteLine("Введите нижнюю границу диапазона m ");
int m = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите верхнюю границу диапазона n");
int n = Convert.ToInt32(Console.ReadLine()); 

if (m>n)
{   
    System.Console.WriteLine("Нижняя граница диапазона не может быть больше верней");
}

int a = n-(m-1);
int[] lineArray = new int [a];

void PrintArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
       Console.Write(array[i]+" "); 
    }
}

void createArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array [i] = m+i;
    }
    PrintArray (lineArray);
}

void SumArrayNatNat (int[] array)
{
    int sum = 0;
for (int i = 0; i < array.Length; i++)
{    
    sum = sum + array[i];
}
System.Console.WriteLine($"Сумма всех элементов от {m} до {n} равна {sum}");
}

void SumArrayNegNat (int[] array)
{
    int sum = 0;
    int sizeArrNat = array.Length - (-m+1);
for (int i = 0; i <= sizeArrNat; i++)
{    
    sum = sum + i;
}
System.Console.WriteLine($"Сумма всех натуральных элементов от {m} до {n} равна {sum}");
}


if (n>0 && m>=0 && n>m)
{
    createArray (lineArray);
    System.Console.WriteLine();
    SumArrayNatNat(lineArray);

}

else if (m<0 && n>0 && n>m)
{
    createArray (lineArray);
    System.Console.WriteLine();
    SumArrayNegNat (lineArray);

}

else if (m<0 && n<=0 && n>m)
{
    createArray (lineArray);
    System.Console.WriteLine();
    System.Console.WriteLine("В данном диапазоне нет натуральных чисел ");

}




