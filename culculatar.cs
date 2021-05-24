using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class culculatar : Form
    {
        public culculatar()
        {
            InitializeComponent();
        }

        private void btnsum_Click(object sender, EventArgs e)
        {
            int firstnumber = Convert.ToInt32(txtfirstnumber.Text);
            int secondnumber = Convert.ToInt32(txtsecondnumber.Text);
            float result = firstnumber+secondnumber;
            txtresult.Text=result.ToString();

        }

        private void btnsub_Click(object sender, EventArgs e)
        {
            int firstnumber = Convert.ToInt32(txtfirstnumber.Text);
            int secondnumber = Convert.ToInt32(txtsecondnumber.Text);
            float result = firstnumber - secondnumber;
            txtresult.Text = result.ToString();
        }

        private void btnmul_Click(object sender, EventArgs e)
        {
            int firstnumber = Convert.ToInt32(txtfirstnumber.Text);
            int secondnumber = Convert.ToInt32(txtsecondnumber.Text);
            float result = firstnumber * secondnumber;
            txtresult.Text = result.ToString();
        }

        private void btndivid_Click(object sender, EventArgs e)
        {
            int firstnumber = Convert.ToInt32(txtfirstnumber.Text);
            int secondnumber = Convert.ToInt32(txtsecondnumber.Text);
            float result = firstnumber / secondnumber;
            txtresult.Text = result.ToString();
        }

        private void btnmudulus_Click(object sender, EventArgs e)
        {
            int firstnumber = Convert.ToInt32(txtfirstnumber.Text);
            int secondnumber = Convert.ToInt32(txtsecondnumber.Text);
            float result = firstnumber % secondnumber;
            txtresult.Text = result.ToString();
        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            int result = 1;
            int firstnumber = Convert.ToInt32(txtfirstnumber.Text);
            // int secondnumber = Convert.ToInt32(txtsecondnumber.Text);
            if (firstnumber == 2)
            {
                result = result * firstnumber;
                txtresult.Text = result.ToString();
            }
            
            
        }
    }
}
