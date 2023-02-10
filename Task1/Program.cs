// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

System.Console.WriteLine("Введите число A: ");
int a = Convert.ToInt32(System.Console.ReadLine());

System.Console.WriteLine("Введите число B: ");
int b = Convert.ToInt32(System.Console.ReadLine());

double c = Math.Pow(a, b);
System.Console.WriteLine($"{a} в степени {b} = {c}");

