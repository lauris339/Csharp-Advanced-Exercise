namespace VartotojuDuomenuPaieska
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtIeskoti = new System.Windows.Forms.TextBox();
            this.bOK = new System.Windows.Forms.Button();
            this.bFilePath = new System.Windows.Forms.Button();
            this.txtRezultatai = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ieskoti";
            // 
            // txtIeskoti
            // 
            this.txtIeskoti.Location = new System.Drawing.Point(70, 56);
            this.txtIeskoti.Name = "txtIeskoti";
            this.txtIeskoti.Size = new System.Drawing.Size(100, 20);
            this.txtIeskoti.TabIndex = 1;
            this.txtIeskoti.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // bOK
            // 
            this.bOK.Location = new System.Drawing.Point(178, 56);
            this.bOK.Name = "bOK";
            this.bOK.Size = new System.Drawing.Size(40, 23);
            this.bOK.TabIndex = 2;
            this.bOK.Text = "OK";
            this.bOK.UseVisualStyleBackColor = true;
            this.bOK.Click += new System.EventHandler(this.bOK_Click);
            // 
            // bFilePath
            // 
            this.bFilePath.Location = new System.Drawing.Point(13, 13);
            this.bFilePath.Name = "bFilePath";
            this.bFilePath.Size = new System.Drawing.Size(89, 23);
            this.bFilePath.TabIndex = 3;
            this.bFilePath.Text = "Open File";
            this.bFilePath.UseVisualStyleBackColor = true;
            this.bFilePath.Click += new System.EventHandler(this.bFilePath_Click);
            // 
            // txtRezultatai
            // 
            this.txtRezultatai.Location = new System.Drawing.Point(70, 117);
            this.txtRezultatai.Name = "txtRezultatai";
            this.txtRezultatai.Size = new System.Drawing.Size(100, 20);
            this.txtRezultatai.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Rezultatai";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 285);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRezultatai);
            this.Controls.Add(this.bFilePath);
            this.Controls.Add(this.bOK);
            this.Controls.Add(this.txtIeskoti);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIeskoti;
        private System.Windows.Forms.Button bOK;
        private System.Windows.Forms.Button bFilePath;
        private System.Windows.Forms.TextBox txtRezultatai;
        private System.Windows.Forms.Label label2;
    }
}

