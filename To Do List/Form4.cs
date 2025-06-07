using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace To_Do_List
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            LoadItems();
        }

        string path = @"E:\Projects Outside 14\To Do List\To_Do_List.txt";


        private void LoadItems()
        { 
            if (File.Exists(path))
            {
                string[] Lines = File.ReadAllLines(path);

                foreach (string item in Lines)
                {
                    string[] arr = (item.Split(','));

                    ListViewItem listViewItem = new ListViewItem(arr[0]);

                    listViewItem.SubItems.Add(arr[1]);
                    listViewItem.SubItems.Add(arr[2]);
                    
                    lvTaskList.Items.Add(listViewItem);
                }
            }

        }

        private bool CheckFilter(string filter, string Text)
        {
            if (filter == "All")
                return true;

            else if (filter == Text)
                return true;

            else
                return false;
        }

        private void Filter(string filter)
        {
            lvTaskList.Items.Clear();

            if (File.Exists(path))
            {
                string[] Lines = File.ReadAllLines(path);

                foreach (string item in Lines)
                {
                    string[] arr = (item.Split(','));

                    if (!CheckFilter(filter, arr[1]))
                        continue;

                    ListViewItem listViewItem = new ListViewItem(arr[0]);

                    listViewItem.SubItems.Add(arr[1]);
                    listViewItem.SubItems.Add(arr[2]);

                    lvTaskList.Items.Add(listViewItem);
                }
            }   
        }

        private void FilterBy(ComboBox comboBox)
        {
            string filter = "";

            switch(comboBox.Text)
            {
                case "Today":
                    filter = "Today";
                    break;

                case "This Week":
                    filter = "This Week";
                    break;

                case "This Month":
                    filter = "This Month";
                    break;
                
                case "This Year":
                    filter = "This Year";
                    break;

                default:
                    filter = "All";
                    break;
            }
            Filter(filter);
        }




      

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterBy((ComboBox)sender);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Clock_Tick(object sender, EventArgs e)
        {
            lblDateAndTime.Text = DateTime.Now.ToString("dd/MM/yyyy - hh:mm:ss tt");
        }
    }
}
