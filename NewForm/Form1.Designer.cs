namespace NewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.nama = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FS = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nohp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panggilan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nama
            // 
            this.nama.Location = new System.Drawing.Point(31, 28);
            this.nama.Name = "nama";
            this.nama.Size = new System.Drawing.Size(225, 20);
            this.nama.TabIndex = 0;
            this.nama.TextChanged += new System.EventHandler(this.nick_TextChanged);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(31, 222);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(225, 37);
            this.submitButton.TabIndex = 6;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(97, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nama lengkap";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nim
            // 
            this.nim.Location = new System.Drawing.Point(86, 103);
            this.nim.Name = "nim";
            this.nim.Size = new System.Drawing.Size(105, 20);
            this.nim.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(54, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fakultas / Sekolah / Program Studi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(120, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "NIM";
            // 
            // FS
            // 
            this.FS.Location = new System.Drawing.Point(86, 143);
            this.FS.Name = "FS";
            this.FS.Size = new System.Drawing.Size(105, 20);
            this.FS.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(107, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nomor HP";
            // 
            // nohp
            // 
            this.nohp.Location = new System.Drawing.Point(62, 181);
            this.nohp.Name = "nohp";
            this.nohp.Size = new System.Drawing.Size(171, 20);
            this.nohp.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(36, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Jangan lupa bayar uang pendaftaran ya :3";
            // 
            // panggilan
            // 
            this.panggilan.Location = new System.Drawing.Point(86, 67);
            this.panggilan.Name = "panggilan";
            this.panggilan.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panggilan.Size = new System.Drawing.Size(105, 20);
            this.panggilan.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(92, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Nama panggilan";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = global::NewForm.Properties.Resources.pasopati2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panggilan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nohp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.nama);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(292, 289);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(292, 289);
            this.Name = "Form1";
            this.Text = "Unit Panahan Pasopati";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nama;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nohp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox panggilan;
        private System.Windows.Forms.Label label6;
    }
}

