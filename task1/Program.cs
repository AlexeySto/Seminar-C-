// Напишите программу, которая на вход принимает два
// числа и проверяет, является ли первое число квадратом
// второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет

Console.Write("Ведите первое число : ");
int number1 = int.Parse(Console.ReadLine());

Console.Write("Ведите второе число : ");
int number2 = int.Parse(Console.ReadLine());

if (number1 * number1 == number2)
{
    Console.Write("Второе число является квадратом первого.");
}
else 
{
    Console.Write("Второе число НЕявляется квадратом первого.");
}