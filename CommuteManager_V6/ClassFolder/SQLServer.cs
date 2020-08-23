using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

class SQLServer
{
    public SqlConnection connection;
    public SqlCommand Command;
    public SqlDataReader sdr;

    

    public SQLServer()
    {
        SqlConnectionStringBuilder cb = new SqlConnectionStringBuilder();
        cb.DataSource = "rncl.database.windows.net";
        cb.UserID = "rnclthot";
        cb.Password = "*nameless422";
        cb.InitialCatalog = "DBRNCL";
        connection = new SqlConnection(cb.ConnectionString);
        connection.Open();
    }

    public void SQLUpload(string strqry)
    {
        try
        {
            if (connection.State == ConnectionState.Closed) connection.Open();
            Command = new SqlCommand(strqry, connection);
            Command.ExecuteNonQuery();
        }
        catch
        {
            
        }
        
        
        

    }

    public void GetDBTable(string strqry)
    {
        try
        {
            if (connection.State == ConnectionState.Closed) connection.Open();
            SqlCommand Comm = new SqlCommand(strqry, connection);
            sdr = Comm.ExecuteReader();
        }
        catch
        {

        }
    }

    public void SQLClose()
    {
        connection.Close();
    }

}
