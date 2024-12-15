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
            button2 = new Button();
            label2 = new Label();
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
            // button2
            // 
            button2.BackColor = Color.White;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(132, 336);
            button2.Name = "button2";
            button2.Size = new Size(123, 41);
            button2.TabIndex = 9;
            button2.Text = "Sonraki";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
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
            // Form6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(447, 748);
            Controls.Add(label2);
            Controls.Add(button2);
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
        private Button button2;
        private Label label2;
    }
}