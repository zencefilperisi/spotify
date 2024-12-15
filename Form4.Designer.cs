namespace spotify
{
    partial class Form4
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
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            comboBox1 = new ComboBox();
            panel1 = new Panel();
            textBox1 = new TextBox();
            comboBox2 = new ComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 89);
            label1.Name = "label1";
            label1.Size = new Size(263, 35);
            label1.TabIndex = 0;
            label1.Text = "Doğum tarihin nedir?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.White;
            label2.Location = new Point(158, 23);
            label2.Name = "label2";
            label2.Size = new Size(127, 24);
            label2.TabIndex = 2;
            label2.Text = "Hesap oluştur";
            // 
            // button1
            // 
            button1.Location = new Point(12, 18);
            button1.Name = "button1";
            button1.Size = new Size(50, 29);
            button1.TabIndex = 8;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(136, 276);
            button2.Name = "button2";
            button2.Size = new Size(123, 41);
            button2.TabIndex = 9;
            button2.Text = "Sonraki";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Calibri", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31" });
            comboBox1.Location = new Point(24, 29);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(85, 30);
            comboBox1.TabIndex = 10;
            comboBox1.Text = "Seçiniz";
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(comboBox1);
            panel1.Location = new Point(45, 143);
            panel1.Name = "panel1";
            panel1.Size = new Size(312, 87);
            panel1.TabIndex = 11;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBox1.Location = new Point(195, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(85, 29);
            textBox1.TabIndex = 13;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Calibri", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12" });
            comboBox2.Location = new Point(109, 29);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(85, 30);
            comboBox2.TabIndex = 12;
            comboBox2.Text = "Seçiniz";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(447, 748);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form4";
            Text = "Doğum tarihi";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private ComboBox comboBox1;
        private Panel panel1;
        private TextBox textBox1;
        private ComboBox comboBox2;
    }
}