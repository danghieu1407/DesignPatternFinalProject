﻿using DesignPatternMidterm.Controller;
using DesignPatternMidterm.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignPatternMidterm.View
{
    public partial class ManageAccount : Form
    {
        int index = -1;
        public ManageAccount()
        {
            InitializeComponent();
        }
        Modify modify = new Modify();
        public void listUser()
        {
            //call method getAccounts in modify
            List<Account> accounts = modify.GetAccounts();
            //add data to dataGridView
            dataGridView1.DataSource = accounts;
            

        }
        private void ManageAccount_Load(object sender, EventArgs e)
        {
            listUser();
            //check null textbox
            
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
            

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //close form
            this.Hide();

        }
        public bool checkAccount(string abc)
        {
            return Regex.IsMatch(abc, @"^[a-zA-Z0-9]{6,12}$");
        }

        public bool checkEmail(string email)
        {
            return Regex.IsMatch(email, @"^[a-zA-Z0-9_.]{3,20}@gmail.com(.vn|)$");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //check null
            if (txtUsername.Text == "" || txtPassword.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else if (!checkAccount(txtPassword.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu dài 6-26 ký tự với 1 kỳ tự hoa 1 ký tự số");
            }
            else if (!checkEmail(txtEmail.Text))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng email");
            }

            else
            {
                modify.InsertAccount(txtUsername.Text, txtPassword.Text, txtEmail.Text);
                //reload form and data in dataGridView
                listUser();
                //clear textbox
                txtUsername.Text = "";
                txtPassword.Text = "";
                txtEmail.Text = "";
            }
            //insert into database
           

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //delete account form database
            //confirm user want to delete
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản này?", "Xác nhận", MessageBoxButtons.YesNo);
            //yes is delete
            if (dialogResult == DialogResult.Yes)
            {
                modify.DeleteAccount(txtEmail.Text);
                listUser();
                //clear textbox
                txtUsername.Text = "";
                txtPassword.Text = "";
                txtEmail.Text = "";
            } else
            {
                //no is cancel
                MessageBox.Show("Xóa tài khoản đã bị hủy");
            }
          
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else if (!checkAccount(txtPassword.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu dài 6-26 ký tự với 1 kỳ tự hoa 1 ký tự số");
            }
            else if (!checkEmail(txtEmail.Text))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng email");
            }
            //update account in database
            modify.UpdateAccount(txtUsername.Text, txtPassword.Text, txtEmail.Text);
            listUser();
        }

        private void dtgvUser(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[index];
            txtUsername.Text = row.Cells[1].Value.ToString();
            txtPassword.Text = row.Cells[2].Value.ToString();
            txtEmail.Text = row.Cells[0].Value.ToString();
            //disable btnAdd
            btnAdd.Enabled = false;
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtEmail.Text = "";
            //enable btnAdd
            btnAdd.Enabled = true;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }
    }
}
