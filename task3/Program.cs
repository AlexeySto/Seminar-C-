﻿// Напишите программу, которая на вход принимает
// одно число (N), а на выходе показывает все целые
// числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 

Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine());

int start = n * (-1);

while(start <= n)
{
     Console.Write(start + " ");
     start++;
}

