﻿namespace GUI.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnLeft = new System.Windows.Forms.Panel();
            this.btnquanlyphat = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnquanlyhoadon = new System.Windows.Forms.Button();
            this.btn_InforCar = new System.Windows.Forms.Button();
            this.btn_Customers = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.pnTitle = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.pnLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnMain = new System.Windows.Forms.Panel();
            this.pnLeft.SuspendLayout();
            this.pnTitle.SuspendLayout();
            this.pnLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnLeft
            // 
            resources.ApplyResources(this.pnLeft, "pnLeft");
            this.pnLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.pnLeft.Controls.Add(this.btnquanlyphat);
            this.pnLeft.Controls.Add(this.btnLogOut);
            this.pnLeft.Controls.Add(this.btnquanlyhoadon);
            this.pnLeft.Controls.Add(this.btn_InforCar);
            this.pnLeft.Controls.Add(this.btn_Customers);
            this.pnLeft.Controls.Add(this.button1);
            this.pnLeft.Controls.Add(this.btnEmployee);
            this.pnLeft.Name = "pnLeft";
            // 
            // btnquanlyphat
            // 
            this.btnquanlyphat.BackColor = System.Drawing.Color.MistyRose;
            this.btnquanlyphat.Image = global::GUI.Properties.Resources.vw_beetle_icon;
            resources.ApplyResources(this.btnquanlyphat, "btnquanlyphat");
            this.btnquanlyphat.Name = "btnquanlyphat";
            this.btnquanlyphat.UseVisualStyleBackColor = false;
            this.btnquanlyphat.Click += new System.EventHandler(this.btnquanlyphat_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.MistyRose;
            this.btnLogOut.Image = global::GUI.Properties.Resources.logout_icon;
            resources.ApplyResources(this.btnLogOut, "btnLogOut");
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnquanlyhoadon
            // 
            this.btnquanlyhoadon.BackColor = System.Drawing.Color.MistyRose;
            this.btnquanlyhoadon.Image = global::GUI.Properties.Resources.Distributor_report_icon;
            resources.ApplyResources(this.btnquanlyhoadon, "btnquanlyhoadon");
            this.btnquanlyhoadon.Name = "btnquanlyhoadon";
            this.btnquanlyhoadon.UseVisualStyleBackColor = false;
            this.btnquanlyhoadon.Click += new System.EventHandler(this.btnquanlyhoadon_Click);
            // 
            // btn_InforCar
            // 
            this.btn_InforCar.BackColor = System.Drawing.Color.MistyRose;
            this.btn_InforCar.Image = global::GUI.Properties.Resources.vw_beetle_icon;
            resources.ApplyResources(this.btn_InforCar, "btn_InforCar");
            this.btn_InforCar.Name = "btn_InforCar";
            this.btn_InforCar.UseVisualStyleBackColor = false;
            this.btn_InforCar.Click += new System.EventHandler(this.btn_InforCar_Click);
            // 
            // btn_Customers
            // 
            this.btn_Customers.BackColor = System.Drawing.Color.MistyRose;
            this.btn_Customers.Image = global::GUI.Properties.Resources.User_Group_icon;
            resources.ApplyResources(this.btn_Customers, "btn_Customers");
            this.btn_Customers.Name = "btn_Customers";
            this.btn_Customers.UseVisualStyleBackColor = false;
            this.btn_Customers.Click += new System.EventHandler(this.btn_Customers_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MistyRose;
            this.button1.Image = global::GUI.Properties.Resources.Distributor_report_icon;
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.BackColor = System.Drawing.Color.MistyRose;
            this.btnEmployee.Image = global::GUI.Properties.Resources.Preppy_icon;
            resources.ApplyResources(this.btnEmployee, "btnEmployee");
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.UseVisualStyleBackColor = false;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // pnTitle
            // 
            this.pnTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.pnTitle.Controls.Add(this.lbTitle);
            resources.ApplyResources(this.pnTitle, "pnTitle");
            this.pnTitle.Name = "pnTitle";
            // 
            // lbTitle
            // 
            resources.ApplyResources(this.lbTitle, "lbTitle");
            this.lbTitle.Name = "lbTitle";
            // 
            // pnLogo
            // 
            this.pnLogo.Controls.Add(this.pictureBox1);
            resources.ApplyResources(this.pnLogo, "pnLogo");
            this.pnLogo.Name = "pnLogo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources._818372dc919f7b2e5246c443579bcd11;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pnMain
            // 
            this.pnMain.BackgroundImage = global::GUI.Properties.Resources.hinh_nen_sieu_xe_full_hd_cho_laptop_3;
            resources.ApplyResources(this.pnMain, "pnMain");
            this.pnMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnMain.Name = "pnMain";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnLogo);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.pnTitle);
            this.Controls.Add(this.pnLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.pnLeft.ResumeLayout(false);
            this.pnTitle.ResumeLayout(false);
            this.pnLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnLeft;
        private System.Windows.Forms.Panel pnTitle;
        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.Panel pnLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Customers;
        private System.Windows.Forms.Button btn_InforCar;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnquanlyphat;
        private System.Windows.Forms.Button btnquanlyhoadon;
    }
}