namespace FirstProjectForm
{
    partial class Form_FindAllClients
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_FindAllClients));
            this.ListBox_Find = new System.Windows.Forms.ListBox();
            this.ToolStrip_Items = new System.Windows.Forms.ToolStrip();
            this.SaveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ToolStrip_Items.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListBox_Find
            // 
            this.ListBox_Find.FormattingEnabled = true;
            this.ListBox_Find.Location = new System.Drawing.Point(12, 37);
            this.ListBox_Find.Name = "ListBox_Find";
            this.ListBox_Find.Size = new System.Drawing.Size(321, 264);
            this.ListBox_Find.TabIndex = 0;
            // 
            // ToolStrip_Items
            // 
            this.ToolStrip_Items.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveToolStripButton});
            this.ToolStrip_Items.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip_Items.Name = "ToolStrip_Items";
            this.ToolStrip_Items.Size = new System.Drawing.Size(345, 25);
            this.ToolStrip_Items.TabIndex = 1;
            this.ToolStrip_Items.Text = "toolStrip1";
            // 
            // SaveToolStripButton
            // 
            this.SaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveToolStripButton.Image")));
            this.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveToolStripButton.Name = "SaveToolStripButton";
            this.SaveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.SaveToolStripButton.Text = "&Salvar";
            this.SaveToolStripButton.Click += new System.EventHandler(this.SaveToolStripButton_Click);
            // 
            // Form_FindAllClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 320);
            this.Controls.Add(this.ToolStrip_Items);
            this.Controls.Add(this.ListBox_Find);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_FindAllClients";
            this.Text = "Form_FindAllClients";
            this.ToolStrip_Items.ResumeLayout(false);
            this.ToolStrip_Items.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBox_Find;
        private System.Windows.Forms.ToolStrip ToolStrip_Items;
        private System.Windows.Forms.ToolStripButton SaveToolStripButton;
    }
}