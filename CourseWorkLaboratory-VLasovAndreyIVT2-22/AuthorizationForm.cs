using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWorkLaboratory_VLasovAndreyIVT2_22 {
    public partial class AuthorizationForm : Form {
        public AuthorizationForm() {
            InitializeComponent();
        }



        // ----------------
        // Кнопка закрытия
        private void exitButton_Click_1(object sender, EventArgs e) {
            this.Close();
        }

        private void exitButton_MouseEnter(object sender, EventArgs e) {
            exitButton.BackColor = Color.Tomato; // Можете выбрать любой другой цвет
        }

        private void exitButton_MouseLeave(object sender, EventArgs e) {
            exitButton.BackColor = Color.Black; // Можете выбрать любой другой цвет
        }
        // ----------------

        // ----------------
        // Передвижение окна с зажатой мышью
        Point lastPoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e) {
            lastPoint = new Point(e.X, e.Y);
        }
        // ----------------

    }
}
