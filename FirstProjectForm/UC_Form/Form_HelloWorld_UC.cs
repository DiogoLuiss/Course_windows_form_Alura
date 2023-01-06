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
    public partial class Form_HelloWorld_UC : UserControl
    {
        public Form_HelloWorld_UC()
        {
            InitializeComponent();
        }

        private void Button_Reload_Title_Click(object sender, EventArgs e)
        {
            Random Random = new Random();
            label_Titulo.Text = TextBox_ContentLabel.Text + Random.Next(0, 100).ToString();
        }
    }
}
