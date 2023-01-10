using Npgsql;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWindowsFormsLibrarys.Database
{
    public class LocalDB_Postgres
    {
        public string StringConnection;
        public NpgsqlConnection ConnectionDB;

     public   LocalDB_Postgres()
        {
            try
            {
                StringConnection = "Server=localhost;port=5432;User id=postgres;Password=minhasenha;Database=CursoCsharp;";

                ConnectionDB = new NpgsqlConnection(StringConnection);
           
                ConnectionDB.Open();

            }
            catch (Exception Error)
            {

                throw new Exception(Error.Message);
            }
        }



        public List<string> SQLQuery(string SQL,bool AllClients = false) //Tabela em memoria, metodo para buscar dados
        {
            List<string> dt = new List<string>();
            try
            {

                NpgsqlCommand NpgsqlCommand = new NpgsqlCommand(SQL, ConnectionDB);
                NpgsqlDataReader MyReader = NpgsqlCommand.ExecuteReader();
 
                    while (MyReader.Read())
                    {
                        dt.Add(MyReader.GetString(0));
                      
                    }

                Close();
            }
            catch (Exception Error)
            {

                throw new Exception(Error.Message);
            }

            return dt;

        }
        public string SQLCommand(string SQL)
        {
            try
            {

                var dataSource = NpgsqlDataSource.Create(StringConnection);

                var cmd = dataSource.CreateCommand(SQL);
                cmd.ExecuteNonQueryAsync();

                Close();
                return "";

            }
            catch (Exception Error)
            {

                throw new Exception(Error.Message);
            }
        }

        public void Close()
        {
            ConnectionDB.Close();
        }



    }
}
