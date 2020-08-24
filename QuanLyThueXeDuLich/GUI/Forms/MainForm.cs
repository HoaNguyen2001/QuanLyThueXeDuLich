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
    }
}
