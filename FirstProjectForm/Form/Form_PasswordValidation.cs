using FirstProjectForm.Utils;
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
    public partial class Form_PasswordValidation : Form
    {
        public Form_PasswordValidation()
        {
            InitializeComponent();
 
        
        }

        private void Text_Password_KeyDown(object sender, KeyEventArgs e)
        {

            Cls_ChecaForcaSenha ChecaForcaSenha = new Cls_ChecaForcaSenha();
            
            Label_Result.Text = ChecaForcaSenha.GetForcaDaSenha(Text_Password.Text).ToString();

            if (Label_Result.Text == "Inaceitavel" | Label_Result.Text == "Fraca")
            {

                Label_Result.ForeColor = Color.Red ;

            }
            if (Label_Result.Text == "Aceitavel")
            {
                Label_Result.ForeColor = Color.Blue;
            }

            if (Label_Result.Text == "Forte" | Label_Result.Text == "Segura" )
            {

                Label_Result.ForeColor = Color.Green;

            }
          



        }
       

        private void Button_Reset_Click(object sender, EventArgs e)
        {
            Text_Password.Text = "";
            Label_Result.Text = "";
        }

        private void Button_Show_Password_Click(object sender, EventArgs e)
        {
            if (Text_Password.PasswordChar == '•')
            {
                Text_Password.PasswordChar = '\0';
                Button_Show_Password.Text = "Esconder Senha";
            }
            else
            {
                Text_Password.PasswordChar = '•';
                Button_Show_Password.Text = "Mostrar senha";
            }
        }

        private void Text_Password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
