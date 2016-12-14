using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chisl3._4._Runge_Kutt
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            cbEquation.SelectedIndex = 0;
        }

        double f1(double x, double y)
        {
            return x + y;
        }

        double f2(double x, double y)
        {
            return x*x - 2*y;
        }

        double f3(double x, double y)
        {
            return Math.Sin(x) + 5*y*y*y;
        }

        private void btnTask_Click(object sender, EventArgs e)
        {
            if (nudX0.Value>=nudB.Value)
            {
                MessageBox.Show("Введите a<b", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                nudX0.Focus();
                return;
            }
            if (nudH.Value>=(nudB.Value-nudX0.Value))
            {
                MessageBox.Show("Введите h>b-a", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                nudH.Focus();
                return;
            }

            RungeKutta rk;
            switch (cbEquation.SelectedIndex)
            {
                case 0:
                    lblSolution.Text = "Ответ: " + RungeKutta.Solve(f1, (double)nudX0.Value, (double)nudY0.Value, (double)nudH.Value, (double)nudB.Value);
                    break;
                case 1:
                    lblSolution.Text = "Ответ: " + RungeKutta.Solve(f2, (double)nudX0.Value, (double)nudY0.Value, (double)nudH.Value, (double)nudB.Value);
                    break;
                case 2:
                    lblSolution.Text = "Ответ: " + RungeKutta.Solve(f3, (double)nudX0.Value, (double)nudY0.Value, (double)nudH.Value, (double)nudB.Value);
                    break;
            }       
        }
    }
}
