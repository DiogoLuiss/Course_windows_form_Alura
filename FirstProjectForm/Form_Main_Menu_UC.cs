using CourseWindowsFormsLibrarys;
using FirstProjectForm.UC_Form;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstProjectForm
{
    public partial class Form_Main_Menu_UC : Form
    {
        int Hello_World_IdName = 0;
        int Form_DemonstrationKey_IdName = 0;
        int Form_Masked_IdName = 0;
        int Form_PasswordValidation_IdName = 0;
        int Form_ValidateCpf_IdName = 0;
        int Form_ValidateCpf2_IdName = 0;
        int Form_FileImg_UC_IdName = 0;
        public Form_Main_Menu_UC()
        {
            InitializeComponent();
            novoToolStripMenuItem.Enabled = false;
            DeletarAbaToolStripMenuItem.Enabled = false;
            abrirImagemToolStripMenuItem.Enabled = false;
            desconectarToolStripMenuItem.Enabled = false;
        }

        private void DemonstraçãoKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_DemonstrationKey_UC Form_DemonstrationKey_UC = new Form_DemonstrationKey_UC();
            Form_DemonstrationKey_IdName++;
            Form_DemonstrationKey_UC.Dock = DockStyle.Fill;

            TabPage TablePage = new TabPage();

            TablePage.Name = "Demonstração key " + Form_DemonstrationKey_IdName;
            TablePage.Text = "Demonstração key " + Form_DemonstrationKey_IdName;
            TablePage.ImageIndex = 0;
            TablePage.Controls.Add(Form_DemonstrationKey_UC);
            TabControl_Aplications.TabPages.Add(TablePage);
        }

        private void helloWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_HelloWorld_UC Form_HelloWorld_UC = new Form_HelloWorld_UC();
            Hello_World_IdName++;
            Form_HelloWorld_UC.Dock = DockStyle.Fill;

            TabPage TablePage = new TabPage();

            TablePage.Name = "Hello World " + Hello_World_IdName;
            TablePage.Text = "Hello World " + Hello_World_IdName;
            TablePage.ImageIndex = 1;
            TablePage.Controls.Add(Form_HelloWorld_UC);
            TabControl_Aplications.TabPages.Add(TablePage);

        }

        private void mascaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Masked_UC Form_Masked = new Form_Masked_UC();
            Form_Masked_IdName++;
            Form_Masked.Dock = DockStyle.Fill;

            TabPage TablePage = new TabPage();

            TablePage.Name = "Mascara " + Form_Masked_IdName;
            TablePage.Text = "Mascara " + Form_Masked_IdName;
            TablePage.ImageIndex = 2;
            TablePage.Controls.Add(Form_Masked);
            TabControl_Aplications.TabPages.Add(TablePage);
        }

        private void validaCPFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ValidateCpf_UC Form_ValidateCpf = new Form_ValidateCpf_UC();
            Form_ValidateCpf_IdName++;
            Form_ValidateCpf.Dock = DockStyle.Fill;

            TabPage TablePage = new TabPage();

            TablePage.Name = "Valida CPF " + Form_ValidateCpf_IdName;
            TablePage.Text = "Valida CPF " + Form_ValidateCpf_IdName;
            TablePage.ImageIndex = 3;
            TablePage.Controls.Add(Form_ValidateCpf);
            TabControl_Aplications.TabPages.Add(TablePage);

        }

        private void validaCPF2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ValidateCpf2_UC Form_ValidateCpf2 = new Form_ValidateCpf2_UC();
            Form_ValidateCpf2_IdName++;


            Form_ValidateCpf2.Dock = DockStyle.Fill;

            TabPage TablePage = new TabPage();

            TablePage.Name = "Valida CPF " + Form_ValidateCpf2_IdName;
            TablePage.Text = "Valida CPF " + Form_ValidateCpf2_IdName;
            TablePage.ImageIndex = 4;
            TablePage.Controls.Add(Form_ValidateCpf2);
            TabControl_Aplications.TabPages.Add(TablePage);
        }

        private void validaSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ValidadePassword_UC Form_PasswordValidation = new Form_ValidadePassword_UC();
            Form_PasswordValidation_IdName++;
            Form_PasswordValidation.Dock = DockStyle.Fill;

            TabPage TablePage = new TabPage();

            TablePage.Name = "Valida Senha " + Form_PasswordValidation_IdName;
            TablePage.Text = "Valida Senha " + Form_PasswordValidation_IdName;
            TablePage.ImageIndex = 5;
            TablePage.Controls.Add(Form_PasswordValidation);
            TabControl_Aplications.TabPages.Add(TablePage);
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DeletarAbaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TabControl_Aplications.SelectedTab != null)
            {
                TabControl_Aplications.TabPages.Remove(TabControl_Aplications.SelectedTab);
            }

        }

        private void abrirImagemToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OpenFileDialog OpenFileDialog = new OpenFileDialog();
            OpenFileDialog.InitialDirectory = "c:\\";
            OpenFileDialog.Filter = "*PNG|*.PNG";
            OpenFileDialog.Title = "Escolha o Arquivo!";



            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                string NameFileImg = OpenFileDialog.FileName;


                Form_FileImg_UC Form_FileImg_UC = new Form_FileImg_UC(NameFileImg);
                Form_FileImg_UC_IdName++;
                Form_FileImg_UC.Dock = DockStyle.Fill;

                TabPage TablePage = new TabPage();

                TablePage.Name = "Arquivo Imagem " + Form_FileImg_UC_IdName;
                TablePage.Text = "Arquivo Imagem " + Form_FileImg_UC_IdName;
                TablePage.ImageIndex = 6;
                TablePage.Controls.Add(Form_FileImg_UC);
                TabControl_Aplications.TabPages.Add(TablePage);
            }


        }

        private void entrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Login Form_Login = new Form_Login();

            if (Form_Login.ShowDialog() == DialogResult.OK)
            {

                Cls_ValidateUser Cls_ValidateUser = new Cls_ValidateUser();
                string password = Form_Login.Password;

                if (Cls_ValidateUser.ValidatePassword(password))
                {
                    novoToolStripMenuItem.Enabled = true;
                    DeletarAbaToolStripMenuItem.Enabled = true;
                    abrirImagemToolStripMenuItem.Enabled = true;
                    entrarToolStripMenuItem.Enabled = false;
                    desconectarToolStripMenuItem.Enabled = true;

                    MessageBox.Show("Bem vindo " + Form_Login.Login + "!", "Mensagem de authenticação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Usuario ou senha incorretos " + Form_Login.Login + "!", "Mensagem de authenticação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }

        }

        private void desconectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Question Form_Question = new Form_Question("ask", "Você deseja mesmo sair?");

            if (Form_Question.ShowDialog() == DialogResult.Yes)

            {

                while (TabControl_Aplications.TabPages.Count != 0)
                {
                    TabControl_Aplications.TabPages.Remove(TabControl_Aplications.TabPages[0]);

                }

                novoToolStripMenuItem.Enabled = false;
                DeletarAbaToolStripMenuItem.Enabled = false;
                abrirImagemToolStripMenuItem.Enabled = false;
                entrarToolStripMenuItem.Enabled = true;
                desconectarToolStripMenuItem.Enabled = false;


            }
        }

    }
}
