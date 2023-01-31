namespace DAL;
using System.Collections.Generic;

using System.Data;

using MySql.Data.MySqlClient;
using BOL;

public class ProductIOManager
{ 
    public bool Add(Product prd)
    {
        MySqlConnection con= DBUtil.GetMyconnection();
        MySqlCommand cmd=new MySqlCommand();
        bool status=false;
        cmd.Connection=con;
        string query="insert into netproduct values("+prd.Pid+",'"+prd.Pname+"',"+prd.Price+",'"+prd.Imgurl+"',"+prd.Stock+",'"+prd.Category+"')";
        cmd.CommandText=query;
        MySqlDataAdapter da=new MySqlDataAdapter(cmd);
        DataSet ds=new DataSet();
        da.Fill(ds);
        DataTable dt=ds.Tables[0];
        DataRowCollection rows=dt.Rows;
        MySqlCommandBuilder cb=new MySqlCommandBuilder(da);
        DataRow theRow=dt.NewRow();
        theRow["pid"]=prd.Pid;
        theRow["pname"]=prd.Pname;
        theRow["price"]=prd.Price;
        theRow["imgurl"]=prd.Imgurl;
        theRow["stock"]=prd.Stock;
        theRow["category"]=prd.Category;
       
        rows.Add(theRow);
        da.Update(ds);
        
        return true;
    }
    public List<Product> GetAllProductss()
    {
      List<Product> plist=new List<Product>();
       MySqlConnection con= DBUtil.GetMyconnection();
        MySqlCommand cmd=new MySqlCommand();
        cmd.Connection=con;
        string query="select * from netproduct";
        cmd.CommandText=query;
        MySqlDataAdapter da=new MySqlDataAdapter(cmd);
        DataSet ds=new DataSet();
        da.Fill(ds);
        DataTable dt=ds.Tables[0];
        DataRowCollection rows=dt.Rows;
        foreach(DataRow row in rows)
        {
            int pid=int.Parse(row["pid"].ToString());
            string pname=row["pname"].ToString();
            double price=double.Parse(row["price"].ToString());
            string imgurl=row["imgurl"].ToString();
            int stock=int.Parse(row["stock"].ToString());
            string category=row["category"].ToString();
            Product p=new Product(pid,pname,price,imgurl,stock,category);
            plist.Add(p);
        }
        return plist;
    }
}
