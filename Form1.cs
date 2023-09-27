using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comboBox1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cbRucak_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void cbVecera_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbDorucak_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbSakriji_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSakriji.Checked)
            {
                tb.Hide();
            }
            else { tb.Show();}

        }
        private void btPos_Click(object sender, EventArgs e)
        {

        }
    }
}
