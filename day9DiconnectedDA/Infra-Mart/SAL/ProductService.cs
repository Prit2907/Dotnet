namespace SAL;
using BOL;
using BLL;

public class ProductService
{
    public List<Product> GetAllP()
    {
        ProductManager mgr=ProductManager.GetManager();
        return mgr.GetAllProducts();
    }
    public bool AddSerProduct(Product p)
    {
        ProductManager mgr=ProductManager.GetManager();
        return mgr.AddNewProduct(p);
    } 
}
