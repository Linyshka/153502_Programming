Cookies cookie = new Cookies(10.99); //вызывается конструктор родителя
cookie.Print(); //виртуальный метод, который переопределен в этом классе
Milk milk = new Milk(2, 0.78);
milk.Print(); //виртуальный метод, не переопределен, поэтому вызовется метод класса Foodstuff
milk.ChangePrice(1.67); //скрытый метод
Console.WriteLine($"2 молока по цене 1,67 будут стоить: {milk.Sum()}");
milk.Buy();
cookie.ChangePrice(12.33); //cкрытый метод
Console.WriteLine($"1,5 килограмма печенья по цене 12,33 будет стоить: {cookie.Sum(1.5)}");
cookie.Buy(); //абстрактный метод
Furniture table = new Furniture(1, 39.12, "Стол"); //класс с запрещенным наследованием
table.Buy();

public abstract class Product
{
    private int amount_;
    private string area_;
    public string Area {
        get { return area_; }
        set { area_ = value; }
    }

    public int Amount
    {
        get { return amount_; }
        set { amount_ = value; }
    }
    public Product(int amount, string area)
    {
        Amount = amount;
        Area = area;
        Console.WriteLine($"Есть товар из области {area_} в количестве {amount_}");
    }

    abstract public string Buy();

    public void ChangeAmount(int NewAmount)
    {
        Amount = NewAmount;
    }
}

public class Foodstuff : Product
{
    private double price_;
    private string name_;
    private int amount_;

    public string Name
    {
        get { return name_; }
        set { name_ = value; }
    }

    public int Amount
    {
        get { return amount_; }
        set { amount_ = value; }
    }

    public Foodstuff(int amount, double price, string name) : base(amount, "Продукты питания")
    {        
        Amount = amount;
        price_ = price;
        Name = name;
    }

    public override string Buy()
    {
        Console.WriteLine($"Вы купили продукт питания {name_} по цене - {price_}");   //+++++++++++++++++++++++++++++++++
        string a = $"Вы купили продукт питания {name_} по цене - {price_}";
        return a;
    }

    public double Sum()
    {
        return price_ * amount_;  //++++++++++++++++++++++++++++++++
    }

    public virtual string Print()
    {
        Console.WriteLine($"Стоимость {Name} - {price_}; количество - {Amount}");   //+++++++++++++++++++++++++++++++
        return $"Стоимость {Name} - {price_}; количество - {Amount}";
    }

    public void ChangePrice(double price)
    {
        price_ = price;              //++++++++++++++++++++++++++++++++++++++
    }
}

public class Cookies : Foodstuff
{
    private double price_;

    public Cookies(double price) : base(1, price, "Печенье")
    {
        Price = price;
    }
    public double Price { 
        get { return price_; }
        set { price_ = value; }
    }

    public double Sum(double weight)
    {
        return price_ * weight;  //+++++++++++++++++++++
    }

    public override string Print()
    {
        Console.WriteLine($"Стоимость печенья за 1 кг - {price_}");   //++++++++++++++++++++++++++++++
        return $"Стоимость печенья за 1 кг - {price_}";
    }

    public new void ChangePrice(double price)
    {
        base.ChangePrice(price);
        Price = price;
        Console.WriteLine($"Килограмм печенья теперь стоит - {price_}");   //++++++++++++++++++++++++++++++
    }
}

public class Milk : Foodstuff
{
    private int amount_;
    double price_;

    public int Amount
    {
        get { return amount_; }
        set { amount_ = value; }
    }

    public double Price
    {
        get { return price_; }
        set { price_ = value; }
    }

    public Milk(int amount, double price) : base(amount, price, "Milk")
    {
        Amount = amount;
        
    }
}

public sealed class Furniture : Product
{
    private string name_;
    private double price_;

    public string Name
    {
        get { return name_;}
        set { name_ = value; }
    }

    public double Price
    {
        get { return price_; }
        set { price_ = value; }
    }
    public Furniture(int amount, double price, string name) : base(amount, "Мебель")
    {
        Name = name;
        Price = price;
    }

    public override string Buy()
    {
        Console.WriteLine($"Вы купили {name_} по цене {price_}");  //++++++++++++++++++++++++++++++
        return $"Вы купили {name_} по цене {price_}";
    }
}