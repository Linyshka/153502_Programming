public class Polinom
{
    private int a_;
    private int b_;
    private int c_;

    public int A
    {
        get { return a_; }
        set { a_ = value; }
    }

    public int B
    {
        get { return b_; }
        set { b_ = value; }
    }

    public int C
    {
        get { return c_; }
        set { c_ = value; }
    }
    public Polinom(int a, int b, int c)
    {
        Console.WriteLine("Объект создан");
        A = a;
        B = b;
        C = c;
    }

    public override string ToString()
    {
        return a_ + "x + " + b_ + "y + " + c_ + "z";  //+++++++++
    }

    public static Polinom operator +(Polinom polinom1, Polinom polinom2)
    {
        return new Polinom(polinom1.A + polinom2.A, polinom1.B + polinom2.B, polinom1.C + polinom2.C); //+++++++++++++++
    }

    public static Polinom operator -(Polinom polinom1, Polinom polinom2)
    {
        return new Polinom(polinom1.A - polinom2.A, polinom1.B - polinom2.B, polinom1.C - polinom2.C); //++++++++++++++++++
    }

    public static Polinom operator ++(Polinom polinom)
    {
        return new Polinom(polinom.A + 1, polinom.B + 1, polinom.C + 1); //+++++++++++
    }

    public static Polinom operator --(Polinom polinom)
    {
        return new Polinom(polinom.A - 1, polinom.B - 1, polinom.C - 1); //+++++++++++++++++
    }

    public static Polinom operator *(Polinom polinom, int q)
    {
        return new Polinom(polinom.a_ * q, polinom.b_ * q, polinom.c_ * q); //+++++++++++++++++
    }

    public static Polinom operator /(Polinom polinom, int q)
    {
        return new Polinom(polinom.a_ / q, polinom.b_ / q, polinom.c_ / q); //+++++++++++++++
    }

    public static bool operator ==(Polinom polinom1, Polinom polinom2)
    {
        return polinom1.a_ == polinom2 .a_ && polinom2.b_ == polinom1.b_ && polinom1.c_ == polinom2.c_; //++++++++++++++
    }

    public static bool operator !=(Polinom polinom1, Polinom polinom2)
    {
        return polinom1.a_ != polinom2.a_ && polinom2.b_ != polinom1.b_ && polinom1.c_ != polinom2.c_; //+++++++++++++++++++
    }

    public static bool operator false(Polinom polinom)
    {
        return polinom.a_ == 0 && polinom.b_ == 0 && polinom.c_ == 0; //+++++++++++++++
    }

    public static bool operator true(Polinom polinom)
    {
        return polinom.a_ != 0 || polinom.b_ != 0 || polinom.c_ != 0; //++++++++++++++++++++++
    }

    public static explicit operator int(Polinom polinom)
    {
        return (int) polinom.a_;
    }

    public static explicit operator Polinom(int a)
    {

        return (Polinom) new Polinom(a,a,a);
    } //++++++++++++++++++++
}

