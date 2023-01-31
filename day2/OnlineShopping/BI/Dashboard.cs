namespace BI;
public class Dashboard:ICustomerDetails,IOrderDetails
{
    void ICustomerDetails.ShowDetails()
    {
        Console.WriteLine("");
    }
    void IOrderDetails.ShowDetails()
    {
        Console.WriteLine("");
    }
    public void Show()
    {
        Console.WriteLine("in show..");
    }
}