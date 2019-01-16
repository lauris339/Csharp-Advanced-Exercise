namespace PazymiuKnygele
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
            this.label2 = new System.Windows.Forms.Label();
            this.textVidurkis = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboMokinys = new System.Windows.Forms.ComboBox();
            this.textPazymiai = new System.Windows.Forms.TextBox();
            this.textVisiPazymiai = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mokinys";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vidurkis";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textVidurkis
            // 
            this.textVidurkis.Location = new System.Drawing.Point(271, 30);
            this.textVidurkis.Name = "textVidurkis";
            this.textVidurkis.Size = new System.Drawing.Size(131, 20);
            this.textVidurkis.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Pazymiai";
            // 
            // comboMokinys
            // 
            this.comboMokinys.FormattingEnabled = true;
            this.comboMokinys.Location = new System.Drawing.Point(32, 29);
            this.comboMokinys.Name = "comboMokinys";
            this.comboMokinys.Size = new System.Drawing.Size(121, 21);
            this.comboMokinys.TabIndex = 4;
            this.comboMokinys.SelectedIndexChanged += new System.EventHandler(this.comboMokinys_SelectedIndexChanged);
            // 
            // textPazymiai
            // 
            this.textPazymiai.Location = new System.Drawing.Point(35, 113);
            this.textPazymiai.Multiline = true;
            this.textPazymiai.Name = "textPazymiai";
            this.textPazymiai.Size = new System.Drawing.Size(367, 51);
            this.textPazymiai.TabIndex = 5;
            // 
            // textVisiPazymiai
            // 
            this.textVisiPazymiai.Location = new System.Drawing.Point(35, 190);
            this.textVisiPazymiai.Multiline = true;
            this.textVisiPazymiai.Name = "textVisiPazymiai";
            this.textVisiPazymiai.Size = new System.Drawing.Size(377, 248);
            this.textVisiPazymiai.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Visi Pazymiai";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textVisiPazymiai);
            this.Controls.Add(this.textPazymiai);
            this.Controls.Add(this.comboMokinys);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textVidurkis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textVidurkis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboMokinys;
        private System.Windows.Forms.TextBox textPazymiai;
        private System.Windows.Forms.TextBox textVisiPazymiai;
        private System.Windows.Forms.Label label4;
    }
}

