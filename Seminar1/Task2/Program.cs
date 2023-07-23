// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите первое чиcло");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе чиcло");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье чиcло");
int number3 = Convert.ToInt32(Console.ReadLine());

int max1;
int max2;

if (number1 > number2)
{
    max1 = number1;
}
else
{
    max1 = number2;
}

if (max1>number3)
{
    max2 = max1;
}
else
{
    max2 = number3;
}
Console.WriteLine($"Наибольшее чиcло {max2}");