namespace Banking;
using Utility;
public class Account
{
    public event BankOps overbalance;
    public event BankOps underbalance;
    private static int AcNo=0;

    public string Uname{set;get;}

    public double Balance{set;get;}
    static double amt=0;
    

    

    public Account(string Uname,double Balance)
    {
        AcNo++;
        this.Uname=Uname;
        this.Balance=Balance;
        amt=Balance;
    }
    
    
    public void Deposit(double amt)
    {   
        
        this.Balance+=amt;
        if(this.Balance>300000)
        {
           this.Balance=overbalance(this.Balance);
        }
        Console.WriteLine("your Balance: "+this.Balance);
    }
    public void Withdraw(double amt)
    {
        this.Balance-=amt;
        if(this.Balance<5000)
        {
            underbalance(this.Balance);
        }
        Console.WriteLine("your Balance: "+this.Balance);
    }
    public override string ToString()
    {
        return base.ToString()+"Ac Number: "+AcNo+" User Name: "+this.Uname+" Balance: "+this.Balance;
    }
    public void Ministatement(){
        
        Console.WriteLine("old Balance"+amt);
        Console.WriteLine("Current Balace"+this.Balance);
    }

}