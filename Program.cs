﻿// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Введите число: ");
double number = double.Parse(Console.ReadLine()!);

if(number % 2 == 0)
{
    Console.WriteLine($"{number} является четным числом");
}
else
{
    Console.WriteLine($"{number} не является четным числом");
}