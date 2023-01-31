namespace BLL;
using System.Collections.Generic;

using System.Data;
using DAL;
using BOL;

public static class ProductManager
{ 
    public static bool Add(Product prd)
    {
        bool status=false;
        CollectionContext ctx=new CollectionContext();
        ctx.Netproduct.Add(prd);
        ctx.SaveChanges();

        status=true;
        return status;
    }
    public static List<Product> GetAllProductss()
    {
        CollectionContext ctx=new CollectionContext();
        var products=from product in ctx.Netproduct select product;
        return products.ToList<Product>();
    }
}
