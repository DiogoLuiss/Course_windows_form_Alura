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
    public partial class Form_Main_Menu_MDI : Form
    {
        public Form_Main_Menu_MDI()
        {
            InitializeComponent();
        }

        private void demonstraçãoKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {


            Form_DemonstracaoKey Form_DemonstracaoKey = new Form_DemonstracaoKey();
            Form_DemonstracaoKey.MdiParent = this;
            Form_DemonstracaoKey.Show();


        }

        private void helloWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {


            Form_HelloWorld Form_HelloWorld = new Form_HelloWorld();
            Form_HelloWorld.MdiParent = this;
            Form_HelloWorld.Show();


        }

        private void mascaraToolStripMenuItem_Click(object sender, EventArgs e)
        {


            Form_Masked Form_Masked = new Form_Masked();

            Form_Masked.MdiParent = this;
            Form_Masked.Show();

        }

        private void validaCPFToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form_ValidateCpf Form_ValidateCpf = new Form_ValidateCpf();


            Form_ValidateCpf.MdiParent = this;
            Form_ValidateCpf.Show();
        }

        private void validaCPF2ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form_ValidateCpf2 Form_ValidateCpf2 = new Form_ValidateCpf2();

            Form_ValidateCpf2.MdiParent = this;
            Form_ValidateCpf2.Show();


        }

        private void validaSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form_PasswordValidation Form_PasswordValidation = new Form_PasswordValidation();

            Form_PasswordValidation.MdiParent = this;
            Form_PasswordValidation.Show();

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cascadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileVertical);
        }
    }
}
