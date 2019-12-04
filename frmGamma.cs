using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImgProc1
{
    public partial class frmGamma : Form
    {
        public frmGamma()
        {
            InitializeComponent();
        }

        private void hscGamma_ValueChanged(object sender, EventArgs e)
        {
            tbGamma.Text = Convert.ToString(hscGamma.Value * 0.01);
        }

        private void tbGamma_TextChanged(object sender, EventArgs e)
        {
            //if (tbGamma.Text == "")
            //{
            //    tbGamma.Text = "0";
            //}

            //hscGamma.Value = Convert.ToInt16(Convert.ToDouble(tbGamma.Text.Replace(".", ","))*100);

            //else if ((Convert.ToInt16(tbGamma.Text) <= 8) &&
            //(Convert.ToInt16(tbGamma.Text) >= 0))
            //{
            //    hscGamma.Value = Convert.ToInt16(tbGamma.Text);
            //}
            //else
            //{
            //    MessageBox.Show("Input nilai Error");
            //    tbGamma.Text = "0";
            //}
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmGamma_Load(object sender, EventArgs e)
        {
            tbGamma.Text = hscGamma.Value.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
