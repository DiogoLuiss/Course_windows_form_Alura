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
    public partial class Form_Masked : Form
    {
        public Form_Masked()
        {
            InitializeComponent();
        }


        internal void ReloadFormat() {
            Tabel_Masked_Active.Text = Masked_Text_Box.Mask;
            Masked_Text_Box.Text = "";
            Masked_Text_Box.Focus();
            Masked_Text_Box.UseSystemPasswordChar = false;
        }

        private void Button_Hours_Click(object sender, EventArgs e)
        {
            Masked_Text_Box.Mask = "00:00";
            ReloadFormat();
        }

        private void Button_Cep_Click(object sender, EventArgs e)
        {
            Masked_Text_Box.Mask = "0000,000";
            ReloadFormat();
        }

        private void Button_Coin_Click(object sender, EventArgs e)
        {
            Masked_Text_Box.Mask = "$ 000,000,000.00";
            ReloadFormat();
        }

        private void Button_Date_Click(object sender, EventArgs e)
        {
            Masked_Text_Box.Mask = "00/00/0000";
            ReloadFormat();
        }

        private void Button_Password_Click(object sender, EventArgs e)
        {
            Masked_Text_Box.UseSystemPasswordChar = true;
            Tabel_Masked_Active.Text = Masked_Text_Box.Mask;
            
            Masked_Text_Box.Focus();
        }

        private void Button_Tel_Click(object sender, EventArgs e)
        {
            Masked_Text_Box.Mask = " (00) 000000000";
            ReloadFormat();

        }

        private void Button_Show_Content_Click(object sender, EventArgs e)
        {
            
            Masked_Text_Box.PasswordChar = '\0';
            Label_Content.Text = Masked_Text_Box.Text;
        }
    }
}
