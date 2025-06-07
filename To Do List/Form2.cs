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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void AddNewTask()
        {
            Form3 frm = new Form3();

            this.Hide();
            frm.ShowDialog();

            this.Show();
        }

        private void ShowAllTasks()
        {
            Form4 frm = new Form4();

            this.Hide();
            frm.ShowDialog();

            this.Show();
        }

        private void SearchForTask()
        {
            Form5 frm = new Form5();

            this.Hide();
            frm.ShowDialog();

            this.Show();
        }



        private void pbAddNewTask_Click(object sender, EventArgs e)
        {
            AddNewTask();
        }

        private void pbShowAllTask_Click(object sender, EventArgs e)
        {
            ShowAllTasks();
        }

        private void pbSearchForTask_Click(object sender, EventArgs e)
        {
            SearchForTask();
        }

        private void btnExist_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
