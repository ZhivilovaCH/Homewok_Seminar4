// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.


Console.Clear();
Console.WriteLine ("Введите число A:");
int a = int.Parse (Console.ReadLine()!);
Console.WriteLine ("Введите число B:");
int b = int.Parse (Console.ReadLine()!);
int GetExpon (int a)
{
    int exponent = 1;
    for (int i=1; i<=b; i++)
    {
        exponent = exponent*a;
    }
    return exponent;
}

int result = GetExpon (a);
Console.WriteLine("Результат = " + result);