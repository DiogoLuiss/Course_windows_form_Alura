namespace FirstProjectForm
{
    partial class Form_ValidateCpf2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ValidateCpf2));
            this.Masked_TextBox_Cpf = new System.Windows.Forms.MaskedTextBox();
            this.Button_Reset = new System.Windows.Forms.Button();
            this.Button_Validate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Masked_TextBox_Cpf
            // 
            this.Masked_TextBox_Cpf.Location = new System.Drawing.Point(12, 45);
            this.Masked_TextBox_Cpf.Mask = "000,000,000-00";
            this.Masked_TextBox_Cpf.Name = "Masked_TextBox_Cpf";
            this.Masked_TextBox_Cpf.Size = new System.Drawing.Size(218, 20);
            this.Masked_TextBox_Cpf.TabIndex = 0;
            // 
            // Button_Reset
            // 
            this.Button_Reset.Location = new System.Drawing.Point(245, 42);
            this.Button_Reset.Name = "Button_Reset";
            this.Button_Reset.Size = new System.Drawing.Size(111, 23);
            this.Button_Reset.TabIndex = 2;
            this.Button_Reset.Text = "Limpar";
            this.Button_Reset.UseVisualStyleBackColor = true;
            this.Button_Reset.Click += new System.EventHandler(this.Button_Reset_Click);
            // 
            // Button_Validate
            // 
            this.Button_Validate.Location = new System.Drawing.Point(245, 71);
            this.Button_Validate.Name = "Button_Validate";
            this.Button_Validate.Size = new System.Drawing.Size(111, 23);
            this.Button_Validate.TabIndex = 2;
            this.Button_Validate.Text = "Valida";
            this.Button_Validate.UseVisualStyleBackColor = true;
            this.Button_Validate.Click += new System.EventHandler(this.Button_Validate_Click);
            // 
            // Form_ValidateCpf2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 154);
            this.Controls.Add(this.Button_Validate);
            this.Controls.Add(this.Button_Reset);
            this.Controls.Add(this.Masked_TextBox_Cpf);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_ValidateCpf2";
            this.Text = "Validação CPF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox Masked_TextBox_Cpf;
        private System.Windows.Forms.Button Button_Reset;
        private System.Windows.Forms.Button Button_Validate;
    }
}