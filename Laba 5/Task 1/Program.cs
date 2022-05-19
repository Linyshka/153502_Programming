Bank bank = new Bank();
bank.AddClient("Masha", Type.Vip);
bank.AddClient("Misha", Type.Usual);
List<Client> clients = bank.GetClients();
for(int i = 0; i < clients.Count; i++)
{
    Console.WriteLine(clients[i].GetName());
}

public enum Type
{
    Vip,
    Usual
}

public class Bank
{
    private List<Client> clientlist = new List<Client>();
    private List<Contribution> contrlist = new List<Contribution>();    
    public void AddClient(string name, Type type)
    {
        clientlist.Add(new Client(name, type));
    }

    public void AddContr(int con, int percent, string name)
    {
        for(int i = 0; i < clientlist.Count; i++)
        {
            if(clientlist[i].GetName() == name)
            {
                clientlist[i].AddContr(con, percent);
            }
        }
        contrlist.Add(new Contribution(con, percent));
    }

    public void ChangeContr(int con, string name)
    {
        for (int i = 0; i < clientlist.Count; i++)
        {
            if (clientlist[i].GetName() == name)
            {
                clientlist[i].ChangeContr(con);
            }
        }
    }

    public double GetTotalSum()
    {
        double res = 0;
        for(int i = 0; i < contrlist.Count; ++i)
            res += contrlist[i].GetSum();
        return res;
    }

    public List<Client> GetClients()
    {
        return clientlist;
    }

    public List<Contribution> GetContributions()
    {
        return contrlist;
    }

}

public class Contribution
{
    private int con;
    private int percent;
    public Contribution(int con_, int percent_)
    {
        this.con = con_;   
        this.percent = percent_;
    }
    public void CnahgeCon(int con_)
    {
        con = con_;
    }

    public int GetPercent() { 
        return percent;
    }

    public double GetSum()
    {
        return 0.01 * percent * con;
    }

    public int GetContribution()
    {
        return con;
    }
}

public class Client
{
    private bool contr = false;
    private string name;
    Contribution contribution;
    Type type;
    public Client(string name_, Type type_) {
        name = name_;
        type = type_;
    }

    public void AddContr(int con_, int percent_)
    {
        if (!contr)
        {
            contribution = new Contribution(con_, percent_);
            contr = true;
        }
        else Console.WriteLine("Вклад уже внесен");
    }

    public void ChangeContr(int con_)
    {
        if (contr)
            contribution.CnahgeCon(con_);
        else Console.WriteLine("Сначала внесите вклад"); 
    }

    public double GetSum()
    {
        return contribution.GetSum();
    }

    public string GetName()
    {
        return name;
    }

    public int GetPercent()
    {
        return contribution.GetPercent();
    }

    public Type GetType()
    {
        return type;
    }
}