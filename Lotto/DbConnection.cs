using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Lotto
{
    class DbConnection
    {
        //Creating objects of classes
        OleDbCommand cmd = new OleDbCommand();
        OleDbConnection con = new OleDbConnection();

        public void Connect(String numbers)
        {
            //creating the link to the database for connection
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Manuel Lopes\Documents\Visual Studio 2015\Projects\Lotto\Lotto\LottoDB.accdb";
            cmd.Connection = con;
            try
            {
                con.Open();//openning the database connection
                String query = "Insert into BALLS_OUT (BALL_NUMBERS) values ('"+ numbers +"')";
                cmd.CommandText = query; //setting the command for the insert query
                cmd.ExecuteNonQuery();//executing the query;
                con.Close();//closing database connection

            }
            catch(Exception e)
            {
                MessageBox.Show("Unable to connect to the database", "Alert");//in case there's an error 
            }
        }
    }
}
