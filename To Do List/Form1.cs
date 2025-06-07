using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace To_Do_List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private byte Count = 10;

        private void ShowFormMain()
        {
            Form2 frm = new Form2();

            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void Counter_Tick(object sender, EventArgs e)
        {
            if (Count > 0)
            {
                lblCounter.Text = Count.ToString();
                Count--;
            }
            else
            {
                Counter.Enabled = false;
                ShowFormMain();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Counter.Enabled = true;
        }

    }
}
