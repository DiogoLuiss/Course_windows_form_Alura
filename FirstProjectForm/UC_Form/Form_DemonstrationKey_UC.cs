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
    public partial class Form_DemonstrationKey_UC : UserControl
    {
        public Form_DemonstrationKey_UC()
        {
            InitializeComponent();
        }

        private void Button_Reset_Click(object sender, EventArgs e)
        {
            Text_Input.Text = "";
            Text_Msg.Text = "";
            Label_Upper.Text = "";
            Label_Lower.Text = "";

        }

        private void Text_Input_KeyDown(object sender, KeyEventArgs e)
        {
            Text_Msg.AppendText("\r\n" + "Eu pressionei a tecla: " + e.KeyCode.ToString() + "\r\n");
            Text_Msg.AppendText("\t" + "O código da tecla é " + e.KeyValue.ToString() + "\r\n");
            Label_Upper.Text = e.KeyCode.ToString().ToUpper();
            Label_Lower.Text = e.KeyCode.ToString().ToLower();
        }
    }
}
