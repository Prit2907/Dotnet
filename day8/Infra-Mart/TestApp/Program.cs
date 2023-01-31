using System.Collections.Generic;
using BOL;
using DAL;

ProductIOManager iomgr=new ProductIOManager();
List<Product> thelist=iomgr.GetAllProductss();
foreach(Product p in thelist)
{
    Console.WriteLine("before insert Product ID: "+p.Pid+" Product Name: "+p.Pname);
}
bool status=iomgr.Add(new Product(1,"JSW",76,"images/jswsteel.jpg",10000,"Steel"));
List<Product> prod=iomgr.GetAllProductss();
foreach(Product p in prod)
{
    Console.WriteLine("After insert Product ID: "+p.Pid+" Product Name: "+p.Pname);
}