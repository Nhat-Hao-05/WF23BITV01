namespace _9thagn3
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
            this.TxtUSD = new System.Windows.Forms.TextBox();
            this.LblVND = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnConvert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtUSD
            // 
            this.TxtUSD.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.TxtUSD.Location = new System.Drawing.Point(47, 107);
            this.TxtUSD.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.TxtUSD.Name = "TxtUSD";
            this.TxtUSD.Size = new System.Drawing.Size(236, 34);
            this.TxtUSD.TabIndex = 0;
            this.TxtUSD.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // LblVND
            // 
            this.LblVND.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LblVND.Location = new System.Drawing.Point(47, 197);
            this.LblVND.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.LblVND.Name = "LblVND";
            this.LblVND.Size = new System.Drawing.Size(236, 34);
            this.LblVND.TabIndex = 1;
            this.LblVND.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(42, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhập số tiền ( USD )";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(44, 166);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tiền Nhận ( VNĐ )";
            // 
            // BtnConvert
            // 
            this.BtnConvert.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.BtnConvert.Location = new System.Drawing.Point(296, 107);
            this.BtnConvert.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.BtnConvert.Name = "BtnConvert";
            this.BtnConvert.Size = new System.Drawing.Size(122, 37);
            this.BtnConvert.TabIndex = 4;
            this.BtnConvert.Text = "Xác nhận";
            this.BtnConvert.UseVisualStyleBackColor = true;
            this.BtnConvert.Click += new System.EventHandler(this.BtnConvert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 514);
            this.Controls.Add(this.BtnConvert);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblVND);
            this.Controls.Add(this.TxtUSD);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Đổi tiền";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtUSD;
        private System.Windows.Forms.TextBox LblVND;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnConvert;
    }
}

