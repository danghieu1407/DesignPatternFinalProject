namespace DesignPatternMidterm.View
{
    partial class Payment
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
            this.phuongThuc = new System.Windows.Forms.TextBox();
            this.moMo = new System.Windows.Forms.RadioButton();
            this.tinDung = new System.Windows.Forms.RadioButton();
            this.thanhToantc = new System.Windows.Forms.Button();
            this.tienThua = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tienNhan = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tongtien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // phuongThuc
            // 
            this.phuongThuc.Enabled = false;
            this.phuongThuc.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.phuongThuc.Location = new System.Drawing.Point(148, 159);
            this.phuongThuc.Name = "phuongThuc";
            this.phuongThuc.ReadOnly = true;
            this.phuongThuc.Size = new System.Drawing.Size(316, 33);
            this.phuongThuc.TabIndex = 23;
            this.phuongThuc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // moMo
            // 
            this.moMo.AutoSize = true;
            this.moMo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.moMo.Location = new System.Drawing.Point(371, 74);
            this.moMo.Name = "moMo";
            this.moMo.Size = new System.Drawing.Size(61, 19);
            this.moMo.TabIndex = 22;
            this.moMo.TabStop = true;
            this.moMo.Text = "Momo";
            this.moMo.UseVisualStyleBackColor = true;
            this.moMo.CheckedChanged += new System.EventHandler(this.moMo_CheckedChanged);
            // 
            // tinDung
            // 
            this.tinDung.AutoSize = true;
            this.tinDung.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tinDung.Location = new System.Drawing.Point(234, 74);
            this.tinDung.Name = "tinDung";
            this.tinDung.Size = new System.Drawing.Size(95, 19);
            this.tinDung.TabIndex = 21;
            this.tinDung.TabStop = true;
            this.tinDung.Text = "Thẻ tín dụng";
            this.tinDung.UseVisualStyleBackColor = true;
            this.tinDung.CheckedChanged += new System.EventHandler(this.tinDung_CheckedChanged);
            // 
            // thanhToantc
            // 
            this.thanhToantc.BackColor = System.Drawing.Color.Aquamarine;
            this.thanhToantc.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.thanhToantc.Location = new System.Drawing.Point(88, 379);
            this.thanhToantc.Name = "thanhToantc";
            this.thanhToantc.Size = new System.Drawing.Size(376, 59);
            this.thanhToantc.TabIndex = 20;
            this.thanhToantc.Text = "Hoàn tất thanh toán";
            this.thanhToantc.UseVisualStyleBackColor = false;
            this.thanhToantc.Click += new System.EventHandler(this.thanhToantc_Click);
            // 
            // tienThua
            // 
            this.tienThua.Location = new System.Drawing.Point(207, 334);
            this.tienThua.Name = "tienThua";
            this.tienThua.Size = new System.Drawing.Size(257, 23);
            this.tienThua.TabIndex = 19;
            this.tienThua.TextChanged += new System.EventHandler(this.tienThua_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(91, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Tiền thừa:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(207, 283);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(257, 23);
            this.textBox2.TabIndex = 17;
            // 
            // tienNhan
            // 
            this.tienNhan.AutoSize = true;
            this.tienNhan.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tienNhan.Location = new System.Drawing.Point(89, 281);
            this.tienNhan.Name = "tienNhan";
            this.tienNhan.Size = new System.Drawing.Size(105, 25);
            this.tienNhan.TabIndex = 16;
            this.tienNhan.Text = "Tiền nhận:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(36, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Loại thanh toán:";
            // 
            // tongtien
            // 
            this.tongtien.Location = new System.Drawing.Point(207, 11);
            this.tongtien.Name = "tongtien";
            this.tongtien.Size = new System.Drawing.Size(257, 23);
            this.tongtien.TabIndex = 14;
            this.tongtien.TextChanged += new System.EventHandler(this.tongtien_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(89, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tổng tiền:";
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(482, 450);
            this.Controls.Add(this.phuongThuc);
            this.Controls.Add(this.moMo);
            this.Controls.Add(this.tinDung);
            this.Controls.Add(this.thanhToantc);
            this.Controls.Add(this.tienThua);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.tienNhan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tongtien);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Payment";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox phuongThuc;
        private RadioButton moMo;
        private RadioButton tinDung;
        private Button thanhToantc;
        private TextBox tienThua;
        private Label label3;
        private TextBox textBox2;
        private Label tienNhan;
        private Label label2;
        private TextBox tongtien;
        private Label label1;
    }
}