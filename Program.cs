//Задача 3: Напишите программу, которая принимает на вход целое число 
//из отрезка [10, 99] и показывает наибольшую цифру числа.
int a = Convert.ToInt32(Console.ReadLine());

if (a > 10 && a < 99){
    if (a/10 > a%10) Console.WriteLine($"a = {a}, {a/10}");
    else Console.WriteLine($"a = {a}, {a%10}");
}
else Console.WriteLine("The number is not included in the segment");