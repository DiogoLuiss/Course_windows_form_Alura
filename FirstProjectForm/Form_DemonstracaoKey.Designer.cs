namespace FirstProjectForm
{
    partial class Form_DemonstracaoKey
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
            this.Text_Input = new System.Windows.Forms.TextBox();
            this.Text_Msg = new System.Windows.Forms.TextBox();
            this.Button_Reset = new System.Windows.Forms.Button();
            this.Label_Minus = new System.Windows.Forms.Label();
            this.Label_Maius = new System.Windows.Forms.Label();
            this.Label_Upper = new System.Windows.Forms.Label();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.Label_Lower = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // Text_Input
            // 
            this.Text_Input.Location = new System.Drawing.Point(8, 8);
            this.Text_Input.Name = "Text_Input";
            this.Text_Input.Size = new System.Drawing.Size(100, 20);
            this.Text_Input.TabIndex = 0;
            this.Text_Input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Text_Input_KeyDown);
            // 
            // Text_Msg
            // 
            this.Text_Msg.Location = new System.Drawing.Point(8, 40);
            this.Text_Msg.Multiline = true;
            this.Text_Msg.Name = "Text_Msg";
            this.Text_Msg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Text_Msg.Size = new System.Drawing.Size(304, 232);
            this.Text_Msg.TabIndex = 0;
            this.Text_Msg.TabStop = false;
            // 
            // Button_Reset
            // 
            this.Button_Reset.Location = new System.Drawing.Point(328, 8);
            this.Button_Reset.Name = "Button_Reset";
            this.Button_Reset.Size = new System.Drawing.Size(75, 28);
            this.Button_Reset.TabIndex = 1;
            this.Button_Reset.Text = "Limpar";
            this.Button_Reset.UseVisualStyleBackColor = true;
            this.Button_Reset.Click += new System.EventHandler(this.Button_Reset_Click);
            // 
            // Label_Minus
            // 
            this.Label_Minus.Location = new System.Drawing.Point(320, 104);
            this.Label_Minus.Name = "Label_Minus";
            this.Label_Minus.Size = new System.Drawing.Size(40, 16);
            this.Label_Minus.TabIndex = 2;
            this.Label_Minus.Text = "Minus.";
            // 
            // Label_Maius
            // 
            this.Label_Maius.Location = new System.Drawing.Point(320, 56);
            this.Label_Maius.Name = "Label_Maius";
            this.Label_Maius.Size = new System.Drawing.Size(40, 16);
            this.Label_Maius.TabIndex = 2;
            this.Label_Maius.Text = "Maius.";
            // 
            // Label_Upper
            // 
            this.Label_Upper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Label_Upper.Location = new System.Drawing.Point(368, 56);
            this.Label_Upper.Name = "Label_Upper";
            this.Label_Upper.Size = new System.Drawing.Size(32, 23);
            this.Label_Upper.TabIndex = 2;
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // Label_Lower
            // 
            this.Label_Lower.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Label_Lower.Location = new System.Drawing.Point(368, 104);
            this.Label_Lower.Name = "Label_Lower";
            this.Label_Lower.Size = new System.Drawing.Size(32, 23);
            this.Label_Lower.TabIndex = 2;
            // 
            // Form_DemonstracaoKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 281);
            this.Controls.Add(this.Label_Maius);
            this.Controls.Add(this.Label_Lower);
            this.Controls.Add(this.Label_Upper);
            this.Controls.Add(this.Label_Minus);
            this.Controls.Add(this.Button_Reset);
            this.Controls.Add(this.Text_Msg);
            this.Controls.Add(this.Text_Input);
            this.Name = "Form_DemonstracaoKey";
            this.Text = "Demonstração Evnto Key";
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Text_Input;
        private System.Windows.Forms.TextBox Text_Msg;
        private System.Windows.Forms.Button Button_Reset;
        private System.Windows.Forms.Label Label_Minus;
        private System.Windows.Forms.Label Label_Maius;
        private System.Windows.Forms.Label Label_Upper;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.Label Label_Lower;
    }
}