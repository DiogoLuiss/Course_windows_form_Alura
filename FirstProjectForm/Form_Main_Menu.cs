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
    public partial class Form_Main_Menu : Form
    {
        public Form_Main_Menu()
        {
            InitializeComponent();
        }

        private void demonstraçãoKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_DemonstracaoKey Form_DemonstracaoKey = new Form_DemonstracaoKey();
            Form_DemonstracaoKey.ShowDialog();
        }

        private void helloWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_HelloWorld Form_HelloWorld = new Form_HelloWorld   ();
            Form_HelloWorld.ShowDialog();
        }

        private void mascaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Masked Form_Masked = new Form_Masked();
            Form_Masked.ShowDialog();
        }

        private void validaCPFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ValidateCpf Form_ValidateCpf = new Form_ValidateCpf();
            Form_ValidateCpf.ShowDialog();
        }

        private void validaCPF2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ValidateCpf2 Form_ValidateCpf2 = new Form_ValidateCpf2();
            Form_ValidateCpf2.ShowDialog();

        }

        private void validaSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_PasswordValidation Form_PasswordValidation = new Form_PasswordValidation();
            Form_PasswordValidation.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
