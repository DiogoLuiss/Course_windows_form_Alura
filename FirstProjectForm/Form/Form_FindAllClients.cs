using CourseWindowsFormsLibrarys.Database;
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
    public partial class Form_FindAllClients : Form
    {

        List<List<string>> _Clients = new List<List<string>>();
        public string IdSelect { get; set; } 
        public Form_FindAllClients(List<List<string>> Clients)
        {
            InitializeComponent();
          
            _Clients = Clients;
            ToolStrip_Items.Items[0].ToolTipText = "Pegar dados do cliente";
             ListBox_Find.Sorted = true;
            WriteList();
           
        }

        void WriteList()
        {
            ListBox_Find.Items.Clear();

            for (int i = 0; i < _Clients.Count; i++)
            {
                ClientInfo ClientInfo = new ClientInfo();
                ClientInfo.Id = _Clients[i][0];
                ClientInfo.Name = _Clients[i][1];

                ListBox_Find.Items.Add(ClientInfo);
            }
        }


        private void SaveToolStripButton_Click(object sender, EventArgs e)
        {
            if (ListBox_Find.SelectedIndex >= 0 )
            {
                ClientInfo ClientSelected = (ClientInfo)ListBox_Find.Items[ListBox_Find.SelectedIndex];
                IdSelect = ClientSelected.Id;
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Você precisar selecionar um cliente para continuar", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public class ClientInfo
        {
            public string Id;
            public string Name;
            

            public override string ToString()
            {
                return Name;
            }
        }


    }
}
