namespace DAL;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

using System.Data;
using MySql.Data.MySqlClient;
using BOL;

public class ProductIOManager
{ 
    public bool Add(Product prd)
    {
        MySqlConnection con= DBUtil.GetMyconnection();
        con.Open();
         MySqlCommand cmd=new MySqlCommand();
        bool status=false;
        cmd.Connection=con;
        string query="insert into netproduct values("+prd.Pid+",'"+prd.Pname+"',"+prd.Price+",'"+prd.Imgurl+"',"+prd.Stock+",'"+prd.Category+"')";
        cmd.CommandText=query;
        cmd.ExecuteNonQuery();
        con.Close();
        return true;
    }
    public List<Product> GetAllProductss()
    {
      List<Product> plist=new List<Product>();
       MySqlConnection con= DBUtil.GetMyconnection();
        con.Open();
        MySqlCommand cmd=new MySqlCommand();
        cmd.Connection=con;
        string query="select * from netproduct";
        cmd.CommandText=query;
        MySqlDataReader read=cmd.ExecuteReader();
        while(read.Read())
        {
            int pid=int.Parse(read["pid"].ToString());
            string pname=read["pname"].ToString();
            double price=double.Parse(read["price"].ToString());
            string imgurl=read["imgurl"].ToString();
            int stock=int.Parse(read["stock"].ToString());
            string category=read["category"].ToString();
            Product p=new Product(pid,pname,price,imgurl,stock,category);
            plist.Add(p);
        }
        con.Close();
        return plist;
    }
}
