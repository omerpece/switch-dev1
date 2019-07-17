namespace çalışmalar
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
            this.btn1 = new System.Windows.Forms.Button();
            this.txtgiris1 = new System.Windows.Forms.TextBox();
            this.txtgiris2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(7, 64);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(166, 23);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "SORGU";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtgiris1
            // 
            this.txtgiris1.Location = new System.Drawing.Point(12, 12);
            this.txtgiris1.Name = "txtgiris1";
            this.txtgiris1.Size = new System.Drawing.Size(166, 20);
            this.txtgiris1.TabIndex = 1;
            // 
            // txtgiris2
            // 
            this.txtgiris2.Location = new System.Drawing.Point(12, 38);
            this.txtgiris2.Name = "txtgiris2";
            this.txtgiris2.Size = new System.Drawing.Size(166, 20);
            this.txtgiris2.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(185, 161);
            this.Controls.Add(this.txtgiris2);
            this.Controls.Add(this.txtgiris1);
            this.Controls.Add(this.btn1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.TextBox txtgiris1;
        private System.Windows.Forms.TextBox txtgiris2;
    }
}

