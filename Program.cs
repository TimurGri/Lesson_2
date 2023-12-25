//Задача 4: Напишите программу, которая на вход принимает натуральное число N,
// а на выходе показывает его цифры через запятую.
int a = Convert.ToInt32(Console.ReadLine());

if (a > 0 ) {
    int temp = a;
    int i = 0 , b;

    while (temp > 0)
    {
        temp /= 10;
        i++;
    }
    //Console.WriteLine(i);
    for (int j = i - 1 ; j >= 0; j--) {
        b = (a / (int)Math.Pow(10, j));
        b %= 10;
        Console.Write($"{b}");
        if (j > 0) Console.Write(", ");
        
    }
}
else Console.WriteLine("The number is not natural");
