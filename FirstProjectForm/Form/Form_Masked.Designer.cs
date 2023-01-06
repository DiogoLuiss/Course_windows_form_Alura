namespace FirstProjectForm
{
    partial class Form_Masked
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Masked));
            this.Masked_Text_Box = new System.Windows.Forms.MaskedTextBox();
            this.Label_Content = new System.Windows.Forms.Label();
            this.Tabel_Masked_Active = new System.Windows.Forms.Label();
            this.Button_Hours = new System.Windows.Forms.Button();
            this.Button_Cep = new System.Windows.Forms.Button();
            this.Button_Coin = new System.Windows.Forms.Button();
            this.Button_Date = new System.Windows.Forms.Button();
            this.Button_Password = new System.Windows.Forms.Button();
            this.Button_Tel = new System.Windows.Forms.Button();
            this.Button_Show_Content = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Masked_Text_Box
            // 
            this.Masked_Text_Box.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Masked_Text_Box.Location = new System.Drawing.Point(23, 31);
            this.Masked_Text_Box.Mask = "0000,000";
            this.Masked_Text_Box.Name = "Masked_Text_Box";
            this.Masked_Text_Box.Size = new System.Drawing.Size(258, 26);
            this.Masked_Text_Box.TabIndex = 0;
            // 
            // Label_Content
            // 
            this.Label_Content.AutoSize = true;
            this.Label_Content.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Content.Location = new System.Drawing.Point(23, 246);
            this.Label_Content.Name = "Label_Content";
            this.Label_Content.Size = new System.Drawing.Size(0, 19);
            this.Label_Content.TabIndex = 1;
            // 
            // Tabel_Masked_Active
            // 
            this.Tabel_Masked_Active.AutoSize = true;
            this.Tabel_Masked_Active.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tabel_Masked_Active.Location = new System.Drawing.Point(23, 75);
            this.Tabel_Masked_Active.Name = "Tabel_Masked_Active";
            this.Tabel_Masked_Active.Size = new System.Drawing.Size(0, 20);
            this.Tabel_Masked_Active.TabIndex = 2;
            // 
            // Button_Hours
            // 
            this.Button_Hours.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Hours.Location = new System.Drawing.Point(23, 110);
            this.Button_Hours.Name = "Button_Hours";
            this.Button_Hours.Size = new System.Drawing.Size(82, 37);
            this.Button_Hours.TabIndex = 3;
            this.Button_Hours.Text = "Hora";
            this.Button_Hours.UseVisualStyleBackColor = true;
            this.Button_Hours.Click += new System.EventHandler(this.Button_Hours_Click);
            // 
            // Button_Cep
            // 
            this.Button_Cep.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Cep.Location = new System.Drawing.Point(111, 110);
            this.Button_Cep.Name = "Button_Cep";
            this.Button_Cep.Size = new System.Drawing.Size(82, 37);
            this.Button_Cep.TabIndex = 3;
            this.Button_Cep.Text = "Cep";
            this.Button_Cep.UseVisualStyleBackColor = true;
            this.Button_Cep.Click += new System.EventHandler(this.Button_Cep_Click);
            // 
            // Button_Coin
            // 
            this.Button_Coin.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Coin.Location = new System.Drawing.Point(199, 110);
            this.Button_Coin.Name = "Button_Coin";
            this.Button_Coin.Size = new System.Drawing.Size(82, 37);
            this.Button_Coin.TabIndex = 3;
            this.Button_Coin.Text = "Moeda";
            this.Button_Coin.UseVisualStyleBackColor = true;
            this.Button_Coin.Click += new System.EventHandler(this.Button_Coin_Click);
            // 
            // Button_Date
            // 
            this.Button_Date.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Date.Location = new System.Drawing.Point(23, 153);
            this.Button_Date.Name = "Button_Date";
            this.Button_Date.Size = new System.Drawing.Size(82, 37);
            this.Button_Date.TabIndex = 3;
            this.Button_Date.Text = "Data";
            this.Button_Date.UseVisualStyleBackColor = true;
            this.Button_Date.Click += new System.EventHandler(this.Button_Date_Click);
            // 
            // Button_Password
            // 
            this.Button_Password.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Password.Location = new System.Drawing.Point(111, 153);
            this.Button_Password.Name = "Button_Password";
            this.Button_Password.Size = new System.Drawing.Size(82, 37);
            this.Button_Password.TabIndex = 3;
            this.Button_Password.Text = "Senha";
            this.Button_Password.UseVisualStyleBackColor = true;
            this.Button_Password.Click += new System.EventHandler(this.Button_Password_Click);
            // 
            // Button_Tel
            // 
            this.Button_Tel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Tel.Location = new System.Drawing.Point(199, 153);
            this.Button_Tel.Name = "Button_Tel";
            this.Button_Tel.Size = new System.Drawing.Size(82, 37);
            this.Button_Tel.TabIndex = 3;
            this.Button_Tel.Text = "Telefone";
            this.Button_Tel.UseVisualStyleBackColor = true;
            this.Button_Tel.Click += new System.EventHandler(this.Button_Tel_Click);
            // 
            // Button_Show_Content
            // 
            this.Button_Show_Content.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Show_Content.Location = new System.Drawing.Point(23, 196);
            this.Button_Show_Content.Name = "Button_Show_Content";
            this.Button_Show_Content.Size = new System.Drawing.Size(258, 37);
            this.Button_Show_Content.TabIndex = 3;
            this.Button_Show_Content.Text = "Mostrar conteudo";
            this.Button_Show_Content.UseVisualStyleBackColor = true;
            this.Button_Show_Content.Click += new System.EventHandler(this.Button_Show_Content_Click);
            // 
            // Form_Masked
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 283);
            this.Controls.Add(this.Button_Show_Content);
            this.Controls.Add(this.Button_Tel);
            this.Controls.Add(this.Button_Password);
            this.Controls.Add(this.Button_Date);
            this.Controls.Add(this.Button_Coin);
            this.Controls.Add(this.Button_Cep);
            this.Controls.Add(this.Button_Hours);
            this.Controls.Add(this.Tabel_Masked_Active);
            this.Controls.Add(this.Label_Content);
            this.Controls.Add(this.Masked_Text_Box);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Masked";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox Masked_Text_Box;
        private System.Windows.Forms.Label Label_Content;
        private System.Windows.Forms.Label Tabel_Masked_Active;
        private System.Windows.Forms.Button Button_Hours;
        private System.Windows.Forms.Button Button_Cep;
        private System.Windows.Forms.Button Button_Coin;
        private System.Windows.Forms.Button Button_Date;
        private System.Windows.Forms.Button Button_Password;
        private System.Windows.Forms.Button Button_Tel;
        private System.Windows.Forms.Button Button_Show_Content;
    }
}