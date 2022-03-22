using System;
public class Task2
{
    public double Y;
    public double X;
    public int a;
    public void function(int z, int b)
    {
        if (z <= 0) {
            X = System.Math.Pow(z, b) + System.Math.Abs(b / 2);
            a = 1;
        }
        else {
            X = System.Math.Sqrt(z);
            a = 2; 
            Console.WriteLine(a);
            Console.WriteLine(X);
        }
        Y = 1/System.Math.Cos(X) + System.Math.Log2(System.Math.Tan(X/2));
        Console.WriteLine($"Значение функции равно = {Y}, ветка № {a}");
    }

    public int input()
    {
        int number;
        while (!int.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("Oшибка ввода! Введите число");
        }
        return number;
    }
}