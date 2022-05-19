Polinom polinom1 = new Polinom(0, 0, 0);
Polinom polinom2 = new Polinom(1, 2, 3);
if (polinom1 == polinom2) 
    Console.WriteLine("Все хорошо");
else Console.WriteLine("Они не равны");
if (polinom1 != polinom2)
    Console.WriteLine("Полиномы не равны");
else Console.WriteLine("Равны");
Console.WriteLine((++polinom1).ToString());
Console.WriteLine((--polinom2).ToString());
Console.WriteLine((polinom1 - polinom2).ToString());
Console.WriteLine((polinom1 + polinom2).ToString());
Console.WriteLine((polinom1*4).ToString());
Console.WriteLine((polinom2 / 2).ToString());
int a = (int)polinom1;
Console.WriteLine(a.ToString());
Console.WriteLine(polinom2.A + polinom2.B + polinom2.C); //свойства