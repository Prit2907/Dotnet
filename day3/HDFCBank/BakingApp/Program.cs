using Utility;
using Banking;
int choice=0;
Account ac=null;

do
{
    Console.WriteLine("1.Create Account\n2.Deposite Amt\n3.Withdraw Amt\n4.Ministatement\n5.Exit");
    Console.WriteLine("Enter your choice:");
    // string num=Console.ReadLine();
    choice=Convert.ToInt32(Console.ReadLine());//(num)
    switch(choice)
    {
        case 1:
            Console.WriteLine("\ta.Enter User Name:");
            string name=Console.ReadLine();
            Console.WriteLine("\n\tb.Opening Account Balance:");
            
            double balance=Convert.ToDouble(Console.ReadLine());
            ac=new Account(name,balance);
            Console.WriteLine("Account : "+ac+"\nCreated Successsfully\n");
            break;
        case 2:
            Console.WriteLine("Enter amount you want to deposit:");
            double amt=Convert.ToDouble(Console.ReadLine());
            
            ac.overbalance+=new BankOps(Handler.PayIncomeTax);
            ac.overbalance+=new BankOps(Handler.SendEmail);
            ac.overbalance+=new BankOps(Handler.SendSms);
            ac.Deposit(amt);
            ac.overbalance-=new BankOps(Handler.PayIncomeTax);
            ac.overbalance-=new BankOps(Handler.SendEmail);
            ac.overbalance-=new BankOps(Handler.SendSms);
            break;
        case 3:
            Console.WriteLine("Enter amount you want to withdraw:");
            amt=Convert.ToDouble(Console.ReadLine());
            ac.underbalance+=new BankOps(Handler.BlockAccount);
            ac.underbalance+=new BankOps(Handler.SendEmail);
            ac.underbalance+=new BankOps(Handler.SendSms);
            ac.Withdraw(amt);
            ac.underbalance-=new BankOps(Handler.BlockAccount);
            ac.underbalance-=new BankOps(Handler.SendEmail);
            ac.underbalance-=new BankOps(Handler.SendSms);
            break;
        case 4:
           
           ac.Ministatement();

            break;
        case 5:
        Console.WriteLine("Exit");
            break;
    }
}while(choice!=5);