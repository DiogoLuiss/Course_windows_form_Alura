namespace FirstProjectForm
{
    partial class Form_MouseCapture
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
            this.Button_Event = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button_Event
            // 
            this.Button_Event.Location = new System.Drawing.Point(128, 88);
            this.Button_Event.Name = "Button_Event";
            this.Button_Event.Size = new System.Drawing.Size(244, 176);
            this.Button_Event.TabIndex = 0;
            this.Button_Event.Text = "button1";
            this.Button_Event.UseVisualStyleBackColor = true;
            this.Button_Event.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_Event_MouseDown);
            // 
            // Form_MouseCapture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 328);
            this.Controls.Add(this.Button_Event);
            this.Name = "Form_MouseCapture";
            this.Text = "Form_MouseCapture";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseCapture_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button_Event;
    }
}