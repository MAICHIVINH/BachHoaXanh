using BachHoaXanh.QuanLySupplier.Function;
using BachHoaXanhNew.Categories.Function;
using BachHoaXanhNew.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BachHoaXanhNew.Suppliers
{
    public partial class FormSuppliers : Form
    {
        ApplicationDbContext data = new ApplicationDbContext();
        int idSuppliers;
        private Form parentForm;
        public FormSuppliers(Form parent)
        {
            InitializeComponent();

            this.parentForm = parent;

        }
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            PanelBody.Controls.Add(childForm);
            PanelBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        private void btnAddSippliers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddSupplier((this)));
        }

        private void btnUpdateSippliers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UpdateSupplier(this, idSuppliers));
        }

        private void btnDeleteSippliers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DeleteSupplier(this, idSuppliers));
        }

        public void LoadPage()
        {
            dtgvSuppliers.ClearSelection();
            var supplier = data.Suppliers.ToList();
            if (supplier.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu nhà cung cấp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                dtgvSuppliers.DataSource = supplier;
                // Tùy chỉnh tiêu đề cột
                dtgvSuppliers.Columns["ID_SUPPLIER"].HeaderText = "Mã nhà cung cấp";
                dtgvSuppliers.Columns["NAME_SUPPLIER"].HeaderText = "Họ và tên";
                dtgvSuppliers.Columns["ADDRESS_SUPPLIER"].HeaderText = "Địa chỉ";
                dtgvSuppliers.Columns["PHONE_SUPPLIER"].HeaderText = "Số điện thoại";
                dtgvSuppliers.Columns["EMAIL_SUPPLIER"].HeaderText = "Email";
                dtgvSuppliers.Columns["CONTRACT_START_DATE"].HeaderText = "Ngày bắt đầu hợp đồng";
                dtgvSuppliers.Columns["CONTRACT_END_DATE"].HeaderText = "Ngày kết thúc hợp đồng";
                dtgvSuppliers.Columns["CONTACT"].HeaderText = "Liên hệ";
                dtgvSuppliers.Columns["NOTE"].HeaderText = "Ghi chú";

                dtgvSuppliers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dtgvSuppliers.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadPage();
        }


        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dtgvSuppliers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idSearch = 0;
            if (int.TryParse(txtIDSearch.Text, out idSearch))
            {
            }
            string nameSearch = "";
            if (!string.IsNullOrWhiteSpace(txtNameSearch.Text))
            {
                nameSearch += txtNameSearch.Text;
            }

            var productSearch = data.Suppliers.Where(p =>
                (string.IsNullOrEmpty(nameSearch) || p.NAME_SUPPLIER.Contains(nameSearch)) &&
                (idSearch == 0 || p.ID_SUPPLIER == idSearch)
            ).ToList();

            dtgvSuppliers.DataSource = productSearch;
        }

        private void dtgvSuppliers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = dtgvSuppliers.Rows[e.RowIndex];
                idSuppliers = Convert.ToInt32(selectedRow.Cells["ID_SUPPLIER"].Value);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadPage();
        }

        private void btnReset1_Click(object sender, EventArgs e)
        {
            if (parentForm is Home mainForm)
            {
                mainForm.LoadSupplier(); // Gọi lại hàm LoadPage() của form cha
            }
            this.Close();
        }
    }
}
