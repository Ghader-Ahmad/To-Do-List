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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        string OldLine;
        string path = @"E:\Projects Outside 14\To Do List\To_Do_List.txt";

        private bool ValidationInput()
        {
            if (string.IsNullOrEmpty(txtTaskName.Text) || string.IsNullOrEmpty(cbCompletionPeroid.Text))
            {
                MessageBox.Show("Worng Input !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            else
                return true;
        }

        private void UpdateUserInterface()
        {
            txtTaskName.Text = "";
            cbCompletionPeroid.Text = "";
        }

        private void TaskExists()
        {
            MessageBox.Show("Task was found Please Another Task!", "Note : ",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            UpdateUserInterface();
        }

        private bool DoesTheTaskExists()
        {
            if (File.Exists(path))
            {
                string[] Lines = File.ReadAllLines(path);

                foreach (string item in Lines)
                {
                    string[] arr = (item.Split(','));

                    if (arr[0] == txtTaskName.Text && arr[1] == cbCompletionPeroid.Text)
                    {
                        OldLine = item;
                        TaskExists();
                        return true;
                    }
                }
            }
            return false;
        }

        private void AddNewTask()
        {
            if (!ValidationInput() || DoesTheTaskExists())
                return;         
            
            checkedListBox.Items.Add(txtTaskName.Text + ","  + cbCompletionPeroid.Text  + "," +
                dateTimePicker.Value.ToString());

            UpdateUserInterface();
        }

        private void AddTheTaskToTheFile()
        {
            for (int i = 0; i < Form3.Instance.checkedListBox.CheckedItems.Count; i++)
            {
                string textToAppend = Form3.Instance.checkedListBox.CheckedItems[i].ToString();

                using (StreamWriter sw = new StreamWriter(path, true))
                {
                    sw.WriteLine(textToAppend);
                }
            }
        }

        private void Delete()
        {
            checkedListBox.Items.Remove(checkedListBox.SelectedItem);
        }

        private void Reset()
        {
            txtTaskName.Text = "";
            cbCompletionPeroid.Text = "";
            checkedListBox.Items.Clear();
        }

        private void Back()
        {
            this.Close();
        }

        
        



        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddNewTask();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Back();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete();
        }
        
        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            AddTheTaskToTheFile();
        }

        private void Clock_Tick(object sender, EventArgs e)
        {
            lblDateAndTime.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt");
        }
    }
}
