namespace spotify
{
    partial class Ara
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ara));
            button11 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button11
            // 
            button11.ForeColor = Color.Black;
            button11.Location = new Point(19, 61);
            button11.Name = "button11";
            button11.Size = new Size(42, 29);
            button11.TabIndex = 29;
            button11.Text = "button11";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(83, 66);
            label1.Name = "label1";
            label1.Size = new Size(39, 24);
            label1.TabIndex = 30;
            label1.Text = "Ara";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBox1.ForeColor = Color.DarkGray;
            textBox1.Location = new Point(19, 112);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(407, 32);
            textBox1.TabIndex = 31;
            textBox1.Text = "Ne dinlemek istiyorsun?";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.Click += textBox1_Click;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(22, 115);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(23, 25);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 32;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Location = new Point(19, 141);
            panel1.Name = "panel1";
            panel1.Size = new Size(407, 602);
            panel1.TabIndex = 33;
            // 
            // Ara
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(447, 748);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button11);
            ForeColor = Color.White;
            Name = "Ara";
            Text = "Ara";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button11;
        private Label label1;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private Panel panel1;
    }
}