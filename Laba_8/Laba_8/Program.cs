Bank belinvest = new Bank();
belinvest.AddContrWithBon("Svetlna", 1000, 500);
Console.WriteLine(belinvest.GetTotalAmount());
belinvest.AddContrWithBon("Pavel", 10000, 300); 
belinvest.AddContrWithoutBon("Svetlna", 100010);
Console.WriteLine(belinvest.GetTotalAmount());

public class Bank
{
    private List<Contributor> contributors = new List<Contributor>();
    public void AddContrWithBon(string name, int value, int count)
    {
        Contributor newcon = new Contributor(name, value, count);
        contributors.Add(newcon);
    }
    public void AddContrWithoutBon(string name, int value)
    {
        Contributor newcon = new Contributor(name, value);
        contributors.Add(newcon);
    }

    public int GetTotalAmount()
    {
        int amount = 0;
        for (int i = 0; i < contributors.Count; i++)
        {
            amount += contributors[i].GetAmount();
        }
        return amount;
    }
}

public class Contributor
{
    public string Name { get; set; }
    private Bonus bon;
    public Contributor(string name, int val, int count = 0)
    {
        if (count != 0)
        {
            bon = new WithBonus(val, count);
        }
        else bon = new WithoutBonus(val);

        Name = name;
    }

    public int GetAmount()
    {
        return bon.Amount();
    }

}

public interface Bonus
{
    public int Amount();
}

public class WithBonus : Bonus
{
    private int value;
    private int amount;
    public WithBonus(int val, int count)
    {
        value = val;
        amount = count;
    }
    public int Amount()
    {
       return amount + value;
    }
}

public class WithoutBonus :Bonus
{
    private int value;

    public WithoutBonus(int val)
    {
        value = val;
    }

    public int Amount() { return value; }
}