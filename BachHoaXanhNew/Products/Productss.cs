﻿using BachHoaXanhNew.Data;
using BachHoaXanhNew.Products.Function;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BachHoaXanhNew.Products
{
    public partial class Productss : Form
    {
        int id_product;
        private Form parentForm;

        ApplicationDbContext data = new ApplicationDbContext();
        public Productss(Form parent)
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
            panelBody.Controls.Add(childForm);
            panelBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        public void LoadProduct()
        {
            var productList = (from product in data.Products
                               join category in data.Categories on product.ID_CATEGORY equals category.ID_CATEGORY
                               join supplier in data.Suppliers on product.ID_SUPPLIER equals supplier.ID_SUPPLIER
                               select new
                               {
                                   product.ID_PRODUCT,
                                   product.NAME_PRODUCT,
                                   CategoryName = category.NAME_CATEGORY, // Tên loại sản phẩm
                                   SupplierName = supplier.NAME_SUPPLIER, // Tên nhà cung cấp
                                   product.PRICE,
                                   product.QUANTITY_STOCK
                               }).ToList();
            if (productList.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                dtgvProduct.DataSource = productList;
                dtgvProduct.Columns["ID_PRODUCT"].HeaderText = "Mã sản phẩm";
                dtgvProduct.Columns["NAME_PRODUCT"].HeaderText = "Tên sản phẩm";
                dtgvProduct.Columns["CategoryName"].HeaderText = "Loại sản phẩm";
                dtgvProduct.Columns["SupplierName"].HeaderText = "Nhà cung cấp";
                dtgvProduct.Columns["PRICE"].HeaderText = "Giá";
                dtgvProduct.Columns["QUANTITY_STOCK"].HeaderText = "Số lượng";

                dtgvProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dtgvProduct.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            }
            
        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddProducts(this));
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UpdateProducts(this,id_product));

        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DeleteProducts(this, id_product));

        }

        private void Products_Load(object sender, EventArgs e)
        {
            LoadProduct();
        }

        private void dtgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy ID từ cột ID (giả sử ID nằm ở cột đầu tiên)
                var selectedRow = dtgvProduct.Rows[e.RowIndex];
                id_product = Convert.ToInt32(selectedRow.Cells["ID_PRODUCT"].Value);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click_1(object sender, EventArgs e)
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


            var productSearch = data.Products.Where(p =>
                (string.IsNullOrEmpty(nameSearch) || p.NAME_PRODUCT.Contains(nameSearch)) &&
                (idSearch == 0 || p.ID_PRODUCT == idSearch)
            ).ToList();

            dtgvProduct.DataSource = productSearch;

        }

        private void btnLoadPage_Click(object sender, EventArgs e)
        {
            if (parentForm is Home mainForm)
            {
                mainForm.LoadProduct(); // Gọi lại hàm LoadPage() của form cha
            }
            this.Close();
        }
    }
}
