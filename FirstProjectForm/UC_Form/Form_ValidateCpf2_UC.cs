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
    public partial class Form_ValidateCpf2_UC : UserControl
    {
        public Form_ValidateCpf2_UC()
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
            string ValueTextBox = Masked_TextBox_Cpf.Text;
            ValueTextBox = ValueTextBox.Replace(".", "").Replace("-", "");
            ValueTextBox = ValueTextBox.Trim();

            if (ValueTextBox == "")
            {
                MessageBox.Show("Campo CPF fazio", "Mensagem de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

         

                if (ValueTextBox.Length != 11)
                {
                    MessageBox.Show("CPF deve ter 11 digitos", "Mensagem de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                   // if (MessageBox.Show("Você deseja realmente validar o CPF?", "Mensagem de validação!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                        Form_Question Form_Question = new Form_Question("Frm_ValidaCPF2");
                    Form_Question.ShowDialog();
                   

                    if (Form_Question.DialogResult == DialogResult.Yes)
                    {

                        if (ValidadeCPF.Valida(Masked_TextBox_Cpf.Text))
                        {

                            MessageBox.Show("CPF Válido", "Mensagem de validação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("CPF Inválido", "Mensagem de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

            }

        }
    }
}
