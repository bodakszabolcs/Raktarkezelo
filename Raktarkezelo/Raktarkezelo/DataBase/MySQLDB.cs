using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration.Assemblies;
using System.Configuration;
using System.Windows.Forms;

namespace Raktarkezelo.DataBase
{
    class MySQLDB
    {   

    public MySqlConnection connection;
    private string server;
    private string database;
    private string uid;
    private string password;

    //Constructor
    public MySQLDB()
    {
        server = Properties.Settings.Default.DB_HOST;
        database = Properties.Settings.Default.DB_DATABASE;
        uid = Properties.Settings.Default.DB_USER;
        password = Properties.Settings.Default.DB_PWD;
        string connectionString;
        connectionString = "SERVER=" + server + ";" + "DATABASE=" +
        database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";Convert Zero Datetime=True";

        connection = new MySqlConnection(connectionString);
    }

   

    //open connection to database
      public bool OpenConnection()
      {
            try
        {
            connection.Open();
            return true;
        }
        catch (MySqlException ex)
        {
            //When handling errors, you can your application's response based 
            //on the error number.
            //The two most common error numbers when connecting are as follows:
            //0: Cannot connect to server.
            //1045: Invalid user name and/or password.
            switch (ex.Number)
            {
                case 0:
                    MessageBox.Show("Cannot connect to server.  Contact administrator");
                    break;

                case 1045:
                    MessageBox.Show("Invalid username/password, please try again");
                    break;
            }
            return false;
        }
    }

    //Close connection
    public bool CloseConnection()
    {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
    }

    //Insert statement
    public void Insert(string query)
    {
        try
        {
            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }

    }

    //Update statement
    public void Update(string query)
    {
         

        //Open connection
        if (this.OpenConnection() == true)
        {
            //create mysql command
            MySqlCommand cmd = new MySqlCommand();
            //Assign the query using CommandText
            cmd.CommandText = query;
            //Assign the connection using Connection
            cmd.Connection = connection;

            //Execute query
            cmd.ExecuteNonQuery();

            //close connection
            this.CloseConnection();
        }
    }

    //Delete statement
    public void Delete(string query)
    {
     

        if (this.OpenConnection() == true)
        {
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            this.CloseConnection();
        }
    }

    //Select statement
  /*  public List <string> [] Select()
    {
    }*/

    //Count statement
    public int Count(string TableName, string where)
    {
        try
        {
            string query = "SELECT Count(*) FROM " + TableName + where;
            int Count = 0;

            //Open Connection
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //ExecuteScalar will return one value
                Count = int.Parse(cmd.ExecuteScalar() + "");

                //close Connection
                this.CloseConnection();

                return Count;
            }
            else
            {
                return Count;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
            this.CloseConnection();
            return 0;
        }
    }
        public BindingSource GetDataGried(string query)
        {
                    MySqlDataAdapter MyDA = new MySqlDataAdapter();
                    MyDA.SelectCommand = new MySqlCommand(query, connection);
                    System.Data.DataTable table = new System.Data.DataTable();
                    try
                    {

                        MyDA.Fill(table);

                      
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        this.CloseConnection();
                        return null;
                    }
                    BindingSource bSource = new BindingSource();
                    bSource.DataSource = table;
                    this.CloseConnection();
            return  bSource;

    
      }
        public System.Data.DataTable selectTable(string query)
        {
            MySqlDataAdapter MyDA = new MySqlDataAdapter();
            MyDA.SelectCommand = new MySqlCommand(query, connection);
            System.Data.DataTable table = new System.Data.DataTable();
            try
            {

                MyDA.Fill(table);
                this.CloseConnection();
                return table;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.CloseConnection();
                return null;
                
            }
            
        }

   

    }
}
