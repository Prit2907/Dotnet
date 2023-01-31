namespace Maths;
public class Complex
{
    public int Real{get;set;}
    public int Img{get;set;}
    public Complex()
    {
        this.Real=this.Img=0;
    }
    public Complex(int Real,int Img)
    {
        this.Real=Real;
        this.Img=Img;
    }
    public static Complex operator+(Complex c1,Complex c2)
    {
        Complex temp=new Complex();
        temp.Real=c1.Real+c2.Real;
        temp.Img=c1.Img+c2.Img;
        return temp;
    }
    public override string ToString()
    {
        return this.Real+"+"+this.Img+"i";
    }
}