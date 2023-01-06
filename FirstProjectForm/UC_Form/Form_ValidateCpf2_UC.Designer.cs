namespace FirstProjectForm.UC_Form
{
    partial class Form_ValidateCpf2_UC
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
            this.Button_Validate = new System.Windows.Forms.Button();
            this.Button_Reset = new System.Windows.Forms.Button();
            this.Masked_TextBox_Cpf = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // Button_Validate
            // 
            this.Button_Validate.Location = new System.Drawing.Point(253, 99);
            this.Button_Validate.Name = "Button_Validate";
            this.Button_Validate.Size = new System.Drawing.Size(111, 23);
            this.Button_Validate.TabIndex = 5;
            this.Button_Validate.Text = "Valida";
            this.Button_Validate.UseVisualStyleBackColor = true;
            this.Button_Validate.Click += new System.EventHandler(this.Button_Validate_Click);
            // 
            // Button_Reset
            // 
            this.Button_Reset.Location = new System.Drawing.Point(253, 70);
            this.Button_Reset.Name = "Button_Reset";
            this.Button_Reset.Size = new System.Drawing.Size(111, 23);
            this.Button_Reset.TabIndex = 4;
            this.Button_Reset.Text = "Limpar";
            this.Button_Reset.UseVisualStyleBackColor = true;
            this.Button_Reset.Click += new System.EventHandler(this.Button_Reset_Click);
            // 
            // Masked_TextBox_Cpf
            // 
            this.Masked_TextBox_Cpf.Location = new System.Drawing.Point(20, 73);
            this.Masked_TextBox_Cpf.Mask = "000,000,000-00";
            this.Masked_TextBox_Cpf.Name = "Masked_TextBox_Cpf";
            this.Masked_TextBox_Cpf.Size = new System.Drawing.Size(218, 20);
            this.Masked_TextBox_Cpf.TabIndex = 3;
            // 
            // Form_ValidateCpf2_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Button_Validate);
            this.Controls.Add(this.Button_Reset);
            this.Controls.Add(this.Masked_TextBox_Cpf);
            this.Name = "Form_ValidateCpf2_UC";
            this.Size = new System.Drawing.Size(384, 193);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_Validate;
        private System.Windows.Forms.Button Button_Reset;
        private System.Windows.Forms.MaskedTextBox Masked_TextBox_Cpf;
    }
}
