double number1, number2;
Console.WriteLine("Введите 2 числа:");
while (!double.TryParse(Console.ReadLine(), out number1)) 
{
    Console.WriteLine("Oшибка ввода! Введите число");
}
while (!double.TryParse(Console.ReadLine(), out number2)) 
{
    Console.WriteLine("Oшибка ввода! Введите число");
}
if (number2 == 0)
{
    Console.WriteLine("Нельзя разделить на 0");
}
else
{
    double result = number1 / number2;
    Console.WriteLine($"Результат деления чисел: {result}");
}
