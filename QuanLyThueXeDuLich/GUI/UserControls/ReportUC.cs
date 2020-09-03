using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.IO;
using DTO.Entities;
using BUS.Process;
using DTO;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Math;
using DTO.ViewModels;
using System.Globalization;

namespace GUI.UserControls
{
    public partial class ReportUC : UserControl
    {
        EmployeeProcess EmpPro = new EmployeeProcess();
        InforCarProcess CarPro = new InforCarProcess();
        BillsProcess BillPro = new BillsProcess();

        public ReportUC()
        {
            InitializeComponent();
        }

        /// <summary>
        /// FileTitle=Tiêu đề file
        /// NameSheet=Tên sheet làm việc
        /// ArrColumnHeader=Tieu đề cột
        /// </summary>
        /// <param name="FileTitle"></param>
        /// <param name="NameSheet"></param>
        /// <param name="ArrColumnHeader"></param>
        protected void ExportExcel(string FileTitle,string NameSheet, string[] ArrColumnHeader,string TypeReport,string Creator,List<InforCarEntities> Cars=null,List<BillsVM> Bills=null)
        {
            string filePath = "";
            // tạo SaveFileDialog để lưu file excel
            SaveFileDialog dialog = new SaveFileDialog();

            // chỉ lọc ra các file có định dạng Excel
            dialog.Filter = "Excel | *.xlsx | Excel 2003 | *.xls";

            // Nếu mở file và chọn nơi lưu file thành công sẽ lưu đường dẫn lại dùng
            //if (dialog.ShowDialog())
            //{
            //    filePath = dialog.FileName;
            //}
            var a = dialog.ShowDialog();
            if (a == DialogResult.OK)
                filePath = dialog.FileName;

            // nếu đường dẫn null hoặc rỗng thì báo không hợp lệ và return hàm
            if (string.IsNullOrEmpty(filePath))
            {
                //MessageBox.Show("Đường dẫn báo cáo không hợp lệ");
                return;
            }

            try
            {
                // If you use EPPlus in a noncommercial context
                // according to the Polyform Noncommercial license:
                //ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                using (ExcelPackage p = new ExcelPackage())
                {
                    // đặt tên người tạo file
                    p.Workbook.Properties.Author = $"{LoginInfo.Name}";

                    // đặt tiêu đề cho file
                    p.Workbook.Properties.Title = $"Báo cáo thống kê {FileTitle}";

                    //Tạo một sheet để làm việc trên đó
                    p.Workbook.Worksheets.Add("Report Sheet");

                    // lấy sheet vừa add ra để thao tác
                    ExcelWorksheet ws = p.Workbook.Worksheets[1];

                    // đặt tên cho sheet
                    ws.Name = $"Báo cáo thống kê {NameSheet}";
                    // fontsize mặc định cho cả sheet
                    ws.Cells.Style.Font.Size = 14;
                    // font family mặc định cho cả sheet
                    ws.Cells.Style.Font.Name = "Calibri";

                    // Tạo danh sách các column header
                    //    string[] arrColumnHeader = {
                    //                                "Họ tên",
                    //                                "Năm sinh"
                    //};
                    string[] arrColumnHeader = ArrColumnHeader;

                    // lấy ra số lượng cột cần dùng dựa vào số lượng header
                    var countColHeader = arrColumnHeader.Count();

                    // merge các column lại từ column 1 đến số column header
                    // gán giá trị cho cell vừa merge là Thống kê thông tni User Kteam
                    ws.Cells[1, 1].Value = $"Thống kê thông tin {TypeReport}";
                    ws.Cells[1, 1, 1, countColHeader].Merge = true;
                    // in đậm
                    ws.Cells[1, 1, 1, countColHeader].Style.Font.Bold = true;
                    // căn giữa
                    ws.Cells[1, 1, 1, countColHeader].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                    ws.Cells[2, countColHeader-1].Value = $"Ngày tạo";
                    ws.Cells[2, countColHeader].Value = $"{DateTime.Now.ToString("dd-MM-yyyy")}";
                    ws.Cells[3, countColHeader-1].Value = $"Người tạo";
                    ws.Cells[3, countColHeader].Value = $"{Creator}";

                    int colIndex = 1;
                    int rowIndex = 4;

                    //tạo các header từ column header đã tạo từ bên trên
                    foreach (var item in arrColumnHeader)
                    {
                        var cell = ws.Cells[rowIndex, colIndex];

                        //set màu thành gray
                        var fill = cell.Style.Fill;
                        fill.PatternType = ExcelFillStyle.Solid;
                        fill.BackgroundColor.SetColor(System.Drawing.Color.LightBlue);

                        //căn chỉnh các border
                        var border = cell.Style.Border;
                        border.Bottom.Style =
                            border.Top.Style =
                            border.Left.Style =
                            border.Right.Style = ExcelBorderStyle.Thin;

                        //gán giá trị
                        cell.Value = item;

                        colIndex++;
                    }

                    // lấy ra danh sách UserInfo từ ItemSource của DataGrid
                    //List<UserInfo> userList = dtgExcel.ItemsSource.Cast<UserInfo>().ToList();

                    if (Cars != null)
                    {
                        // với mỗi item trong danh sách sẽ ghi trên 1 dòng
                        foreach (var item in Cars.ToList())
                        {
                            // bắt đầu ghi từ cột 1. Excel bắt đầu từ 1 không phải từ 0
                            colIndex = 1;

                            // rowIndex tương ứng từng dòng dữ liệu
                            rowIndex++;

                            //gán giá trị cho từng cell                      
                            ws.Cells[rowIndex, colIndex++].Value = item.Name;
                            ws.Cells[rowIndex, colIndex++].Value = item.NumCar;
                            ws.Cells[rowIndex, colIndex++].Value = item.Status;
                            ws.Cells[rowIndex, colIndex++].Value = item.NumberOfCar;

                            // lưu ý phải .ToShortDateString để dữ liệu khi in ra Excel là ngày như ta vẫn thấy.Nếu không sẽ ra tổng số :v
                            ws.Cells[rowIndex, colIndex++].Value = item.DateAddCar.ToString("dd-MM-yyyy");

                        }
                    }
                    else
                    {
                        // với mỗi item trong danh sách sẽ ghi trên 1 dòng
                        foreach (var item in Bills.ToList())
                        {
                            // bắt đầu ghi từ cột 1. Excel bắt đầu từ 1 không phải từ 0
                            colIndex = 1;

                            // rowIndex tương ứng từng dòng dữ liệu
                            rowIndex++;

                            //gán giá trị cho từng cell                      
                            ws.Cells[rowIndex, colIndex++].Value = item.ID;
                            ws.Cells[rowIndex, colIndex++].Value = item.EmpName;
                            ws.Cells[rowIndex, colIndex++].Value = item.CreateDay.ToString("dd-MM-yyyy");
                            ws.Cells[rowIndex, colIndex++].Value = item.CusName;
                            ws.Cells[rowIndex, colIndex++].Value = item.CarName;
                            ws.Cells[rowIndex, colIndex++].Value = item.NumCar;
                            ws.Cells[rowIndex, colIndex++].Value = item.TotalPrice;

                            // lưu ý phải .ToShortDateString để dữ liệu khi in ra Excel là ngày như ta vẫn thấy.Nếu không sẽ ra tổng số :v
                            //ws.Cells[rowIndex, colIndex++].Value = item.CreateDay.ToString("dd-MM-yyyy");

                        }

                        ws.Cells[rowIndex+1, countColHeader-1].Value = "Tổng tiền";
                        ws.Cells[rowIndex+1, countColHeader].Value = string.Format(new CultureInfo("vi-VN"), "{0:#,##0.00}", Bills.Select(x => x.TotalPrice).Sum()) + " VNĐ";
                    }

                    //Lưu file lại
                    Byte[] bin = p.GetAsByteArray();
                    File.WriteAllBytes(filePath, bin);
                }
                MessageBox.Show("Xuất excel thành công!", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Information) ;
            }
            catch (Exception EE)
            {
                MessageBox.Show(EE.Message);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvReportCar.Visible)
                {
                    string[] ArrColumnHeader = new string[]
                    {
                    "Tên xe",
                    "Biển số xe",
                    "Tình trạng",
                    "Số lượng còn",
                    "Ngày nhập"
                    };
                    ExportExcel("Báo cáo thông tin xe", "Thông tin xe", ArrColumnHeader, "Xe", LoginInfo.Name, CarPro.GetAll());
                }
                else if (dgvReportRevenue.Visible)
                {
                    string[] ArrColumnHeader = new string[]
                    {
                    "Mã hoá đơn",
                    "Nhân viên tạo",
                    "Ngày tạo",
                    "Tên khách hàng",
                    "Tên xe",
                    "Biển số xe",
                    "Tổng tiền"
                    };
                    switch (cbbTypeReport.SelectedIndex)
                    {
                        case 0://tim kiem theo ngay
                            ExportExcel("Thống kê hoá đơn", "Hoá đơn", ArrColumnHeader, "Hoá đơn", LoginInfo.Name, null, BillPro.GetByDay());
                            break;
                        case 1://tim kiem theo tuan
                            ExportExcel("Thống kê hoá đơn", "Hoá đơn", ArrColumnHeader, "Hoá đơn", LoginInfo.Name, null, BillPro.GetByWeek());
                            break;
                        case 2://tim kiem theo thang
                            ExportExcel("Thống kê hoá đơn", "Hoá đơn", ArrColumnHeader, "Hoá đơn", LoginInfo.Name, null, BillPro.GetByMonth());
                            break;
                        case 3:
                            ExportExcel("Thống kê hoá đơn", "Hoá đơn", ArrColumnHeader, "Hoá đơn", LoginInfo.Name, null, BillPro.GetByOrtherTime(dtpStartDay.Value, dtpEndDay.Value));
                            break;
                        default: break;
                    }
                }
                else
                {
                    MessageBox.Show("Bạn cần chọn loại báo cáo", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cbReportRevenue_CheckedChanged(object sender, EventArgs e)
        {
            cbCar.Checked = false;
            if (cbReportRevenue.Checked)
            {
                cbbTypeReport.Enabled = true;
                ShowGridView(true);
            }
            else cbbTypeReport.Enabled = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            cbReportRevenue.Checked = false;
            if (cbCar.Checked)
            {
                cbbCar.Enabled = true;
                dtpStartDay.Enabled = false;
                dtpEndDay.Enabled = false;
                ShowGridView(false);
            }
            else cbbCar.Enabled = false;
        }

        private void ShowGridView(bool _bool)
        {
            dgvReportRevenue.Visible = _bool;
            dgvReportCar.Visible = !_bool;
        }

        private void LoadReportRevenue()
        {

        }

        private void LoadReportRevenue(List<BillsVM> items)
        {
            double totalamount=0;
            dgvReportRevenue.Rows.Clear();
            
            int index = 0;
            dgvReportRevenue.ColumnCount = 7;
            foreach (var item in items)
            {
                dgvReportRevenue.Rows.Add();
                dgvReportRevenue.Rows[index].Cells[0].Value = item.ID;
                dgvReportRevenue.Rows[index].Cells[1].Value = item.EmpName;
                dgvReportRevenue.Rows[index].Cells[2].Value = item.CreateDay.ToString("dd/MM/yyyy");
                dgvReportRevenue.Rows[index].Cells[3].Value = item.CusName;
                dgvReportRevenue.Rows[index].Cells[4].Value = item.CarName;
                dgvReportRevenue.Rows[index].Cells[5].Value = item.NumCar;
                //dgvReportRevenue.Rows[index].Cells[6].Value = item.TotalPrice.ToString("C");
                dgvReportRevenue.Rows[index].Cells[6].Value = string.Format(new CultureInfo("vi-VN"), "{0:#,##0.00}", item.TotalPrice)+" VNĐ";
                totalamount += item.TotalPrice;
                index++;
            }

            txtTotalAmount.Text= string.Format(new CultureInfo("vi-VN"), "{0:#,##0.00}", totalamount)+" VNĐ";
            txtTotalBill.Text = (dgvReportRevenue.RowCount-1).ToString();
        }

        private void btnReview_Click(object sender, EventArgs e)
        {
            try
            {
                btnExport.Enabled = true;
                if (dgvReportRevenue.Visible)//bao cao doanh thu
                {
                    var val = cbbTypeReport.SelectedIndex;
                    switch (val)
                    {
                        case 0://tim kiem theo ngay
                            LoadReportRevenue(BillPro.GetByDay());
                            break;
                        case 1://tim kiem theo tuan
                            LoadReportRevenue(BillPro.GetByWeek());
                            break;
                        case 2://tim kiem theo thang
                            LoadReportRevenue(BillPro.GetByMonth());
                            break;
                        case 3:
                            LoadReportRevenue(BillPro.GetByOrtherTime(dtpStartDay.Value, dtpEndDay.Value));
                            break;
                        default: break;
                    }
                }

                else if (dgvReportCar.Visible) //bao cao so xe
                {
                    dgvReportCar.Rows.Clear();

                    var items = CarPro.GetAll();
                    int index = 0;
                    dgvReportCar.ColumnCount = 5;
                    foreach (var item in items)
                    {
                        dgvReportCar.Rows.Add();
                        dgvReportCar.Rows[index].Cells[0].Value = item.ID;
                        dgvReportCar.Rows[index].Cells[1].Value = item.NumCar;
                        dgvReportCar.Rows[index].Cells[2].Value = item.Status;
                        dgvReportCar.Rows[index].Cells[3].Value = item.NumberOfCar;
                        dgvReportCar.Rows[index].Cells[4].Value = item.DateAddCar.ToString("dd/MM/yyyy");
                        index++;
                    }
                }

                else
                {
                    MessageBox.Show("Bạn cần chọn loại báo cáo", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cbbTypeReport_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTypeReport.SelectedIndex ==3)
            {
                dtpStartDay.Enabled = true;
                dtpEndDay.Enabled = true;
            }
        }
    }
}
