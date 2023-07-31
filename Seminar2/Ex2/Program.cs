// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int num = new Random().Next(10,40001);
Console.WriteLine (num);

if ((10<=num)&&(num<=99))
{
    Console.WriteLine ("Такой цифры нет");
}
else
{
    Console.WriteLine (num % 10);
}

