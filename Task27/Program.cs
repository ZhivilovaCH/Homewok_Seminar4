// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.


Console.Clear();
Console.WriteLine("Введите число A:");
int a = int.Parse(Console.ReadLine()!);
int GetSum (int a)

{
    int sum = 0;
    int number = 0; 

    while (a!=0)
    {
        number= a%10;
        a = a/10;
        sum = sum + number;
    }
    return sum;
}

int result = GetSum (a);
Console.WriteLine("Результат = " + result);