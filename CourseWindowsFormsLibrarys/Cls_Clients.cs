using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using CourseWindowsFormsLibrarys.ClientCep;
using Newtonsoft.Json;
using CourseWindowsFormsLibrarys.Database;
using System.Windows.Forms;
using System.Collections.Specialized;

namespace CourseWindowsFormsLibrarys
{
    public class Cls_Clients
    {
        public class Unit
        {

            [Required(ErrorMessage = "Campo Código é obrigatório")]
            [RegularExpression("([0-9]+)", ErrorMessage = "Código do Cliente deve conter somente valores numericos")]
            [StringLength(6, MinimumLength = 6, ErrorMessage = "Código deve conter 6 digitos")]
            public string Id { get; set; }

            [Required(ErrorMessage = "Campo Nome é obrigatório")]
            [StringLength(50, ErrorMessage = "Campo nome deve conter no maximo 50 digitos")]
            public string Name { get; set; }

            [StringLength(50, ErrorMessage = "Nome do pai deve conter no maximo 50 digitos")]
            public string NameFather { get; set; }

            [Required(ErrorMessage = "Campo Nome da mãe é obrigatório")]
            [StringLength(50, ErrorMessage = "Campo Nome da mãe deve conter no maximo 50 digitos")]
            public string NameMother { get; set; }

            public bool NoHaveFather { get; set; }

            [Required(ErrorMessage = "Campo CPF é obrigatório")]
            [RegularExpression("([0-9]+)", ErrorMessage = "Campo CPF deve conter somente valores numericos")]
            [StringLength(11, MinimumLength = 11, ErrorMessage = "CPF deve conter 11 digitos")]
            public string CPF { get; set; }

            [Required(ErrorMessage = "Campo gênero é obrigatório")]
            public int Genere { get; set; }

            [Required(ErrorMessage = "Campo CEP é obrigatório")]
            [RegularExpression("([0-9]+)", ErrorMessage = "Campo CEP deve conter somente valores numericos")]
            [StringLength(8, MinimumLength = 8, ErrorMessage = "CEP deve conter 8 digitos")]
            public string CEP { get; set; }

            [Required(ErrorMessage = "Campo Logradouro é obrigatório")]
            [StringLength(50, ErrorMessage = "Campo Logradouro deve conter no maximo 50 digitos")]
            public string Logradouro { get; set; }

            [StringLength(50, ErrorMessage = "Campo complemento deve conter no maximo 50 digitos")]
            public string Complement { get; set; }

            [Required(ErrorMessage = "Campo bairro é obrigatório")]
            [StringLength(50, ErrorMessage = "Campo bairro deve conter no maximo 50 digitos")]
            public string Neighborhood { get; set; }

            [Required(ErrorMessage = "Campo cidade é obrigatório")]
            [StringLength(50, ErrorMessage = "Campo cidade deve conter no maximo 50 digitos")]
            public string City { get; set; }

            [Required(ErrorMessage = "Campo estado é obrigatório")]
            [StringLength(50, ErrorMessage = "Campo estado deve conter no maximo 50 digitos")]
            public string State { get; set; }

            [Required(ErrorMessage = "Campo telefone é obrigatório")]
            [StringLength(50, ErrorMessage = "Campo telefone deve conter no maximo 50 digitos")]
            public string Tel { get; set; }
            public string Profession { get; set; }

            [Required(ErrorMessage = "Campo renda familiar é obrigatório")]
            [Range(0, double.MaxValue, ErrorMessage = "")]
            public Double FamilyIncome { get; set; }

            public void ValidateClass()
            {
                ValidationContext context = new ValidationContext(this, serviceProvider: null, items: null);
                List<ValidationResult> results = new List<ValidationResult>();
                bool isValid = Validator.TryValidateObject(this, context, results, true);

                if (isValid == false)
                {
                    StringBuilder sbrErrors = new StringBuilder();
                    foreach (var validationResult in results)
                    {
                        sbrErrors.AppendLine(validationResult.ErrorMessage);
                    }
                    throw new ValidationException(sbrErrors.ToString());
                }
            }
            public void ValidateClassComplement()
            {
                Cls_ValidateCPF Cls_ValidateCPF = new Cls_ValidateCPF();
                if (this.NameFather == this.NameMother)
                {
                    throw new Exception("Nome do pai e da mãe não podem ser iguais");
                }
                if (this.NoHaveFather == false)
                {
                    if (this.NameFather == "")
                    {
                        throw new Exception("Campo nome do pai deve ser preenchido, porque foi marcado que possui pai.");
                    }
                }

                if (Cls_ValidateCPF.Valida(this.CPF) == false)
                {
                    throw new Exception("CPF invalido.");
                }
            }
        }

        public class AllClients
        {
            public List<Unit> ListUnit { get; set; } = new List<Unit>();

        }


        public static Unit DesSerializedClassUnit(string ClientJson)
        {
            return JsonConvert.DeserializeObject<Unit>(ClientJson);
        }

        public static string SerializedClassUnit(Unit ClientClass)
        {
            return JsonConvert.SerializeObject(ClientClass);
        }

        public void AddNewClientBinder(string Connection, Unit Client)
        {
            var ClientJson = SerializedClassUnit(Client);
            Binder BinderConnection = new Binder(Connection);
            if (BinderConnection.status)
            {
                BinderConnection.AddNewClient(Client.Id, ClientJson);

                if (BinderConnection.status)
                {

                    MessageBox.Show(BinderConnection.message, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    throw new Exception(BinderConnection.message);
                }

            }


        }

        public Unit GetClientBinder(string IdClient, string Connection, bool FuncDelete = false)
        {

            Binder BinderConnection = new Binder(Connection);

            if (BinderConnection.status)
            {
                var ClientInfo = BinderConnection.FindClient(IdClient);

                if (BinderConnection.status)
                {

                    var ClientClass = DesSerializedClassUnit(ClientInfo);

                    if (!FuncDelete)
                    {
                        MessageBox.Show("Cliente encontrado com sucesso!!", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                    return ClientClass;

                }
                else
                {
                    throw new Exception(BinderConnection.message);
                }
            }
            else
            {
                throw new Exception(BinderConnection.message);
            }
        }

        public void UpdateClientBinder(Unit Client, string Connection)
        {
            Binder BinderConnection = new Binder(Connection);

            if (BinderConnection.status)
            {
                string ClientJson = Cls_Clients.SerializedClassUnit(Client);


                BinderConnection.UpdateClient(Client.Id, ClientJson);

                MessageBox.Show("Cliente Atualizado com sucesso!!", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        public void DeleteClientBinder(string Connection, string IdClient)
        {
            Binder BinderConnection = new Binder(Connection);

            if (BinderConnection.status)
            {
                BinderConnection.DeleteClient(IdClient);

                if (BinderConnection.status)
                {
                    MessageBox.Show("Cliente excluido com sucesso!!", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    throw new Exception(BinderConnection.message);
                }
            }
            else
            {
                throw new Exception(BinderConnection.message);
            }
        }

        public List<List<string>> GetAllClientBinders(string Connection)
        {
            Binder BinderConnection = new Binder("C:\\Users\\Administ\\Documents\\ProjetocSharp\\Fichario");

            if (BinderConnection.status)
            {
                var ListClients = BinderConnection.FindAllClient();

                if (BinderConnection.status)
                {

                    List<List<string>> Clients = new List<List<string>>();

                    for (int i = 0; i < ListClients.Count; i++)
                    {
                        var teste = DesSerializedClassUnit(ListClients[i]);

                        Clients.Add(new List<string> { teste.Id, teste.Name });

                    }
                    return Clients;
                }
                else
                {
                    throw new Exception(BinderConnection.message);
                }

            }
            else
            {
                throw new Exception(BinderConnection.message);
            }

        }
    }

}
