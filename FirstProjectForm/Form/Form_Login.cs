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
    public partial class Form_Login : Form
    {
        public string Password;
        public string Login;
        public Form_Login()
        {
            InitializeComponent();
            Label_Login.Text = "Login";
            Label_Password.Text = "Senha";
            Button_OK.Text = "Logar";
            Button_Cancel.Text = "Cancelar";
        }

        private void Button_OK_Click(object sender, EventArgs e)
        {
      
            DialogResult = DialogResult.OK;
            Login = TextBox_Login.Text;
            Password = TextBox_Password.Text;

            this.Close();
        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
