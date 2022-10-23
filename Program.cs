using System.Runtime.CompilerServices;
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.WriteLine("Введите трехзначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int num1 = num % 100 / 10;
// Console.WriteLine(num1);

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

// Console.WriteLine("Введие число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num > 99)
// {
//     Console.WriteLine(num.ToString()[2]);
// }
// if (num < 99)
// {
// Console.WriteLine("Третьей цифры нет!");
// }

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введие цифру, обозначающую день недели: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num == 6 || num == 7)
{
Console.WriteLine("Этот день является выходным!");
}
else if (num < 1 || num > 7)
{
    Console.WriteLine("Эа цифра не являеться днем недели!");
} 
else Console.WriteLine("Этот день не выходной!");












