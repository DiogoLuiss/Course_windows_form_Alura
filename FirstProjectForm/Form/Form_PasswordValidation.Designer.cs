namespace FirstProjectForm
{
    partial class Form_PasswordValidation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_PasswordValidation));
            this.Text_Password = new System.Windows.Forms.TextBox();
            this.Label_Result = new System.Windows.Forms.Label();
            this.Button_Reset = new System.Windows.Forms.Button();
            this.Button_Show_Password = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Text_Password
            // 
            this.Text_Password.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Text_Password.Location = new System.Drawing.Point(12, 45);
            this.Text_Password.Name = "Text_Password";
            this.Text_Password.PasswordChar = '•';
            this.Text_Password.Size = new System.Drawing.Size(218, 20);
            this.Text_Password.TabIndex = 0;
            this.Text_Password.TextChanged += new System.EventHandler(this.Text_Password_TextChanged);
            this.Text_Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Text_Password_KeyDown);
            // 
            // Label_Result
            // 
            this.Label_Result.AutoSize = true;
            this.Label_Result.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Result.Location = new System.Drawing.Point(12, 90);
            this.Label_Result.Name = "Label_Result";
            this.Label_Result.Size = new System.Drawing.Size(0, 19);
            this.Label_Result.TabIndex = 1;
            // 
            // Button_Reset
            // 
            this.Button_Reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Reset.Location = new System.Drawing.Point(245, 42);
            this.Button_Reset.Name = "Button_Reset";
            this.Button_Reset.Size = new System.Drawing.Size(111, 23);
            this.Button_Reset.TabIndex = 2;
            this.Button_Reset.Text = "Limpar";
            this.Button_Reset.UseVisualStyleBackColor = true;
            this.Button_Reset.Click += new System.EventHandler(this.Button_Reset_Click);
            // 
            // Button_Show_Password
            // 
            this.Button_Show_Password.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Show_Password.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Show_Password.Location = new System.Drawing.Point(245, 71);
            this.Button_Show_Password.Name = "Button_Show_Password";
            this.Button_Show_Password.Size = new System.Drawing.Size(111, 23);
            this.Button_Show_Password.TabIndex = 2;
            this.Button_Show_Password.Text = "Mostrar Senha";
            this.Button_Show_Password.UseVisualStyleBackColor = true;
            this.Button_Show_Password.Click += new System.EventHandler(this.Button_Show_Password_Click);
            // 
            // Form_PasswordValidation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 154);
            this.Controls.Add(this.Button_Show_Password);
            this.Controls.Add(this.Button_Reset);
            this.Controls.Add(this.Label_Result);
            this.Controls.Add(this.Text_Password);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_PasswordValidation";
            this.Text = "Validação de senhas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Text_Password;
        private System.Windows.Forms.Label Label_Result;
        private System.Windows.Forms.Button Button_Reset;
        private System.Windows.Forms.Button Button_Show_Password;
    }
}