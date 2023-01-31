namespace BLL;
using BOL;
using DAL;
public class ProductManager
{
    public static ProductManager instance=null;

    private ProductManager()
    {

    }
    public static ProductManager GetManager()
    {
        if(instance==null)
        {
            instance=new ProductManager();
        }
        return instance;
    }
    public List<Product> GetAllProducts()
    {
        ProductIOManager iomgr=new ProductIOManager();
        return iomgr.GetAllProductss();        
    }
    public bool AddNewProduct(Product p)
    {
        ProductIOManager iomgr=new ProductIOManager();
        return iomgr.Add(p);
    }
}
