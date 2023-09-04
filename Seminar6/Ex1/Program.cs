//Пользователь вводит с клавиатуры M чисел.
//Посчитайте, сколько чисел больше 0 ввёл пользователь.


Console.WriteLine("Введите количество чисел");
int len = Convert.ToInt32(Console.ReadLine());

int[] array = new int [len];

void AddArray()
{
   for (int i = 0; i < len; i++)
   {
    Console.WriteLine($"Введите {i+1} число");
    array[i] = Convert.ToInt32(Console.ReadLine());    
   }
   }

void PrintArray()
{
    Console.Write ("Введены числа:");
    for (int i = 0; i < array.Length; i++)
    {        
        Console.Write(array[i]+" ");
    }
}

void PositivNumber()

{
    int count = 0;
   
    for (int i = 0; i < len; i++)
    {
        if (array[i]>0)
    {       
        count= count+1;     
    }
    }
    System.Console.WriteLine("");
    System.Console.Write("Количество положительных чисел:");
    System.Console.Write(count);
}

AddArray();
PrintArray();
PositivNumber();

