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

namespace FirstProjectForm.UC_Form
{
    public partial class Form_ValidateCpf_UC : UserControl
    {
        public Form_ValidateCpf_UC()
        {
            InitializeComponent();
        }

        private void Button_Reset_Click(object sender, EventArgs e)
        {
            Masked_TextBox_Cpf.Text = "";
        }

        private void Button_Validate_Click(object sender, EventArgs e)
        {
            Cls_ValidateCPF ValidadeCPF = new Cls_ValidateCPF();



            if (ValidadeCPF.Valida(Masked_TextBox_Cpf.Text))
            {

                Label_Result_Cpf.Text = "CPF Valido";
                Label_Result_Cpf.ForeColor = Color.Green;
            }
            else
            {
                Label_Result_Cpf.ForeColor = Color.Red;
                Label_Result_Cpf.Text = "CPF Invalido";
            }
        }


    }
}
