// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
// является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int num = new Random().Next(0,11);
Console.WriteLine (num);


if ((1<=num)&&(num<=5))
 {
     Console.WriteLine ("Нет, это будний день!");
 }
 else if ((num==6)&&(num==7))
 {
     Console.WriteLine ("Да!!! Это выходной!!");
 }
 else
 {
     Console.WriteLine ("Такого дня нет");
 }