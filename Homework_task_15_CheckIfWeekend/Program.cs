// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Какой сегодня по счёту день недели?\nВведите число от 1 до 7: ");
int userNum = int.Parse(Console.ReadLine()!);

if(userNum > 0 && userNum < 6)
    Console.WriteLine("Сегодня будний день.");
else if(userNum == 6 || userNum == 7)
    Console.WriteLine("Сегодня ВЫХОДНОЙ!");
else
    Console.WriteLine("Ошибка ввода. Введите число от 1 до 7.");