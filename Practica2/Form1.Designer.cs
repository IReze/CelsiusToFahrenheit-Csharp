namespace Practica2
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
            this.FToC = new System.Windows.Forms.Button();
            this.CtoF = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // FToC
            // 
            this.FToC.BackColor = System.Drawing.Color.DarkGray;
            this.FToC.Location = new System.Drawing.Point(332, 41);
            this.FToC.Name = "FToC";
            this.FToC.Size = new System.Drawing.Size(92, 46);
            this.FToC.TabIndex = 3;
            this.FToC.Text = "F to C ->";
            this.FToC.UseVisualStyleBackColor = false;
            this.FToC.Click += new System.EventHandler(this.FToC_Click);
            // 
            // CtoF
            // 
            this.CtoF.BackColor = System.Drawing.Color.Cyan;
            this.CtoF.Location = new System.Drawing.Point(336, 125);
            this.CtoF.Name = "CtoF";
            this.CtoF.Size = new System.Drawing.Size(88, 41);
            this.CtoF.TabIndex = 4;
            this.CtoF.Text = "<- C to F";
            this.CtoF.UseVisualStyleBackColor = false;
            this.CtoF.Click += new System.EventHandler(this.CtoF_Click);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.CadetBlue;
            this.Clear.Location = new System.Drawing.Point(341, 204);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(83, 45);
            this.Clear.TabIndex = 5;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(124, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(557, 41);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.CtoF);
            this.Controls.Add(this.FToC);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FToC;
        private System.Windows.Forms.Button CtoF;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

