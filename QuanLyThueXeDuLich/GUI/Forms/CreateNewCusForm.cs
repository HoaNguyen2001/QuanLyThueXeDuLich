using BUS.Process;
using DTO.Entities;
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
    public partial class CreateNewCusForm : Form
    {
        CustomerProcess CusPro = new CustomerProcess();
        public CreateNewCusForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var Cus = new CustomerEntities();
                Cus.Name = txtName.Text;
                Cus.IDCardNumber = int.Parse(txtIDCardNumber.Text);
                Cus.Phone = txtPhone.Text;
                Cus.Address =txtAddress.Text;
                if (rbNam.Checked) Cus.Sex = true;
                else Cus.Sex = false;

                    CusPro.Create(Cus);
                this.Close();
                new ManageBill();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
