// Напишите цикл, который принимает на вход два числа (A и B)
//  и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число - основание степени : ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число - показатель степени : ");
int n = Convert.ToInt32(Console.ReadLine());

int  Degree()
{
    int result = 1;
    int count = 1;
    while (count <= n)
    {
        result = result * a;
        count++; 
    }
    return result;
}

Console.Write(Degree());