namespace AppGiaiPhuongTrinh
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_NhapA = new System.Windows.Forms.TextBox();
            this.tb_NhapB = new System.Windows.Forms.TextBox();
            this.tb_NhapC = new System.Windows.Forms.TextBox();
            this.btn_GiaiPT = new System.Windows.Forms.Button();
            this.btb_Reset = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_KetQua = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(245, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giải phương trình bậc 2 ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(25, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập a :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(25, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nhập b :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(25, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 28);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nhập c :";
            // 
            // tb_NhapA
            // 
            this.tb_NhapA.AcceptsReturn = true;
            this.tb_NhapA.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_NhapA.Location = new System.Drawing.Point(144, 172);
            this.tb_NhapA.Name = "tb_NhapA";
            this.tb_NhapA.Size = new System.Drawing.Size(100, 38);
            this.tb_NhapA.TabIndex = 2;
            this.tb_NhapA.TextChanged += new System.EventHandler(this.tb_NhapA_TextChanged);
            this.tb_NhapA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_NhapA_KeyPress);
            // 
            // tb_NhapB
            // 
            this.tb_NhapB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_NhapB.Location = new System.Drawing.Point(144, 243);
            this.tb_NhapB.Name = "tb_NhapB";
            this.tb_NhapB.Size = new System.Drawing.Size(100, 38);
            this.tb_NhapB.TabIndex = 2;
            this.tb_NhapB.TextChanged += new System.EventHandler(this.tb_NhapA_TextChanged);
            this.tb_NhapB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_NhapB_KeyPress);
            // 
            // tb_NhapC
            // 
            this.tb_NhapC.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_NhapC.Location = new System.Drawing.Point(144, 306);
            this.tb_NhapC.Name = "tb_NhapC";
            this.tb_NhapC.Size = new System.Drawing.Size(100, 38);
            this.tb_NhapC.TabIndex = 2;
            this.tb_NhapC.TextChanged += new System.EventHandler(this.tb_NhapA_TextChanged);
            this.tb_NhapC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_NhapC_KeyPress);
            // 
            // btn_GiaiPT
            // 
            this.btn_GiaiPT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(2)))), ((int)(((byte)(242)))));
            this.btn_GiaiPT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GiaiPT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GiaiPT.ForeColor = System.Drawing.Color.White;
            this.btn_GiaiPT.Location = new System.Drawing.Point(338, 156);
            this.btn_GiaiPT.Name = "btn_GiaiPT";
            this.btn_GiaiPT.Size = new System.Drawing.Size(105, 47);
            this.btn_GiaiPT.TabIndex = 3;
            this.btn_GiaiPT.Text = "Giải PT ";
            this.btn_GiaiPT.UseVisualStyleBackColor = false;
            this.btn_GiaiPT.Click += new System.EventHandler(this.btn_GiaiPT_Click);
            // 
            // btb_Reset
            // 
            this.btb_Reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(2)))), ((int)(((byte)(242)))));
            this.btb_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btb_Reset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btb_Reset.ForeColor = System.Drawing.Color.White;
            this.btb_Reset.Location = new System.Drawing.Point(511, 156);
            this.btb_Reset.Name = "btb_Reset";
            this.btb_Reset.Size = new System.Drawing.Size(95, 47);
            this.btb_Reset.TabIndex = 3;
            this.btb_Reset.Text = "Reset";
            this.btb_Reset.UseVisualStyleBackColor = false;
            this.btb_Reset.Click += new System.EventHandler(this.btb_Reset_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(295, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 28);
            this.label5.TabIndex = 1;
            this.label5.Text = "Kết quả  :";
            // 
            // tb_KetQua
            // 
            this.tb_KetQua.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_KetQua.Location = new System.Drawing.Point(325, 284);
            this.tb_KetQua.Multiline = true;
            this.tb_KetQua.Name = "tb_KetQua";
            this.tb_KetQua.ReadOnly = true;
            this.tb_KetQua.Size = new System.Drawing.Size(327, 124);
            this.tb_KetQua.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppGiaiPhuongTrinh.Properties.Resources.nd;
            this.pictureBox1.Location = new System.Drawing.Point(53, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tb_KetQua);
            this.Controls.Add(this.btb_Reset);
            this.Controls.Add(this.btn_GiaiPT);
            this.Controls.Add(this.tb_NhapC);
            this.Controls.Add(this.tb_NhapB);
            this.Controls.Add(this.tb_NhapA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "phần mềm giải phương trình ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_NhapA;
        private System.Windows.Forms.TextBox tb_NhapB;
        private System.Windows.Forms.TextBox tb_NhapC;
        private System.Windows.Forms.Button btn_GiaiPT;
        private System.Windows.Forms.Button btb_Reset;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_KetQua;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

