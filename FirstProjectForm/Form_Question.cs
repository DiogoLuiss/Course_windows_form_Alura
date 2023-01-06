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
    public partial class Form_Question : Form
    {
        public Form_Question(string NameImg = "ask" , string Message = "Você deseja validar o CPF")
        {
            InitializeComponent();

           
           Image MyImage = (Image)global::FirstProjectForm.Properties.Resources.ResourceManager.GetObject(NameImg);
            if (MyImage != null)
            {
                Picture_Img.Image = MyImage;
            }
 

            label1.Text = Message;
        }

        private void Button_Ok_Click(object sender, EventArgs e)
        {
            
            DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Form_Question_Load(object sender, EventArgs e)
        {
  
        }

        private void Form_Question_Shown(object sender, EventArgs e)
        {
            //Button_Ok.Focus();
        }
    }
}
