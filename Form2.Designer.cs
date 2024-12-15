namespace spotify
{
    partial class Form2
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
            textBox1 = new TextBox();
            label3 = new Label();
            elipseTool1 = new ElipseToolDemo.ElipseTool();
            label4 = new Label();
            button1 = new Button();
            elipseTool2 = new ElipseToolDemo.ElipseTool();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(15, 108);
            label1.Name = "label1";
            label1.Size = new Size(274, 35);
            label1.TabIndex = 0;
            label1.Text = "E-posta adresin nedir?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.White;
            label2.Location = new Point(159, 17);
            label2.Name = "label2";
            label2.Size = new Size(127, 24);
            label2.TabIndex = 1;
            label2.Text = "Hesap oluştur";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(64, 64, 64);
            textBox1.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(15, 161);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(385, 28);
            textBox1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 235);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 3;
            label3.Text = "label3";
            // 
            // elipseTool1
            // 
            elipseTool1.CornerRadius = 30;
            elipseTool1.TargetControl = textBox1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.White;
            label4.Location = new Point(15, 214);
            label4.Name = "label4";
            label4.Size = new Size(343, 21);
            label4.TabIndex = 4;
            label4.Text = "Daha sonra bu e-postayı onaylaman gerekecek.";
            // 
            // button1
            // 
            button1.BackColor = Color.Gray;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(159, 270);
            button1.Name = "button1";
            button1.Size = new Size(123, 41);
            button1.TabIndex = 5;
            button1.Text = "Sonraki";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // elipseTool2
            // 
            elipseTool2.CornerRadius = 45;
            elipseTool2.TargetControl = button1;
            // 
            // button2
            // 
            button2.Location = new Point(15, 12);
            button2.Name = "button2";
            button2.Size = new Size(49, 29);
            button2.TabIndex = 6;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(447, 748);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Ücretsiz kaydol";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private ElipseToolDemo.ElipseTool elipseTool1;
        private Label label4;
        private Button button1;
        private ElipseToolDemo.ElipseTool elipseTool2;
        private Button button2;
    }
}