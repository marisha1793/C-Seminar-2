﻿// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введи число от 1 до 7, обозначающее день недели: ");
int number = int.Parse(Console.ReadLine());
if(number >= 1 && number <= 5)
{
    Console.WriteLine("Это не выходной");
}
else if(number >= 6 && number <= 7)
{
    Console.WriteLine("Ура, это выходной!");
}
else
{
    Console.WriteLine("Что то непонятное, попробуй ввести другую цифру");
}
