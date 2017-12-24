using System.Data.SQLite;
using System;
using System.Data;
public class DB
{
    public static void init()
    {

    }
    public static void signin(string name,string password)
    {
        try
        {
            
            SQLiteConnection conn = new SQLiteConnection("Data Source=magrsys.db;");
            conn.Open();
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO user VALUES('" + name + "','" + password + "')";
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
                reader.Close();
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
    public static string select(string string1,string string2,string string3,string string4 )
    {
        try
        {
            string revalue;
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=magrsys.db;"))
            {
                conn.Open();
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = string.Format("select {0} from {1} where {2} = '{3}'", string1, string2, string3, string4);
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        revalue = reader[0].ToString();
                        reader.Close();// 这个地方记得要关  要不然会有死锁现象
                        conn.Close();
                        return revalue;
                    }
                    else { return "exit"; }
                }
                    

            }
                 
        }
        catch (Exception ex)
        {
            return "exit";

        }
    }
    public static int delete(string string1, string string2, string string3)
    {
        try
        {
            
            SQLiteConnection conn = new SQLiteConnection("Data Source=magrsys.db;");
            conn.Open();
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = string.Format("delete from {0} where {1} = '{2}' ", string1, string2, string3);
            //cmd.CommandText = "DELETE FROM stu where 学号 = '12345'";
            cmd.ExecuteNonQuery();
            conn.Close();
            return 1;

        }
        catch (Exception ex)
        {
            return 0;
            

        }
    }
    public static int insert(string string1, string string2, string string3, string string4,string string5,string string6)//不能插入学号相同的
    {
        try
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=magrsys.db;"); conn.Open();
            SQLiteCommand cmd = conn.CreateCommand();

            cmd.CommandText = string.Format("INSERT INTO stu VALUES('{0}','{1}','{2}','{3}','{4}','{5}')",string1,string2,string3,string4,string5,string6);
            cmd.ExecuteNonQuery();
            conn.Close();
            return 1;
        }
        catch (Exception ex)
        {
           return 0;

        }
    }
    public static int update(string string1, string string2, string string3,string string4,string string5, string string6)//不能插入学号相同的
    {
        try
        {
            SQLiteConnection conn1 = new SQLiteConnection("Data Source=magrsys.db;");
            conn1.Open();
            SQLiteCommand cmd1 = conn1.CreateCommand();

            cmd1.CommandText = string.Format("UPDATE stu SET 姓名 = '{1}',性别 = '{2}',出生日期 = '{3}',班级号 = '{4}', 总学分 = '{5}' WHERE 学号 = '{0}' ",string1,string2, string3, string4, string5, string6);
            cmd1.ExecuteNonQuery();
            conn1.Close();
            return 1;
        }
        catch (Exception ex)
        {
            return 0;

        }
    }


}