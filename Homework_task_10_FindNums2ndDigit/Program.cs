﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трёхзначное число: ");
int userNum = int.Parse(Console.ReadLine()!);
int secondDigit = userNum/10%10;
Console.WriteLine($"{userNum} -> {secondDigit}");