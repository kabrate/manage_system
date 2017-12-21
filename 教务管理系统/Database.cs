using System.Data.SQLite;
using System;
public class DB
{
    public static void init()
    {

    }
    public static void signin(string name,string password)
    {
        try
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=magrsys.db;"); conn.Open();
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO user VALUES('" + name + "','" + password + "')";
            //cmd.CommandText = "INSERT INTO user VALUES('karate','654321')";
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        catch(Exception ex)
        {
            
        }
    }
    public static string signup(string name)//拼接化查询
    {
        
        try
        {
            string password;
            SQLiteConnection conn = new SQLiteConnection("Data Source=magrsys.db;"); conn.Open();
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select 密码 from user where 用户名 ='" + name +"'" ;
            SQLiteDataReader reader = cmd.ExecuteReader();
            if(reader.Read())
            {
                password = reader["密码"].ToString();
                conn.Close();
                return password;
            }
            else { return "exit"; }
        }
        catch (Exception ex)
        {
            return "exit";

        }
    }

}