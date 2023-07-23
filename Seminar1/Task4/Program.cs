// Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число");
int number=Convert.ToInt32(Console.ReadLine());

int a=2;
if (number>=2)
{  

while(a<=number)
{
Console.WriteLine(a);
a=a+2;
}
}
else
{
   Console.WriteLine("Ввелите положительное число большее или равное 2");
} 