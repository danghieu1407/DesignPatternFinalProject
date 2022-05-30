using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesignPatternMidterm.Controller.StrategyPattern;

namespace DesignPatternMidterm.View
{
    public partial class Payment : Form
    {
        Context payment = new Context();
        double total;
        public Payment()
        {
            InitializeComponent();

            phuongThuc.Hide();
            textBox2.Enabled = false;
            tienThua.Enabled = false;
        }
        public void setMoney(double price)
        {
            total = price;
            tongtien.Text = total.ToString();
        }
        private void thanhToantc_Click(object sender, EventArgs e)
        {
            int parsedValue = 0;
            if (!int.TryParse(textBox2.Text, out parsedValue))
            {
                MessageBox.Show("Tiền nhận không hợp lệ!");
                return;
            }
            double a = double.Parse(textBox2.Text);
            if (a >= total)
            {
               
                if (moMo.Checked)
                {
                    payment.setPayment(new Momo());
                    tienThua.Text = payment.pay(total, a).ToString();
                }
                else if (tinDung.Checked)
                {
                    payment.setPayment(new CreditCard());
                    tienThua.Text = payment.pay(total, a).ToString();
                    MessageBox.Show(total.ToString());
                }
                MessageBox.Show("Thanh toán thành công! " +
                    "Cảm ơn đã mua hàng! " +
                    "Số tiền thừa là: " + tienThua.Text);

                this.Hide();
            }
            else
            {
                MessageBox.Show("Số tiền nhận không đủ, vui lòng nhập thêm");
            }
        }

        private void tinDung_CheckedChanged(object sender, EventArgs e)
        {
            phuongThuc.Show();
            tienNhan.Enabled = true;
            payment.setPayment(new CreditCard());
            phuongThuc.Text = payment.methodPay("");
            textBox2.Enabled = true;
        }

        private void moMo_CheckedChanged(object sender, EventArgs e)
        {
            phuongThuc.Show();
            tienNhan.Enabled = true;
            payment.setPayment(new Momo());
            phuongThuc.Text = payment.methodPay("");
            textBox2.Enabled = true;
        }

        private void tongtien_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void tienThua_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
