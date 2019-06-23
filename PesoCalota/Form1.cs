using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PesoCalota;

namespace PesoCalota
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calota calota = new Calota();
            calota.Espessura = Convert.ToDouble(tbEspessura);
            calota.DiametroExterno = Convert.ToDouble(tbDiametroExterno);
            calota.DiametroFuro = Convert.ToDouble(tbDiametroFuro);
            calota.RaioEsferico = Convert.ToDouble(tbRaioEsferico);

            lblResultado = Calculos.CalculoAlturaDosArcos(Convert.ToDouble(tbDiametroExterno.Text), Convert.ToDouble(tbDiametroFuro.Text)).ToString;
        }
    }
}