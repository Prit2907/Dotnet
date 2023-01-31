namespace DAL;
using System.Data;
using MySql.Data.MySqlClient;

public class DBUtil
{
    static MySqlConnection con=null;

    public static MySqlConnection GetMyconnection()
    {
        if(con==null)
        {
            string conString=@"server=127.0.0.1;uid=root;pwd=;database=pritam";
            con=new MySqlConnection(conString);
        }
        return con;
    }
}
