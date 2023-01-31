namespace Utility;
   public delegate double BankOps(double balance);
public static class Handler
{
   static double bal;
    public static double PayIncomeTax(double balance)
    {
        bal=balance-balance*(0.15);
        // Console.WriteLine("Balance After Tax Deduction"+bal);
        return bal;    
    }

    public static double SendEmail(double balance)
    {
        if(balance>5000)
        {
            Console.WriteLine("In Email,You have exceeded your deposite limit");
        }
        else
        {
            Console.WriteLine("In Email,Balance not enough");
        }
        return bal;
    }

    public static double SendSms(double balance)
    {
        if(balance>5000)
        {
            Console.WriteLine("In Email,You have exceeded your deposite limit");
        }
        else
        {
            Console.WriteLine("In sms,Balance not enough");
        }
        return bal;
    }

    public static double BlockAccount(double balance)
    {
            Console.WriteLine("Balance "+balance+" not enough,Your ac is blocked");
            return balance;
    }

    // public static double PayServiceTax()
    // {

    // }
}