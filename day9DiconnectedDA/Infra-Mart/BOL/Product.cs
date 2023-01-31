namespace BOL;
public class Product
{
    public int Pid{set;get;}
    public string Pname{set;get;}
    public double Price{set;get;}
    public string Imgurl{set;get;}
    public int Stock{set;get;}
    public string Category{set;get;}

    public Product(int Pid,String Pname,double Price,string Imgurl,int Stock,string Category)
    {
        this.Pid=Pid;
        this.Pname=Pname;
        this.Price=Price;
        this.Imgurl=Imgurl;
        this.Stock=Stock;
        this.Category=Category;
    }
}
