// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// System.Console.WriteLine("Введите число A: ");
// int a = Convert.ToInt32(System.Console.ReadLine());

// System.Console.WriteLine("Введите число B: ");
// int b = Convert.ToInt32(System.Console.ReadLine());

// double c = Math.Pow(a, b), 4;
// System.Console.WriteLine($"{a} в степени {b} = {c}");

// С функциями:

int GetNum(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(System.Console.ReadLine());
}

double Result(int a, int b)
{
    double res = Math.Pow(a,b);
    return res;
}

int numberA = GetNum("Введите число А: ");
int numberB = GetNum("Введите число В: ");
System.Console.WriteLine($"Число { numberA} в степени {numberB} = {Result(numberA, numberB)}");
