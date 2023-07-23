// Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Введите чиcло");
int number1 = Convert.ToInt32(Console.ReadLine());

int remainder = number1%2;
if (remainder == 0)
{
    Console.WriteLine("Число делится на 2");
}
else
{
    Console.WriteLine("Число не делится на 2");
}