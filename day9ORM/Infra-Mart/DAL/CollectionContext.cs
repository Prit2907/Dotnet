namespace DAL;
using BOL;
using Microsoft.EntityFrameworkCore;

public class CollectionContext:DbContext
{
    public DbSet<Product> Netproduct{get;set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string conString=@"server=127.0.0.1;uid=root;pwd=;database=pritam";
        optionsBuilder.UseMySQL(conString);
    }
}