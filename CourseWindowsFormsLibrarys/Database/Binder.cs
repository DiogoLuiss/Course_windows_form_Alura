using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CourseWindowsFormsLibrarys.Database
{
    public class Binder
    {
        public string directory;
        public string message;
        public bool status;
        public Binder(string MyDirectory)
        {
            status = true;

            try
            {
                if (Directory.Exists(MyDirectory) == false)
                {
                    Directory.CreateDirectory(MyDirectory);
                }
                directory = MyDirectory;
                message = "Connexão com fichario realizada com sucesso em: " + directory;
            }
            catch (Exception Error)
            {
                status = false;
                message = "Connexão com fichario com erro: " + Error.Message;

            }

          
        }

        public void AddNewClient(string Id, string JsonUnit)
        {
            status = true;
            try
            {
                if (File.Exists(directory + "\\" + Id + ".json"))
                {
                    status =  false;
                    message = "Falha ao incluir o cliente, porque o Id: " + Id + " já existe!!";
                }
                else
                {
               
                    File.WriteAllText(directory + "\\" + Id + ".json", JsonUnit);
                    status = true;
                    message = "Inclusão realizada com sucesso para id: " + Id;
                }
            }
            catch (Exception Error)
            {

                throw new Exception(Error.Message);
            }


            }

        public string FindClient(string Id)
        {
            status = true;

            try
            {
                if (File.Exists(directory + "\\" + Id + ".json"))
                {
                    status = true;

                    return File.ReadAllText(directory + "\\" + Id + ".json");
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
                throw new Exception(Error.Message);
            }

        }

        public void DeleteClient(string Id)
        {
            status = true;


            try
            {
                if (File.Exists(directory + "\\" + Id + ".json"))
                {
                    status = true;
                    File.Delete(directory + "\\" + Id + ".json");
                }
                else
                {
                    status = false;
                    message = "cliente com id : " + Id + " não encontrado";
                  
                }

            }
            catch (Exception Error)
            {
                throw new Exception(Error.Message);
            }


        }

        public void UpdateClient(string Id, string JsonClient )
        {
            status = true;

            try
            {
                if (File.Exists(directory + "\\" + Id + ".json"))
                {
                    status = true;
                    File.WriteAllText(directory + "\\" + Id + ".json", JsonClient);
                }
                else
                {
                    status = false;
                    message = "cliente com id : " + Id + " não encontrado";

                }

            }
            catch (Exception Error)
            {
                throw new Exception(Error.Message);
            }
        }

        public List<string> FindAllClient()
        {
            status = true;
            List<string> AllClientsJson = new List<string>();

            try
            {
                var Files = Directory.GetFiles(directory, "*.json");

               
                    for (int i = 0; i < Files.Length; i++)
                    {

                        var JsonClient = File.ReadAllText(Files[i]);
                        AllClientsJson.Add(JsonClient);
                    }
                status = true;
                return AllClientsJson;
                 
            

            }
            catch (Exception Error)
            {
                status = false;
                throw new Exception(Error.Message);
            }

        }

    }
}
