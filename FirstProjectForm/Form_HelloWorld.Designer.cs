namespace FirstProjectForm
{
    partial class Form_HelloWorld
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_HelloWorld));
            this.label_Titulo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Button_Reload_Title = new System.Windows.Forms.Button();
            this.TextBox_ContentLabel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_Titulo
            // 
            resources.ApplyResources(this.label_Titulo, "label_Titulo");
            this.label_Titulo.Name = "label_Titulo";
            this.label_Titulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.button1, "button1");
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button_Close_Aplication);
            // 
            // Button_Reload_Title
            // 
            this.Button_Reload_Title.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.Button_Reload_Title, "Button_Reload_Title");
            this.Button_Reload_Title.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Reload_Title.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.Button_Reload_Title.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Button_Reload_Title.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.Button_Reload_Title.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Button_Reload_Title.Name = "Button_Reload_Title";
            this.Button_Reload_Title.UseVisualStyleBackColor = false;
            this.Button_Reload_Title.Click += new System.EventHandler(this.Button_Reload_Title_Click);
            // 
            // TextBox_ContentLabel
            // 
            resources.ApplyResources(this.TextBox_ContentLabel, "TextBox_ContentLabel");
            this.TextBox_ContentLabel.Name = "TextBox_ContentLabel";
            // 
            // Form_HelloWorld
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TextBox_ContentLabel);
            this.Controls.Add(this.Button_Reload_Title);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_Titulo);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Form_HelloWorld";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Titulo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Button_Reload_Title;
        private System.Windows.Forms.TextBox TextBox_ContentLabel;
    }
}

