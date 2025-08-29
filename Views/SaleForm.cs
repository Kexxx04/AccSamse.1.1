using AccSamse._1._1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccSamse._1._1.Views
{
    public partial class SaleForm : Form
    {
        public SaleForm()
        {
            InitializeComponent();
            ConexionDataBase conexion = new ConexionDataBase();
            conexion.openConnection();
        }

        private void SaleForm_Load(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelSaller_Click(object sender, EventArgs e)
        {

        }

        private void groupBoxSaleForm_Enter(object sender, EventArgs e)
        {

        }

        private void groupBoxProduct_Enter(object sender, EventArgs e)
        {

        }
    }
}
