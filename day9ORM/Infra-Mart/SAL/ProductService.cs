namespace SAL;
using BOL;
using BLL;

public class ProductService
{
    public List<Product> GetAllP()
    {
        
        return ProductManager.GetAllProductss();
    }
    public bool AddSerProduct(Product p)
    {
      
        return ProductManager.Add(p);
    } 
}
