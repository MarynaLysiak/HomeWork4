// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Матемитическое решение:

// System.Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(System.Console.ReadLine());

// int sum = 0;
// int length = Convert.ToString(number);
// for (int i = 0; i <= length; i++)
// {
//     sum = sum + number%10;
//     number = number/10;
// }

//  System.Console.WriteLine($"Сумма цифр в числе {number} = {sum}");

// Функция:

int GetNumber(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(System.Console.ReadLine());
}

int GetSum(int number)
{
    int sum = 0;
    int length = Convert.ToString(number).Length;
    for (int i = 0; i <= length; i++)
    {
        sum = sum + number%10;
        number = number/10;
    }
    return sum;
}

int num = GetNumber("Введите число N: ");
System.Console.WriteLine($"Сумма цифр числа {num} = {GetSum(num)}");
