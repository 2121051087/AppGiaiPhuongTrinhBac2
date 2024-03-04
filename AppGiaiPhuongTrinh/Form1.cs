using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppGiaiPhuongTrinh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tb_NhapA_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_GiaiPT_Click(object sender, EventArgs e)
        {
            int a = int.Parse(tb_NhapA.Text);
            int b = int.Parse(tb_NhapB.Text);
            int c = int.Parse(tb_NhapC.Text);

            if ( a != 0)
            {
                float delta = b * b - 4 * a * c;
                if (delta < 0)
                {
                    tb_KetQua.Text = " phương trình vô nghiệm ";

                }
                else if(delta == 0)
                {
                    float x = -b / (2 * a);
                }
                else
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

                    tb_KetQua.Text = $"Phương trình có nghiệm kép : \r\n  x1 =  {x1}  \r\n  x2 = {x2} ";
                }
            }
            else
            {
                tb_KetQua.Text = "phương trình có nghiệm là : " + (-c / b).ToString();
            }
        }

        private void btb_Reset_Click(object sender, EventArgs e)
        {
            tb_NhapA.Clear();
            tb_NhapB.Clear();
            tb_NhapC.Clear();
            tb_KetQua.Clear();
        }

        private void tb_NhapA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) )
            {
                e.Handled = true;
            }
        }

        private void tb_NhapB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tb_NhapC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
