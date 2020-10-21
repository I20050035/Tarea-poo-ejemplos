using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Tarea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCelular_Click(object sender, EventArgs e)
        {
            Celular c;
            c = new Celular();
            c.Memoria=10;
            MessageBox.Show(c.ToString());
        }

        private void btnCelular_Huawei_Click(object sender, EventArgs e)
        {
            Celular_Huawei ch;
            ch = new Celular_Huawei();
            ch.Memoria=25;
            ch.Navegador ="Huawei Search";
            MessageBox.Show(ch.ToString());
        }

        private void btnHuawei_Psmart_Click(object sender, EventArgs e)
        {
            Huawei_Psmart hp;
            hp = new Huawei_Psmart();
            hp.Memoria = 30;
            hp.Navegador = "Huawei Search";
            hp.Año = " 2018 ";
            MessageBox.Show(hp.ToString());
        }
    }
}
