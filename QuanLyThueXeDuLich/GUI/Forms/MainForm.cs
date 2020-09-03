using DTO;
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

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            var reult = MessageBox.Show("Bạn muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (reult == DialogResult.Yes)
            {
                LoginInfo.Name = "";
                LoginInfo.Role = 99;
                new LoginForm().Visible = true;
                this.Visible = false;
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
           var reult = MessageBox.Show("Bạn muốn đóng chương trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (reult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }

        private void btnquanlyphat_Click(object sender, EventArgs e)
        {
            lbTitle.Text = "Quản lý vi phạm nộp phạt";

            pnMain.Controls.Clear();
            ManagePunish mgP = new ManagePunish();
            pnMain.Controls.Add(mgP);
            mgP.Show();
        }

        private void btnquanlyhoadon_Click(object sender, EventArgs e)
        {
            lbTitle.Text = "Quản lý hóa đơn";

            pnMain.Controls.Clear();
            ManageBill mb = new ManageBill();
            pnMain.Controls.Add(mb);
            mb.Show();
        }
    }
}
