namespace FirstProjectForm.UC_Form
{
    partial class Form_ValidadePassword_UC
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
            this.Button_Show_Password = new System.Windows.Forms.Button();
            this.Button_Reset = new System.Windows.Forms.Button();
            this.Label_Result = new System.Windows.Forms.Label();
            this.Text_Password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Button_Show_Password
            // 
            this.Button_Show_Password.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Show_Password.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Show_Password.Location = new System.Drawing.Point(253, 92);
            this.Button_Show_Password.Name = "Button_Show_Password";
            this.Button_Show_Password.Size = new System.Drawing.Size(111, 23);
            this.Button_Show_Password.TabIndex = 5;
            this.Button_Show_Password.Text = "Mostrar Senha";
            this.Button_Show_Password.UseVisualStyleBackColor = true;
            this.Button_Show_Password.Click += new System.EventHandler(this.Button_Show_Password_Click);
            // 
            // Button_Reset
            // 
            this.Button_Reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Reset.Location = new System.Drawing.Point(253, 63);
            this.Button_Reset.Name = "Button_Reset";
            this.Button_Reset.Size = new System.Drawing.Size(111, 23);
            this.Button_Reset.TabIndex = 6;
            this.Button_Reset.Text = "Limpar";
            this.Button_Reset.UseVisualStyleBackColor = true;
            this.Button_Reset.Click += new System.EventHandler(this.Button_Reset_Click);
            // 
            // Label_Result
            // 
            this.Label_Result.AutoSize = true;
            this.Label_Result.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Result.Location = new System.Drawing.Point(20, 111);
            this.Label_Result.Name = "Label_Result";
            this.Label_Result.Size = new System.Drawing.Size(0, 19);
            this.Label_Result.TabIndex = 4;
            // 
            // Text_Password
            // 
            this.Text_Password.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Text_Password.Location = new System.Drawing.Point(20, 66);
            this.Text_Password.Name = "Text_Password";
            this.Text_Password.PasswordChar = '•';
            this.Text_Password.Size = new System.Drawing.Size(218, 20);
            this.Text_Password.TabIndex = 3;
            this.Text_Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Text_Password_KeyDown);
            // 
            // Form_ValidadePassword_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Button_Show_Password);
            this.Controls.Add(this.Button_Reset);
            this.Controls.Add(this.Label_Result);
            this.Controls.Add(this.Text_Password);
            this.Name = "Form_ValidadePassword_UC";
            this.Size = new System.Drawing.Size(384, 193);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_Show_Password;
        private System.Windows.Forms.Button Button_Reset;
        private System.Windows.Forms.Label Label_Result;
        private System.Windows.Forms.TextBox Text_Password;
    }
}
