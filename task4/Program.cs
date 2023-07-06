﻿// Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает последнюю цифру
// этого числа.
// 456 -> 6

Console.Write("Введите трехзначное число N: ");
int n = int.Parse(Console.ReadLine());

if (n >= 100 && n <= 999)
{
    int result = n % 10;
    Console.WriteLine("Последняя цифра " + result + ".");
}
else
{
    Console.WriteLine("число не трехзначное.");
}