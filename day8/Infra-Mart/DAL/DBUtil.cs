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
            string conString=@"server=192.168.10.109;uid=dac46;pwd=welcome;database=dac46";
            con=new MySqlConnection(conString);
        }
        return con;
    }
}
