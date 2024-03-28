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
            panel4 = new Panel();
            panel2 = new Panel();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            panel3 = new Panel();
            label1 = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackgroundImage = Properties.Resources.gradient;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(724, 467);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.AutoScrollMargin = new Size(0, 20);
            panel4.BackgroundImage = Properties.Resources.gexes;
            panel4.Location = new Point(79, 53);
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
            panel2.Location = new Point(79, 53);
            panel2.Name = "panel2";
            panel2.Size = new Size(569, 350);
            panel2.TabIndex = 0;
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
            label1.Click += label1_Click;
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
            // AuthorizationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(724, 467);
            Controls.Add(panel1);
            Name = "AuthorizationForm";
            Text = "AuthorizationForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
    }
}