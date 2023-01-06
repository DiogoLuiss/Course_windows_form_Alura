using CourseWindowsFormsLibrarys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;
using Microsoft.VisualBasic;
using System.Threading;
using CourseWindowsFormsLibrarys.ClientCep;
using CourseWindowsFormsLibrarys.Database;
using System.Security.Policy;

namespace FirstProjectForm.UC_Form
{
    public partial class Form_RegisterClient_UC : UserControl
    {


        public class Rootobject
        {
            public string sess { get; set; }
            public string rf { get; set; }
        }


        public Form_RegisterClient_UC()
        {
            InitializeComponent();

            void AddItensInComboBox()
            {
                ComboBox_State.Items.Add("São Paulo (SP)");
                ComboBox_State.Items.Add("Goias (GO)");
                ComboBox_State.Items.Add("Ceará (CE)");
            };


            GroupBox_Code.Text = "Código";
            GroupBox_PersonalData.Text = "Dados Pessoais";
            GroupBox1_Address.Text = "Endereço";
            groupBox_Others.Text = "Outros";
            GroupBox_Genre.Text = "Genero";

            Label_CPF.Text = "CPF";
            Label_NameClient.Text = "Nome";
            Label_NameFather.Text = "Nome do Pai";
            Label_NameMother.Text = "Nome da Mãe";
            Label_CEP.Text = "CEP";
            Label_Address.Text = "Bairro";
            Label_Complement.Text = "Complemento";
            Label_District.Text = "Logradouro";
            Label_State.Text = "Estado";
            Label_Tel.Text = "Telefone";
            Label_Profession.Text = "Profissão";
            Label_FamilyIncome.Text = "Renda Familiar";
            Label_City.Text = "Cidade";

            Button_FindClients.Text = "Procurar Clientes";

            CheckBox_HasFather.Text = "Pai desconhecido?";

            RadioButton_Male.Text = "Masculino";
            RadioButton_Female.Text = "Feminino";

            ComboBox_State.Items.Clear();

            AddItensInComboBox();

            ToolStrip_Main.Items[0].ToolTipText = "Incluir na base de dados um novo cliente";
            ToolStrip_Main.Items[1].ToolTipText = "Capturar um cliente já cadastrado na base";
            ToolStrip_Main.Items[2].ToolTipText = "Atualize o cliente já existente";
            ToolStrip_Main.Items[3].ToolTipText = "Limpa dados da tela de entrada de dados";
            ToolStrip_Main.Items[4].ToolTipText = "Apaga o cliente selecionado";


        }




        private void CheckBox_HasFather_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox_HasFather.Checked == true)
            {
                TextBox_NameFather.Enabled = false;
                Label_NameFather.Enabled = false;
            }
            else
            {
                TextBox_NameFather.Enabled = true;
                Label_NameFather.Enabled = true;
            }

        }
        Cls_Clients.AllClients AllClients = new Cls_Clients.AllClients();


        private void NewToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                var Client = ReadForm();

                Cls_Clients Func = new Cls_Clients();

                Func.AddNewClientBinder("C:\\Users\\Administ\\Documents\\ProjetocSharp\\Fichario", Client);

            }
            catch (ValidationException Error)
            {

                MessageBox.Show(Error.Message, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void OpenToolStripButton_Click(object sender, EventArgs e)
        {

            try
            {

                Validade_Field_Code(TextBox_Code.Text);

                Cls_Clients Func = new Cls_Clients();

                var ClientClass = Func.GetClientBinder(TextBox_Code.Text, "C:\\Users\\Administ\\Documents\\ProjetocSharp\\Fichario");

                WriteForm(ClientClass);

            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void SaveToolStripButton_Click(object sender, EventArgs e)
        {

            try
            {
                Validade_Field_Code(TextBox_Code.Text);

                var Client = ReadForm();

                Form_Question Form_Question = new Form_Question("ask", "Você deseja mesmo atualizar o usuario??");

                Form_Question.ShowDialog();

                if (Form_Question.DialogResult == DialogResult.Yes)
                {
                    Cls_Clients Func = new Cls_Clients();

                    Func.UpdateClientBinder(Client, "C:\\Users\\Administ\\Documents\\ProjetocSharp\\Fichario");
                }

            }
            catch (Exception Error)
            {

                MessageBox.Show(Error.Message, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void CleanToolStripButton_Click(object sender, EventArgs e)
        {
            CleamForm();
        }

        private void DeleteToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {

                Validade_Field_Code(TextBox_Code.Text);

                Cls_Clients Func = new Cls_Clients();

                var ClientInfo = Func.GetClientBinder(TextBox_Code.Text, "C:\\Users\\Administ\\Documents\\ProjetocSharp\\Fichario", true);

                WriteForm(ClientInfo);

                Form_Question Form_Question = new Form_Question("ask", "Você deseja mesmo excluir o usuario??");

                Form_Question.ShowDialog();

                if (Form_Question.DialogResult == DialogResult.Yes)
                {
                    Func.DeleteClientBinder("C:\\Users\\Administ\\Documents\\ProjetocSharp\\Fichario", ClientInfo.Id);
                    CleamForm();
                }

            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public Cls_Clients.Unit ReadForm()
        {
            Cls_Clients.Unit Cls_Clients = new Cls_Clients.Unit();

            Cls_Clients.Id = TextBox_Code.Text;
            Cls_Clients.Name = TextBox_NameClient.Text;
            Cls_Clients.NameFather = TextBox_NameFather.Text;
            Cls_Clients.NameMother = TextBox_NameMother.Text;

            Cls_Clients.NoHaveFather = CheckBox_HasFather.Checked;
            Cls_Clients.CPF = TextBox_CPF.Text;

            if (RadioButton_Male.Checked)
            {
                Cls_Clients.Genere = 1;
            }
            if (RadioButton_Female.Checked)
            {
                Cls_Clients.Genere = 2;
            }

            var valueCep = TextBox_CEP.Text;

            var FormatValueCep = valueCep.Replace("-", "");

            Cls_Clients.CEP = FormatValueCep;


            Cls_Clients.Logradouro = TextBox_Logradouro.Text;
            Cls_Clients.Complement = TextBox_Complement.Text;
            Cls_Clients.Neighborhood = TextBox_District.Text;
            Cls_Clients.City = TextBox_City.Text;

            if (ComboBox_State.SelectedIndex < 0)
            {
                Cls_Clients.State = "";
            }
            else
            {
                Cls_Clients.State = ComboBox_State.Items[ComboBox_State.SelectedIndex].ToString();
            }




            Cls_Clients.Tel = TextBox_Tel.Text;
            if (Information.IsNumeric(TextBox_FamilyIncome.Text))
            {
                double VIncome = Convert.ToDouble(TextBox_FamilyIncome.Text);

                if (VIncome < 0)
                {
                    Cls_Clients.FamilyIncome = 0;
                }
                else
                {
                    Cls_Clients.FamilyIncome = VIncome;
                }

            }
            else
            {
                Cls_Clients.FamilyIncome = 0;
            }
            Cls_Clients.FamilyIncome = 0;

            Cls_Clients.ValidateClass();
            Cls_Clients.ValidateClassComplement();

            AllClients.ListUnit.Add(Cls_Clients);



            return Cls_Clients;
        }

        void WriteForm(Cls_Clients.Unit Client)
        {

            TextBox_Code.Text = Client.Id;
            TextBox_NameClient.Text = Client.Name;
            TextBox_NameFather.Text = Client.NameFather;
            TextBox_NameMother.Text = Client.NameMother;

            CheckBox_HasFather.Checked = Client.NoHaveFather;

            TextBox_CPF.Text = Client.CPF;

            TextBox_CEP.Text = Client.CEP;


            if (Client.Genere == 0)
            {
                RadioButton_Male.Checked = true;
            }

            if (Client.Genere == 1)
            {
                RadioButton_Male.Checked = true;
            }
            if (Client.Genere == 2)
            {
                RadioButton_Female.Checked = true;
            }

            TextBox_Logradouro.Text = Client.Logradouro;
            TextBox_Complement.Text = Client.Complement;
            TextBox_District.Text = Client.Neighborhood;
            TextBox_City.Text = Client.City;

            //ComboBox_State.Items[ComboBox_State.SelectedIndex].ToString();

            TextBox_Tel.Text = Client.Tel;

            TextBox_FamilyIncome.Text = Client.FamilyIncome.ToString();

            for (int i = 0; i < ComboBox_State.Items.Count; i++)
            {
                var Vpos = Strings.InStr(ComboBox_State.Items[i].ToString(), Client.State);

                if (Vpos > 0)
                {
                    ComboBox_State.SelectedIndex = i;
                }


            }

        }

        private void CleamForm()
        {

            TextBox_CPF.Text = "";
            TextBox_NameClient.Text = "";
            TextBox_NameFather.Text = "";
            TextBox_NameMother.Text = "";
            TextBox_CEP.Text = "";
            TextBox_District.Text = "";
            TextBox_Complement.Text = "";
            ComboBox_State.SelectedIndex = -1;
            TextBox_Tel.Text = "";
            TextBox_Profession.Text = "";
            TextBox_FamilyIncome.Text = "";
            TextBox_City.Text = "";
            RadioButton_Male.Checked = true;
            TextBox_Code.Text = "";
            TextBox_Logradouro.Text = "";
        }

        private void Validade_Field_Code (string CodeClientValidate) {

            if (CodeClientValidate == "")
            {
                throw new Exception("O Campo código está vazio");
            }
            if (CodeClientValidate.Length != 6)
            {
                throw new Exception("O Código deve ter 6 digitos");
            }
            if (!Information.IsNumeric(CodeClientValidate))
            {
                throw new Exception("O Campo código deve conter apenas numeros");
            }
        }
        private void TextBox_CEP_Leave(object sender, EventArgs e)
        {

            var valueCep = TextBox_CEP.Text;

            var FormatValueCep = valueCep.Replace("-", "");

            if (FormatValueCep.Length == 8)
            {
                if (Information.IsNumeric(FormatValueCep))
                {
                    var CepJson = Cls_FindCep.GeraJSONCEP(FormatValueCep);


                    var ClientCepClass = Cls_ClientCep.DesSerializedClass(CepJson);



                    if (ClientCepClass.Cep != null)
                    {
                        TextBox_Logradouro.Text = ClientCepClass.Logradouro.Replace("§", "").Replace("£", "");
                        TextBox_District.Text = ClientCepClass.Bairro.Replace("§", "").Replace("£", "");
                        TextBox_City.Text = ClientCepClass.Localidade.Replace("§", "").Replace("£", "");
                        for (int i = 0; i < ComboBox_State.Items.Count; i++)
                        {
                            var Vpos = Strings.InStr(ComboBox_State.Items[i].ToString(), "(" + ClientCepClass.Uf + ")");

                            if (Vpos > 0)
                            {
                                ComboBox_State.SelectedIndex = i;
                            }


                        }
                    }

                }

            }



        }
        private void Button_FindClients_Click(object sender, EventArgs e)
        {
            try
            {
                Cls_Clients Func = new Cls_Clients();

                var Clients = Func.GetAllClientBinders("C:\\Users\\Administ\\Documents\\ProjetocSharp\\Fichario");
                Form_FindAllClients Form_FindAllClients = new Form_FindAllClients(Clients);

                Form_FindAllClients.ShowDialog();

                if (Form_FindAllClients.DialogResult == DialogResult.OK)
                {
                    var ClientClass = Func.GetClientBinder(Form_FindAllClients.IdSelect, "C:\\Users\\Administ\\Documents\\ProjetocSharp\\Fichario");
                    WriteForm(ClientClass);
                }
            }
            catch (Exception Error)
            {

                MessageBox.Show(Error.Message, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
      
        }
    }
}

