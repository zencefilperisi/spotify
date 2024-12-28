namespace spotify
{
    partial class Form6
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
            button1 = new Button();
            label2 = new Label();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(21, 79);
            label1.Name = "label1";
            label1.Size = new Size(208, 35);
            label1.TabIndex = 1;
            label1.Text = "Cinsiyetin nedir?";
            // 
            // button1
            // 
            button1.Location = new Point(21, 28);
            button1.Name = "button1";
            button1.Size = new Size(50, 29);
            button1.TabIndex = 8;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.White;
            label2.Location = new Point(161, 33);
            label2.Name = "label2";
            label2.Size = new Size(127, 24);
            label2.TabIndex = 10;
            label2.Text = "Hesap oluştur";
            // 
            // button3
            // 
            button3.BackColor = Color.Black;
            button3.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button3.ForeColor = Color.White;
            button3.Location = new Point(25, 144);
            button3.Name = "button3";
            button3.Size = new Size(94, 46);
            button3.TabIndex = 11;
            button3.Text = "Kadın";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Black;
            button4.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button4.ForeColor = Color.White;
            button4.Location = new Point(133, 144);
            button4.Name = "button4";
            button4.Size = new Size(94, 46);
            button4.TabIndex = 12;
            button4.Text = "Erkek";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Black;
            button5.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button5.ForeColor = Color.White;
            button5.Location = new Point(242, 144);
            button5.Name = "button5";
            button5.Size = new Size(94, 46);
            button5.TabIndex = 13;
            button5.Text = "Diğer";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Black;
            button6.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button6.ForeColor = Color.White;
            button6.Location = new Point(24, 206);
            button6.Name = "button6";
            button6.Size = new Size(203, 46);
            button6.TabIndex = 14;
            button6.Text = "Belirtmek istemiyorum";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(447, 748);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form6";
            Text = "Form6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Label label2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}