namespace FirstProjectForm.UC_Form
{
    partial class Form_FileImg_UC
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
            this.Label_FileImg = new System.Windows.Forms.Label();
            this.Picture_FileImg = new System.Windows.Forms.PictureBox();
            this.Button_Change_Color = new System.Windows.Forms.Button();
            this.Button_Change_Font = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_FileImg)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_FileImg
            // 
            this.Label_FileImg.AutoSize = true;
            this.Label_FileImg.Location = new System.Drawing.Point(16, 20);
            this.Label_FileImg.Name = "Label_FileImg";
            this.Label_FileImg.Size = new System.Drawing.Size(35, 13);
            this.Label_FileImg.TabIndex = 2;
            this.Label_FileImg.Text = "label1";
            // 
            // Picture_FileImg
            // 
            this.Picture_FileImg.Location = new System.Drawing.Point(19, 55);
            this.Picture_FileImg.Name = "Picture_FileImg";
            this.Picture_FileImg.Size = new System.Drawing.Size(185, 135);
            this.Picture_FileImg.TabIndex = 3;
            this.Picture_FileImg.TabStop = false;
            // 
            // Button_Change_Color
            // 
            this.Button_Change_Color.Location = new System.Drawing.Point(210, 54);
            this.Button_Change_Color.Name = "Button_Change_Color";
            this.Button_Change_Color.Size = new System.Drawing.Size(80, 25);
            this.Button_Change_Color.TabIndex = 4;
            this.Button_Change_Color.Text = "Cor";
            this.Button_Change_Color.UseVisualStyleBackColor = true;
            this.Button_Change_Color.Click += new System.EventHandler(this.Button_Change_Color_Click);
            // 
            // Button_Change_Font
            // 
            this.Button_Change_Font.Location = new System.Drawing.Point(210, 85);
            this.Button_Change_Font.Name = "Button_Change_Font";
            this.Button_Change_Font.Size = new System.Drawing.Size(80, 25);
            this.Button_Change_Font.TabIndex = 4;
            this.Button_Change_Font.Text = "Fonte";
            this.Button_Change_Font.UseVisualStyleBackColor = true;
            this.Button_Change_Font.Click += new System.EventHandler(this.Button_Change_Font_Click);
            // 
            // Form_FileImg_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Button_Change_Font);
            this.Controls.Add(this.Button_Change_Color);
            this.Controls.Add(this.Picture_FileImg);
            this.Controls.Add(this.Label_FileImg);
            this.Name = "Form_FileImg_UC";
            this.Size = new System.Drawing.Size(887, 227);
            ((System.ComponentModel.ISupportInitialize)(this.Picture_FileImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Picture_FileImg;
        private System.Windows.Forms.Label Label_FileImg;
        private System.Windows.Forms.Button Button_Change_Color;
        private System.Windows.Forms.Button Button_Change_Font;
    }
}
