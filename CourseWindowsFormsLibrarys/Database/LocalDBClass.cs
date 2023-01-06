using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWindowsFormsLibrarys.Database
{
    public class LocalDBClass
    {
        public string StringConnection;
        public SqlConnection ConnectionDB;

        public LocalDBClass()
        {
            try
            {
                StringConnection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database\\Binder.mdf;Integrated Security=True";
                //String de conexão
                ConnectionDB = new SqlConnection(StringConnection); //criando conexão

                ConnectionDB.Open();//abrindo conexão

            }
            catch (Exception Error )
            {

                throw new Exception(Error.Message);
            }


        }

        public DataTable SQLQuery(string SQL) //Tabela em memoria, metodo para buscar dados
        {

            DataTable dt = new DataTable(); //crio a tabela

            try
            {
                var MyCommand = new SqlCommand(SQL, ConnectionDB); //criando comando passando conexão e o comando
                MyCommand.CommandTimeout = 0;//tempo limite da conexão

                var MyReader = MyCommand.ExecuteReader(); // Executar comando

                dt.Load(MyReader); //adiciono o conteudo a tabela

            }
            catch (Exception Error)
            {

                throw new Exception(Error.Message);
            }

            return dt; //caso tudo de certo, retorno dt com a adição que foi feita.

        }

        public string SQLCommand(string SQL) // metodo para atualizar, deletar ou criar dados
        {
            try
            {
                var MyCommand = new SqlCommand(SQL, ConnectionDB); //criando comando passando conexão e o comando
                MyCommand.CommandTimeout = 0;//tempo limite da conexão

                var MyReader = MyCommand.ExecuteReader(); // Executar comando

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
