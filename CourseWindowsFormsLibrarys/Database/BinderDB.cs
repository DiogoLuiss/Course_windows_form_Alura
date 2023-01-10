using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWindowsFormsLibrarys.Database
{
    public class BinderDB
    {
        public string message;
        public bool status;
        string TableName;
        LocalDB_Postgres DB;


        public BinderDB(string Table)
        {

            status = true;

            try
            {
                DB = new LocalDB_Postgres();
                TableName = Table;
                message = "Conexão com a tabela realizada com sucesso!!";

            }
            catch (Exception Error)
            {
                status = false;
                message = "Erro ao tentar se comunicar com a tabela: " + Error.Message;
           
            }

        }

        public void InsertClient(string Id,string json)
        {
            status = true;
            try
            {
                string SQL = $"insert into {this.TableName} (Id,JSON) values ('{Id}','{json}')";

                DB.SQLCommand(SQL);
                status = true;
                message = "Inclusão realizada com sucesso para id: " + Id;


            }
            catch (Exception Error)
            {
                status = false;
                message = "Erro ao tentar se comunicar com a tabela: " + Error.Message;

            }
        }


        public string FindClient(string Id)
        {
            status = true;

            try
            {
                string SQL = $"select json from {TableName} where ID = {Id}";

                var DateClient = DB.SQLQuery(SQL);

                if (DateClient[0] != "" )
                {
                    return DateClient[0]    ;
                }
                else
                {
                    status = false;
                    message = "cliente com id : " + Id + " não encontrado";
                    return "";
                }

            }
            catch (Exception Error)
            {
                status = false;
                message = "Erro ao tentar se comunicar com a tabela: " + Error.Message;
                return "";
            }

        }

        public List<string> FindAllClients()
        {
            status = true;
            List<string> AllClientsJson = new List<string>();
            try
            {
                string SQL = $"select JSON from {TableName}";

                var DateClient = DB.SQLQuery(SQL,true);

                for (int i = 0; i < DateClient.Count; i++)
                {
                    var JsonClient = DateClient[i].ToString();
                    AllClientsJson.Add(JsonClient);
                }
                status = true;
                return AllClientsJson;

            }
            catch (Exception Error)
            {
                status = false;
                message = "Erro ao tentar se comunicar com a tabela: " + Error.Message;
                return AllClientsJson;
            }

        }

        public  void UpdateClient (string Id ,  string ClientJson)
        {
            status = true;

            try
            {

                string SQL = $"update {TableName} set JSON = '{ClientJson}' where ID = '{Id}'";
                var DateClient = DB.SQLCommand(SQL);

            }
            catch (Exception Error)
            {
                throw new Exception(Error.Message);
            }
        }

        public void DeleteClient(string Id)
        {
            status = true;

            try
            {
             
                    string SQLDELETE = $"delete from {TableName} where ID = '{Id}'";

                    DB.SQLCommand(SQLDELETE);
                    status = true;

            }
            catch (Exception Error)
            {
                status = false;
                message = "Erro ao tentar se comunicar com a tabela: " + Error.Message;
            }

        }


    }
}
