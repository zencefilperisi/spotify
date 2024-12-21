namespace spotify
{
    partial class Form5
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
            txt_eposta = new TextBox();
            txt_parola = new TextBox();
            button1 = new Button();
            elipseTool1 = new ElipseToolDemo.ElipseTool();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 60);
            label1.Name = "label1";
            label1.Size = new Size(384, 35);
            label1.TabIndex = 0;
            label1.Text = "E-posta adresi veya kullanıcı adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 155);
            label2.Name = "label2";
            label2.Size = new Size(89, 35);
            label2.TabIndex = 1;
            label2.Text = "Parola";
            // 
            // txt_eposta
            // 
            txt_eposta.BackColor = Color.FromArgb(64, 64, 64);
            txt_eposta.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txt_eposta.ForeColor = Color.White;
            txt_eposta.Location = new Point(12, 103);
            txt_eposta.Name = "txt_eposta";
            txt_eposta.Size = new Size(384, 28);
            txt_eposta.TabIndex = 2;
            txt_eposta.TextChanged += txt_eposta_TextChanged;
            // 
            // txt_parola
            // 
            txt_parola.BackColor = Color.FromArgb(64, 64, 64);
            txt_parola.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txt_parola.ForeColor = Color.White;
            txt_parola.Location = new Point(12, 195);
            txt_parola.Name = "txt_parola";
            txt_parola.Size = new Size(384, 28);
            txt_parola.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(49, 29);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // elipseTool1
            // 
            elipseTool1.CornerRadius = 43;
            elipseTool1.TargetControl = null;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(64, 64, 64);
            button2.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button2.Location = new Point(136, 292);
            button2.Name = "button2";
            button2.Size = new Size(137, 47);
            button2.TabIndex = 5;
            button2.Text = "Oturum aç";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(447, 748);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txt_parola);
            Controls.Add(txt_eposta);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form5";
            Text = "Oturum aç";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_eposta;
        private TextBox txt_parola;
        private Button button1;
        private ElipseToolDemo.ElipseTool elipseTool1;
        private Button button2;
    }
}