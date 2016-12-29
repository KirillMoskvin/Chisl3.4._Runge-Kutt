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
            return Math.Sin(x) + 5*Math.Cos(y);
        }

        private void btnTask_Click(object sender, EventArgs e)
        {
            if (nudX0.Value>=nudB.Value)
            {
                MessageBox.Show("Введите a<b", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                nudX0.Focus();
                return;
            }
            if (nudH.Value<=0)
            {
                MessageBox.Show("Введите h>0", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                nudH.Focus();
                return;
            }

            RungeKutta rk;
            switch (cbEquation.SelectedIndex)
            {
                case 0:
                    FillGrid(RungeKutta.Solve(f1, (double)nudX0.Value, (double)nudY0.Value, (int)nudH.Value, (double)nudB.Value));
                    break;
                case 1:
                    FillGrid(RungeKutta.Solve(f2, (double)nudX0.Value, (double)nudY0.Value, (int)nudH.Value, (double)nudB.Value));
                    break;
                case 2:
                    FillGrid(RungeKutta.Solve(f3, (double)nudX0.Value, (double)nudY0.Value, (int)nudH.Value, (double)nudB.Value));
                    break;
            }       
        }

        void FillGrid(List<PointF> points)
        {
            dgv_output.Rows.Clear();
            dgv_output.Columns.Clear();
            dgv_output.Columns.Add("", "");
            dgv_output.Rows.Add(2);
            dgv_output.Rows[0].HeaderCell.Value = "x";
            dgv_output.Rows[1].HeaderCell.Value = "y";
            for(int i=0; i<points.Count; ++i)
            {
                dgv_output.Columns.Add("", "");
                dgv_output.Rows[0].Cells[i].Value = points[i].X.ToString();
                dgv_output.Rows[1].Cells[i].Value = points[i].Y.ToString();
            }
            dgv_output.Columns.RemoveAt(dgv_output.Columns.Count - 1);
        }

        private void nudH_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nudY0_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nudB_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nudX0_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
