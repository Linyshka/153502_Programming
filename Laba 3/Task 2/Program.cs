int number;
int z, b;
bool task = true;
Task2 a = new Task2();
while (task)
{
    Console.WriteLine("Введите 1, если желаете продолжить. Введите 2, если желаете завершить выполнение программы: ");
    number = a.input();
    switch (number)
    {
        case 1:
            Console.WriteLine("Введите число z: ");
            z = a.input();
            Console.WriteLine("Введите число b: ");
            b = a.input();
            a.function(z,b);
            break;

        case 2:
            task = false;
            break;

        default:
            Console.WriteLine("Ошибка! Вы ввели некорректное число. Попробуйте еще раз.");
            break;
    }
}
