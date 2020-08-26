using GUI.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            lbTitle.Text = "Quản lý nhân viên";

            pnMain.Controls.Clear();
            EmployeeUC EmpUC = new EmployeeUC();
            pnMain.Controls.Add(EmpUC);
            //EmpUC.Dock = DockStyle.Fill;
            EmpUC.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbTitle.Text = "Báo cáo";

            pnMain.Controls.Clear();
            ReportUC Report = new ReportUC();
            pnMain.Controls.Add(Report);
            //EmpUC.Dock = DockStyle.Fill;
            Report.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            lbTitle.Text = "Quản lý hoạt động cho thuê xe";
            pnMain.Controls.Clear();
        }

        private void btn_Customers_Click(object sender, EventArgs e)
        {
            lbTitle.Text = "Quản lý khách hàng";

            pnMain.Controls.Clear();
            CustomersUC CusUC = new CustomersUC();
            pnMain.Controls.Add(CusUC);
            CusUC.Show();
        }

        private void btn_InforCar_Click(object sender, EventArgs e)
        {
            lbTitle.Text = "Quản lý xe";

            pnMain.Controls.Clear();
            InforCarUC InfUC = new InforCarUC();
            pnMain.Controls.Add(InfUC);
            InfUC.Show();
        }
    }
}
