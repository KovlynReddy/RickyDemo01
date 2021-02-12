using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace RickyAppDLL.SQLConnection
{
    class RickyDBConnection { 
    //{
    //    // get connection string
    //    public static string GetConnectionString(string name = "AlphaWSMDB")
    //    {

    //        return ConfigurationManager.ConnectionStrings[name].ConnectionString;
    //    }  

    //    // add object
    //    public static void SaveData<T>(string sql, T data)
    //    {
    //        using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
    //        {

    //            cnn.Execute(sql, data);
    //        }

    //    }

    //    public static void DeleteData<T>(string sql)
    //    {
    //        using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
    //        {

    //            cnn.Execute(sql);
    //        }

    //    }

    //    // load all objects
    //    public static List<T> LoadData<T>(string sql)
    //    {

    //        using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
    //        {

    //            return cnn.Query<T>(sql).ToList();
    //        }

    //    }

    //    // search for an object

    //    public static List<T> FindData<T>(string sql)
    //    {
    //        using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
    //        {


    //            return cnn.Query<T>(sql).ToList();
    //        }

    //    }



    //    // search over 2 params


    //    public static void UpdateData<T>(string sql)
    //    {
    //        using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
    //        {

    //            cnn.Execute(sql);
    //        }

    //    }

    }
}
