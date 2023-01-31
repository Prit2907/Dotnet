namespace OrderProcessing;
public class Order
{
    public int Oid{set;get;}
    public string Status{set;get;}
    public DateTime Odate{set;get;}
    public double Tamount{set;get;}

    public Order(int Oid,string Status,DateTime Odate,double Tamount)
    {
        this.Oid=Oid;
        this.Status=Status;
        this.Odate=Odate;
        this.Tamount=Tamount;
    }
    public override string ToString()
    {
        return base.ToString()+"\nOID: "+Oid+" Status: "+Status+" Odate: "+Odate+"Toatal: "+Tamount;
    }
}

