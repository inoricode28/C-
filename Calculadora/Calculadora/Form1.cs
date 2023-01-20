using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Bt_Suma_Click(object sender, EventArgs e)
        {
            int n1 = 0;
            int n2 = 0;
            int total = 0;

            n1 = Convert.ToInt32(Tb_1.Text);
            n2 = Convert.ToInt32(Tb_2.Text);

            total = n1 + n2;
            Tb_3.Text = total.ToString();

        }

        private void Bt_Limpiar_Click(object sender, EventArgs e)
        {
            Tb_1.Text = "";
            Tb_2.Text = "";
            Tb_3.Text = "";
            Tb_1.Focus();
        }

        private void BT_Siguiente_Click(object sender, EventArgs e)
        {
            Form2 venta2= new Form2();
            this.Hide();
            venta2.Show();

        }
    }
}
