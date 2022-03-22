Date a = new Date();
DateOnly date;
Console.WriteLine("Введите дату: ");
while (!DateOnly.TryParse(Console.ReadLine(), out date))
{
    Console.WriteLine("Ошибка! Введите корректную дату!");
}
string date1 = date.ToString();
date1 = a.GetDay(date1);
Console.WriteLine(date1);
int days = a.GetDaysSpan(date.Day, date.Month, date.Year);
Console.WriteLine(days);
