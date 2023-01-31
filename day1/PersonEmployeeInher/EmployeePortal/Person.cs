namespace EmployeeDetails;
public class Person
{
    private string fname;
    private string lname;
    private DateTime dob;

    public Person()
    {
        this.fname="Pritam";
        this.lname="Patil";
        this.dob=new DateTime(1999,07,29);
    }
    public Person(string fname,string lname,DateTime dob)
    {
        this.fname=fname;
        this.lname=lname;
        this.dob=dob;
    }
    public void SetFname(string fname)
    {
        this.fname=fname;
    }
    public string GetFname()
    {
        return this.fname;
    }
    public void SetLname(string lname)
    {
        this.lname=lname;
    }
    public string GetLname()
    {
        return this.lname;
    }
    public DateTime Dob {get;set;}

    public override string ToString()
    {
        return "first name: "+fname+" last name: "+lname+" DOB :"+dob;
    }

}