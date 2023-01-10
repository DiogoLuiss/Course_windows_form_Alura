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
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void Button_DemonstrationKey_Click(object sender, EventArgs e)
        {
            Form_DemonstracaoKey Form_DemonstracaoKey = new Form_DemonstracaoKey();
            Form_DemonstracaoKey.ShowDialog();
        }

        private void Button_HelloWorld_Click(object sender, EventArgs e)
        {
            Form_HelloWorld Form_HelloWorld = new Form_HelloWorld();
            Form_HelloWorld.ShowDialog();
        }

        private void Button_Mask_Click(object sender, EventArgs e)
        {
            Form_Masked Form_Masked = new Form_Masked();
            Form_Masked.ShowDialog();
        }

        private void Button_ValidationCPF_Click(object sender, EventArgs e)
        {
            Form_ValidateCpf Form_ValidateCpf = new Form_ValidateCpf();
            Form_ValidateCpf.ShowDialog();
        }

        private void Button_ValidationCPF2_Click(object sender, EventArgs e)
        {
            Form_ValidateCpf2 Form_ValidateCpf2 = new Form_ValidateCpf2();

            Form_ValidateCpf2.ShowDialog();
        }

        private void Button_ValidationPassword_Click(object sender, EventArgs e)
        {
            Form_PasswordValidation Form_PasswordValidation = new Form_PasswordValidation();

            Form_PasswordValidation.ShowDialog();
        }
    }
}
