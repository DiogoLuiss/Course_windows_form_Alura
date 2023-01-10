using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace FirstProjectForm
{
    public partial class Form_MouseCapture : Form
    {
        public Form_MouseCapture()
        {
            InitializeComponent();
        }

        private void Button_Event_MouseDown(object sender, MouseEventArgs e)
        {
           
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
        

                //this.Cursor = Cursors.WaitCursor;
                //for (int i = 0; i < 10; i++)
                //{
                //    System.Threading.Thread.Sleep(1000);
                //}
                //this.Cursor = Cursors.Default;
                //MessageBox.Show("A tecla pressionada é A LEFT" );
            }
         
        }

        private void Form_MouseCapture_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
       
                var ContextMenu = new ContextMenuStrip();

                ToolStripMenuItem vToolTip1 = GenerateItemMenu("Item do menu 1", "Frm_DemonstracaoKey");
                ToolStripMenuItem vToolTip2 = GenerateItemMenu("Item do menu 2", "Frm_HelloWorld");

                ContextMenu.Items.Add(vToolTip1);
                ContextMenu.Items.Add(vToolTip2);
                ContextMenu.Show(this, new Point(e.X, e.Y));
                vToolTip1.Click += new System.EventHandler(vToolTip1_Click);
                vToolTip2.Click += new System.EventHandler(vToolTip2_Click);
            }

            ToolStripMenuItem GenerateItemMenu(string text, string imageName)
            {
              
                ToolStripMenuItem vToolTip = new ToolStripMenuItem();

                var MyImage = (System.Drawing.Image)global::FirstProjectForm.Properties.Resources.ResourceManager.GetObject(imageName);
                  
                vToolTip.Text = text;
                vToolTip.Image = MyImage;


                return vToolTip;
            }
       
             void vToolTip1_Click(object sender1 , EventArgs e1)
            {
                MessageBox.Show("Selecionei o Menu 1");
            }
            void vToolTip2_Click(object sender1, EventArgs e1)
            {
                MessageBox.Show("Selecionei o Menu 2");
            }
        }
    }
}
