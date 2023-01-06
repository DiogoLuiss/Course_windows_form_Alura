namespace FirstProjectForm
{
    partial class Form_Question
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
            this.label1 = new System.Windows.Forms.Label();
            this.Button_Ok = new System.Windows.Forms.Button();
            this.Button_Cancel = new System.Windows.Forms.Button();
            this.Picture_Img = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Img)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Você deseja validar a senha?";
            // 
            // Button_Ok
            // 
            this.Button_Ok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Ok.Location = new System.Drawing.Point(147, 60);
            this.Button_Ok.Name = "Button_Ok";
            this.Button_Ok.Size = new System.Drawing.Size(115, 23);
            this.Button_Ok.TabIndex = 0;
            this.Button_Ok.Text = "Sim, Continar";
            this.Button_Ok.UseVisualStyleBackColor = true;
            this.Button_Ok.Click += new System.EventHandler(this.Button_Ok_Click);
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Cancel.Location = new System.Drawing.Point(147, 89);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(115, 23);
            this.Button_Cancel.TabIndex = 1;
            this.Button_Cancel.Text = "Não, Parar";
            this.Button_Cancel.UseVisualStyleBackColor = true;
            this.Button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // Picture_Img
            // 
            this.Picture_Img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Picture_Img.Image = global::FirstProjectForm.Properties.Resources.ask;
            this.Picture_Img.Location = new System.Drawing.Point(40, 60);
            this.Picture_Img.Name = "Picture_Img";
            this.Picture_Img.Size = new System.Drawing.Size(64, 64);
            this.Picture_Img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Picture_Img.TabIndex = 2;
            this.Picture_Img.TabStop = false;
            // 
            // Form_Question
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 151);
            this.Controls.Add(this.Picture_Img);
            this.Controls.Add(this.Button_Cancel);
            this.Controls.Add(this.Button_Ok);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Question";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Questão";
            this.Load += new System.EventHandler(this.Form_Question_Load);
            this.Shown += new System.EventHandler(this.Form_Question_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Button_Ok;
        private System.Windows.Forms.Button Button_Cancel;
        private System.Windows.Forms.PictureBox Picture_Img;
    }
}