using CourseWindowsFormsLibrarys;
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
    public partial class Form_ValidateCpf : Form
    {
        public Form_ValidateCpf()
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

        private void Form_ValidateCpf_Load(object sender, EventArgs e)
        {

        }
    }
}
