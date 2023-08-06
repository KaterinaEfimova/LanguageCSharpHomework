// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.Write("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
string num2 = Convert.ToString(num1);

int Sum()
{
    int res = 0;
    int size = num2.Length;
    for (int i = 0; i < size; i++)
    {
        res += num1 % 10;
        num1 /= 10;
    }
    return res;
}

Console.WriteLine();
Console.WriteLine(Sum());