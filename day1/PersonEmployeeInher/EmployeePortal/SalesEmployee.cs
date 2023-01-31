namespace EmployeeDetails;
public sealed class SalesEmployee:Employee
{
    public double Incentive{get;set;}
    public double Target{get;set;}
    public double Revenue{get;set;}

    public SalesEmployee()
    {
        this.Incentive=2000;
        this.Target=50000;
        this.Revenue=60000;
    }
    public SalesEmployee(string fname,string lname,DateTime dob,int id,double da,double salary,double hra,double pf,double incentive,double target,double revenue)
    :base(fname,lname,dob,id,da,salary,hra,pf)
    {
        this.Incentive=incentive;
        this.Target=target;
        this.Revenue=revenue;
    }
    public override double ClaculateSalary()
    {
        double salary=base.ClaculateSalary();
        if(Revenue>Target)
        {
            salary+=Incentive;
        }
        return salary;
    }
    public override string ToString()
    {
        return base.ToString()+"\nINCENTIVE: "+this.Incentive+" TARGET: "+this.Target+" REVENUE :"+Revenue;
    }
}