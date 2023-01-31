using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using InfraStore.Models;
using System.Collections.Generic;

namespace InfraStore.Controllers;
using SAL;
using BOL;
public class ItemsController : Controller
{
    private readonly ILogger<ItemsController> _logger;

    public ItemsController(ILogger<ItemsController> logger)
    {
        _logger = logger;
    }


    [HttpGet]
    public IActionResult Index()
    {
        ProductService ps=new ProductService();
        List<Product> product=ps.GetAllP();
        this.ViewData["products"]=product;
        return View();
    }

   /*  public IActionResult Product(int id,string pname,double uprice,string imageurl,string stock)
    {
        Boolean status=true;
        if(status)
        {
            return RedirectToAction("Added","Items");
        }
        return View();
    } */

    public IActionResult Added()
    {
        return View();
    }
    
    [HttpGet]
    public IActionResult Insert(){
        return View();
    }
    [HttpPost]
    public IActionResult Insert(int Pid,string Pname,double Price,string Imgurl,int Stock,string Category)
    {
        ProductService ps=new ProductService();
        
        Product p=new Product(Pid,Pname,Price,Imgurl,Stock,Category);
        
        Boolean status=ps.AddSerProduct(p); 
        if(status)
        {
            return RedirectToAction("Index","Items");
        }
        return View();
    }

    [HttpGet]
    public IActionResult ViewProduct(int id){
        ProductService ps=new ProductService();
        List<Product> allproduct=ps.GetAllP();
        foreach(Product p in allproduct)
        {
            if(p.Pid==id)
            {
                Product pfound=p;
                ViewData["prod"]=pfound;
            }
        }
        
        return View();
    }
    public IActionResult Delete(){
         return View();
    }

    public IActionResult Update(){
        return View();
    }
   
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
