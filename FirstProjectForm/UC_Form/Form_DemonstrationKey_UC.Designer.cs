namespace FirstProjectForm.UC_Form
{
    partial class Form_DemonstrationKey_UC
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
            this.Label_Maius = new System.Windows.Forms.Label();
            this.Label_Lower = new System.Windows.Forms.Label();
            this.Label_Upper = new System.Windows.Forms.Label();
            this.Label_Minus = new System.Windows.Forms.Label();
            this.Button_Reset = new System.Windows.Forms.Button();
            this.Text_Msg = new System.Windows.Forms.TextBox();
            this.Text_Input = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Label_Maius
            // 
            this.Label_Maius.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Maius.Location = new System.Drawing.Point(327, 76);
            this.Label_Maius.Name = "Label_Maius";
            this.Label_Maius.Size = new System.Drawing.Size(40, 16);
            this.Label_Maius.TabIndex = 6;
            this.Label_Maius.Text = "Maius.";
            // 
            // Label_Lower
            // 
            this.Label_Lower.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Lower.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Label_Lower.Location = new System.Drawing.Point(375, 124);
            this.Label_Lower.Name = "Label_Lower";
            this.Label_Lower.Size = new System.Drawing.Size(32, 23);
            this.Label_Lower.TabIndex = 7;
            // 
            // Label_Upper
            // 
            this.Label_Upper.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Upper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Label_Upper.Location = new System.Drawing.Point(375, 76);
            this.Label_Upper.Name = "Label_Upper";
            this.Label_Upper.Size = new System.Drawing.Size(32, 23);
            this.Label_Upper.TabIndex = 8;
            // 
            // Label_Minus
            // 
            this.Label_Minus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Minus.Location = new System.Drawing.Point(327, 124);
            this.Label_Minus.Name = "Label_Minus";
            this.Label_Minus.Size = new System.Drawing.Size(40, 16);
            this.Label_Minus.TabIndex = 9;
            this.Label_Minus.Text = "Minus.";
            // 
            // Button_Reset
            // 
            this.Button_Reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Reset.Location = new System.Drawing.Point(335, 28);
            this.Button_Reset.Name = "Button_Reset";
            this.Button_Reset.Size = new System.Drawing.Size(75, 28);
            this.Button_Reset.TabIndex = 5;
            this.Button_Reset.Text = "Limpar";
            this.Button_Reset.UseVisualStyleBackColor = true;
            this.Button_Reset.Click += new System.EventHandler(this.Button_Reset_Click);
            // 
            // Text_Msg
            // 
            this.Text_Msg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Text_Msg.Location = new System.Drawing.Point(15, 60);
            this.Text_Msg.Multiline = true;
            this.Text_Msg.Name = "Text_Msg";
            this.Text_Msg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Text_Msg.Size = new System.Drawing.Size(304, 232);
            this.Text_Msg.TabIndex = 3;
            this.Text_Msg.TabStop = false;
            // 
            // Text_Input
            // 
            this.Text_Input.Location = new System.Drawing.Point(15, 28);
            this.Text_Input.Name = "Text_Input";
            this.Text_Input.Size = new System.Drawing.Size(100, 20);
            this.Text_Input.TabIndex = 4;
            this.Text_Input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Text_Input_KeyDown);
            // 
            // Form_DemonstrationKey_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Label_Maius);
            this.Controls.Add(this.Label_Lower);
            this.Controls.Add(this.Label_Upper);
            this.Controls.Add(this.Label_Minus);
            this.Controls.Add(this.Button_Reset);
            this.Controls.Add(this.Text_Msg);
            this.Controls.Add(this.Text_Input);
            this.Name = "Form_DemonstrationKey_UC";
            this.Size = new System.Drawing.Size(425, 320);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Maius;
        private System.Windows.Forms.Label Label_Lower;
        private System.Windows.Forms.Label Label_Upper;
        private System.Windows.Forms.Label Label_Minus;
        private System.Windows.Forms.Button Button_Reset;
        private System.Windows.Forms.TextBox Text_Msg;
        private System.Windows.Forms.TextBox Text_Input;
    }
}
