namespace EmployeeDetails;
public class Employee:Person{
    
    public int Id{get;set;}
    public double Da{get;set;}
    public double Salary{get;set;}
    public double Hra{get;set;}
    public double Pf{get;set;}
    public Employee():base()
    {
        this.Id=1;
        this.Da=1000;
        this.Salary=60000;
        this.Hra=5000;
        this.Pf=3000;
    }
    public Employee(string fname,string lname,DateTime dob,int id,double da,double salary,double hra,double pf)
    :base(fname,lname,dob) 
    {
        this.Id=id;
        this.Da=da;
        this.Salary=salary;
        this.Hra=hra;
        this.Pf=pf;
    }

    public virtual double ClaculateSalary()
    {
        double salary=this.Salary+this.Da+this.Hra-this.Pf;
        return salary;
    }
    public override string ToString()
    {
        return base.ToString()+"\nID: "+this.Id+" DA: "+this.Da+" SALARY: "+this.Salary+" HRA: "+this.Hra+" PF: "+this.Pf+"\nInHand Salary: "+this.ClaculateSalary();
    }
}