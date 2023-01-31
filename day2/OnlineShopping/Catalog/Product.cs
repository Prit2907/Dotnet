namespace Catalog;
public class Product
{
    public string Pname{get;set;}
    public int Pid{get;set;}
    public int Qty{get;set;}
    public double Price{get;set;}

    public Product()
    {
        this.Pid=1;
        this.Pname="bottle";
        this.Price=200;
        this.Qty=1;
    }
    public Product(string Pname,int Pid,int Qty,double Price)
    {
        this.Pid=Pid;
        this.Pname=Pname;
        this.Qty=Qty;
        this.Price=Price;
    }
    public override string ToString()
    {
        return base.ToString()+"\nPID: "+Pid+" Product Name: "+Pname+" Qty: "+Qty+" Price: "+Price;
    }

}
