int number;
bool task = true;
while (task)
{
    Console.WriteLine("Введите 1, если желаете продолжить. Введите 2, если желаете завершить выполнение программы: ");
    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine("Oшибка ввода! Введите число");
    }
    switch (number)
    {
        case 1:
            Console.WriteLine("Введите двузначное число:");
            while (!int.TryParse(Console.ReadLine(), out number) || number < 10 || number > 99)
            {
                Console.WriteLine("Oшибка ввода! Введите двузначное число");
            }
            bool test = Result.task(number);
            break;

        case 2:
            task = false;
            break;

        default:
            Console.WriteLine("Ошибка! Вы ввели некорректное число. Попробуйте еще раз.");
            break;
    }
}

public class Result
{
    public static bool task(int number)
    {
        int sum = number / 10 + number % 10;
        if (sum % 3 == 0)
        {
            Console.WriteLine("Сумма цифр кратна 3");
            return true;
            
        }
        else
        {
            Console.WriteLine("Сумма цифр не кратна 3");
            return false;
            
        }
    }
}
