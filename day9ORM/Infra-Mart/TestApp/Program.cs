using System.Collections.Generic;
using BOL;
using BLL;

List<Product> thelist=ProductManager.GetAllProductss();
if(thelist!=null)
{
    foreach(Product p in thelist)
    {
        Console.WriteLine("before insert Product ID: "+p.Pid+" Product Name: "+p.Pname);
    }
}
else
{
    Console.WriteLine("list Is empty");
}
bool status=ProductManager.Add(new Product(1,"jsw",76,"images/jswsteel.jpg",100000,"Steel"));
List<Product> prod=ProductManager.GetAllProductss();
foreach(Product p in prod)
{
    Console.WriteLine("After insert Product ID: "+p.Pid+" Product Name: "+p.Pname);
}