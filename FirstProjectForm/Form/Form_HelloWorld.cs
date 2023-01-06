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
    public partial class Form_HelloWorld : Form
    {
        public Form_HelloWorld()
        {
            InitializeComponent();
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

  
        private void label1_Click(object sender, EventArgs e)
        {

        }

 

        private void Button_Close_Aplication(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void Button_Reload_Title_Click(object sender, EventArgs e)
        {
            Random Random = new Random();
            label_Titulo.Text = TextBox_ContentLabel.Text + Random.Next(0, 100).ToString();

        }

        private void TextBox_ContentLabel_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
