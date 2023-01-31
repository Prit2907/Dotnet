using System.Collections.Generic;
namespace CRM;
using OrderProcessing;
public class Customer
{
    public string Fname{set;get;}
    public string Lname{set;get;}
    public string MoNo{set;get;}
    public string Email{set;get;}
    public string Locn{set;get;}
    public DateTime DoB{set;get;}
    public List<Order> olist=new List<Order>(); 

    public void ShowOrder()
    {
        foreach(Order oprds in olist)
        {
            Console.WriteLine(oprds);
        }
    }
    public Customer(string Fname,string Lname,string MoNo,string Email,string Locn,DateTime DoB)
    {
        this.Fname=Fname;
        this.Lname=Lname;
        this.MoNo=MoNo;
        this.Email=Email;
        this.Locn=Locn;
        this.DoB=DoB;
    }
    public override string ToString()
    {
        return base.ToString()+"\nFirstName: "+Fname+" LastName: "+Lname;
    }
}
