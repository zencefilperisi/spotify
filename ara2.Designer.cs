namespace spotify
{
    partial class Ara2
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
            panel1 = new Panel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(155, 323);
            label1.Name = "label1";
            label1.Size = new Size(112, 24);
            label1.TabIndex = 0;
            label1.Text = "Sevdiğini çal";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.White;
            label2.Location = new Point(93, 347);
            label2.Name = "label2";
            label2.Size = new Size(270, 18);
            label2.TabIndex = 1;
            label2.Text = "Sanatçı, şarkı, podcast ve daha fazlasını ara.";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(64, 64, 64);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(1, 1);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(445, 27);
            textBox1.TabIndex = 2;
            textBox1.Text = "Ne dinlemek istiyorsun?";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.Click += textBox1_Click;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Location = new Point(1, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(445, 718);
            panel1.TabIndex = 5;
            // 
            // Ara2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(447, 748);
            Controls.Add(panel1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Ara2";
            Text = "ara2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Panel panel1;
    }
}