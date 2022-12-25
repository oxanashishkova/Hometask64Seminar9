// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
/* N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
Console.WriteLine("Hello, World!"); */

Console.Write("Enter number more than 1: ");
int number = int.Parse(Console.ReadLine());


void GetNumbers(int number)
{
    if (number < 0)
        Console.Write($"{number} not natural number");
    if (number == 0)
        return;
    Console.Write(number);
    GetNumbers(number - 1);
}

GetNumbers(number);
