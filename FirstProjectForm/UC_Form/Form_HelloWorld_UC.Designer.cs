namespace FirstProjectForm
{
    partial class Form_HelloWorld_UC
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextBox_ContentLabel = new System.Windows.Forms.TextBox();
            this.Button_Reload_Title = new System.Windows.Forms.Button();
            this.label_Titulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextBox_ContentLabel
            // 
            this.TextBox_ContentLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_ContentLabel.Location = new System.Drawing.Point(24, 94);
            this.TextBox_ContentLabel.Name = "TextBox_ContentLabel";
            this.TextBox_ContentLabel.Size = new System.Drawing.Size(493, 20);
            this.TextBox_ContentLabel.TabIndex = 6;
            // 
            // Button_Reload_Title
            // 
            this.Button_Reload_Title.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Button_Reload_Title.BackColor = System.Drawing.Color.White;
            this.Button_Reload_Title.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Button_Reload_Title.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Reload_Title.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.Button_Reload_Title.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Button_Reload_Title.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.Button_Reload_Title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Reload_Title.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Button_Reload_Title.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Button_Reload_Title.Location = new System.Drawing.Point(24, 50);
            this.Button_Reload_Title.Name = "Button_Reload_Title";
            this.Button_Reload_Title.Size = new System.Drawing.Size(287, 27);
            this.Button_Reload_Title.TabIndex = 5;
            this.Button_Reload_Title.Text = "Modifica texto do Label";
            this.Button_Reload_Title.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Button_Reload_Title.UseVisualStyleBackColor = false;
            this.Button_Reload_Title.Click += new System.EventHandler(this.Button_Reload_Title_Click);
            // 
            // label_Titulo
            // 
            this.label_Titulo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_Titulo.AutoSize = true;
            this.label_Titulo.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold);
            this.label_Titulo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_Titulo.Location = new System.Drawing.Point(19, 19);
            this.label_Titulo.Name = "label_Titulo";
            this.label_Titulo.Size = new System.Drawing.Size(292, 28);
            this.label_Titulo.TabIndex = 4;
            this.label_Titulo.Text = "Visual Studio .NET Version\r\n";
            // 
            // Form_HelloWorld_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TextBox_ContentLabel);
            this.Controls.Add(this.Button_Reload_Title);
            this.Controls.Add(this.label_Titulo);
            this.Name = "Form_HelloWorld_UC";
            this.Size = new System.Drawing.Size(546, 322);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox_ContentLabel;
        private System.Windows.Forms.Button Button_Reload_Title;
        private System.Windows.Forms.Label label_Titulo;
    }
}
