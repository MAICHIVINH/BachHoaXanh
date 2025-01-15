﻿using BachHoaXanhNew.Staffs;
using BachHoaXanhNew.Categories;
using BachHoaXanhNew.Suppliers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BachHoaXanhNew.Products;
using BachHoaXanhNew.Branchss;
using BachHoaXanhNew.Data;

namespace BachHoaXanhNew
{
    public partial class Home : Form
    {
        int idUser;
        int checkUser;
        ApplicationDbContext data = new ApplicationDbContext();
        public Home(int idUserForm, int check)
        {
            InitializeComponent();
            idUser = idUserForm;
            checkUser = check;
        }
        private Form currentFormChild;
        public void OpenChildForm(Form childForm)
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
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ChangePassword(idUser));
        }



        public void LoadSupplier()
        {
            OpenChildForm(new FormSuppliers(this));

        }

        public void btnSupplier_Click(object sender, EventArgs e)
        {
            LoadSupplier();
        }

        private void panelBody_Paint(object sender, PaintEventArgs e)
        {

        }

        public void LoadSatff()
        {
            OpenChildForm(new Staff(this));
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            LoadSatff();
        }

        public void LoadCategories()
        {
            OpenChildForm(new Categoriess(this));
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            LoadCategories();
        }


        public void LoadProduct()
        {
            OpenChildForm(new Productss(this));
        }


        private void btnProduct_Click(object sender, EventArgs e)
        {
            LoadProduct();
        }

        public void LoadBranch()
        {
            OpenChildForm(new Branchs(this));

        }

        private void btnBranch_Click(object sender, EventArgs e)
        {
            LoadBranch();
        }

        string NameUser(int user)
        {
            var checkAdmin = data.Admins.SingleOrDefault(p => p.ID_ADMIN == user);
            if (checkAdmin != null) return checkAdmin.FULLNAME_ADMIN;
            else
            {
                var checkEmloyee = data.Employees.SingleOrDefault(p => p.ID_EMPLOYEE == user);
                if (checkEmloyee != null) return checkEmloyee.FULLNAME_EMPLOYEE;
                else return "Dữ liệu lỗi";
            }
        }

        int BrandUser(int user)
        {
            var checkAdmin = data.Admins.SingleOrDefault(p => p.ID_ADMIN == user);
            if (checkAdmin != null) return checkAdmin.ID_BRANCH;
            else
            {
                var checkEmloyee = data.Employees.SingleOrDefault(p => p.ID_EMPLOYEE == user);
                if (checkEmloyee != null) return checkEmloyee.ID_BRANCH;
                else return 0;
            }
        }

        string NameBranch(int idBranch)
        {
            var branch = data.Branches.SingleOrDefault(p => p.ID_BRANCH == idBranch);
            return branch.NAME_BRANCH;
        }


        private void Home_Load(object sender, EventArgs e)
        {
            lblUser.Text = NameUser(idUser);
            lblBranch.Text = "HỆ THỐNG QUẢN LÝ BÁCH HÓA XANH " + NameBranch(BrandUser(idUser)).ToLower();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có đồng ý không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Login login = new Login();
                this.Hide();
                login.Show();
            }
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
        }

        public void Pay()
        {
            OpenChildForm(new Test(this));
        }

        private void btnBill_Click_1(object sender, EventArgs e)
        {
            Pay();
        }
    }
}
