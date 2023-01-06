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
    public partial class Form_FileImg_UC : UserControl
    {
        public Form_FileImg_UC(string NameFileImg)
        {
            InitializeComponent();
            Label_FileImg.Text = NameFileImg;
            Picture_FileImg.Image = Image.FromFile(NameFileImg);

        }

        private void Button_Change_Color_Click(object sender, EventArgs e)
        {
            ColorDialog ColorDialog = new ColorDialog();
            if (ColorDialog.ShowDialog() == DialogResult.OK)
            {
                Label_FileImg.ForeColor = ColorDialog.Color;
            }

        }

        private void Button_Change_Font_Click(object sender, EventArgs e)
        {
            FontDialog FontDialog = new FontDialog();

            if (FontDialog.ShowDialog() == DialogResult.OK)
            {
                Label_FileImg.Font = FontDialog.Font;
            }

        }
    }
}
