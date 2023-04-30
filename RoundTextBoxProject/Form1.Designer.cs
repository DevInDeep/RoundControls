namespace RoundTextBoxProject
{
    partial class Form1
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
            this.roundControl1 = new RoundTextBoxProject.RoundControl();
            this.SuspendLayout();
            // 
            // roundControl1
            // 
            this.roundControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(3)))), ((int)(((byte)(62)))), ((int)(((byte)(49)))));
            this.roundControl1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(205)))), ((int)(((byte)(255)))));
            this.roundControl1.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.roundControl1.BorderWidth = 3F;
            this.roundControl1.Location = new System.Drawing.Point(418, 118);
            this.roundControl1.Name = "roundControl1";
            this.roundControl1.Radius = 20;
            this.roundControl1.Size = new System.Drawing.Size(513, 511);
            this.roundControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(1459, 751);
            this.Controls.Add(this.roundControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private RoundControl roundControl1;
    }
}

