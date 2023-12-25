//Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

int a = Convert.ToInt32(Console.ReadLine());
if ( a % 7 == 0 && a % 23 == 0) Console.WriteLine($"The number is a multiple of 7 and 23");
else Console.WriteLine("No");