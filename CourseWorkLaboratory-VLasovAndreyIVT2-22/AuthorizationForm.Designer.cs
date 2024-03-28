namespace CourseWorkLaboratory_VLasovAndreyIVT2_22 {
    partial class AuthorizationForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            panel1 = new Panel();
            exitButton = new PictureBox();
            panel4 = new Panel();
            panel2 = new Panel();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            panel3 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)exitButton).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackgroundImage = Properties.Resources.gradient;
            panel1.Controls.Add(exitButton);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(724, 467);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.Black;
            exitButton.BackgroundImage = Properties.Resources.exit_button;
            exitButton.BackgroundImageLayout = ImageLayout.Zoom;
            exitButton.Cursor = Cursors.Hand;
            exitButton.Location = new Point(666, 12);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(46, 23);
            exitButton.SizeMode = PictureBoxSizeMode.Zoom;
            exitButton.TabIndex = 5;
            exitButton.TabStop = false;
            exitButton.Click += exitButton_Click_1;
            exitButton.MouseEnter += exitButton_MouseEnter;
            exitButton.MouseLeave += exitButton_MouseLeave;
            // 
            // panel4
            // 
            panel4.AutoScrollMargin = new Size(0, 20);
            panel4.BackgroundImage = Properties.Resources.gexes;
            panel4.Location = new Point(53, 56);
            panel4.Name = "panel4";
            panel4.Size = new Size(273, 350);
            panel4.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(53, 56);
            panel2.Name = "panel2";
            panel2.Size = new Size(627, 350);
            panel2.TabIndex = 0;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Roboto", 14F);
            button1.Location = new Point(433, 275);
            button1.Name = "button1";
            button1.Size = new Size(108, 35);
            button1.TabIndex = 4;
            button1.Text = "Войти";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 20F);
            textBox2.Location = new Point(296, 202);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(245, 43);
            textBox2.TabIndex = 3;
            textBox2.UseSystemPasswordChar = true;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 20F);
            textBox1.Location = new Point(296, 141);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(245, 43);
            textBox1.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Location = new Point(82, 219);
            panel3.Name = "panel3";
            panel3.Size = new Size(8, 8);
            panel3.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto", 20F);
            label1.Location = new Point(296, 50);
            label1.Name = "label1";
            label1.Size = new Size(182, 33);
            label1.TabIndex = 0;
            label1.Text = "Авторизация";
            // 
            // AuthorizationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(724, 467);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AuthorizationForm";
            Text = "AuthorizationForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)exitButton).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private Panel panel4;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button1;
        private PictureBox exitButton;
    }
}