﻿//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет
Console.WriteLine("Введите число и проверим четное ли оно");
int a = int.Parse(Console.ReadLine());

if (a % 2 == 0)
{
    Console.WriteLine($"Число {a} четное",a);
}
else
{
    Console.WriteLine($"Число {a} не четное",a);
}