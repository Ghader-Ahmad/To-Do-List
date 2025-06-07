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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        string OldLine;
        string path = @"E:\Projects Outside 14\To Do List\To_Do_List.txt";

        private void TaskNotExists()
        {
            MessageBox.Show("Task was not found!", "Invaild Title: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void UpdateUserInterfaceAfterTaskExists()
        {
            txtTaskName.Enabled = false;
            cbCompletionPeroid.Enabled = false;

            btnEdit.Visible = true;
        }

        private void TaskExists()
        {
            MessageBox.Show("Task was found!", "Vaild Title: ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            UpdateUserInterfaceAfterTaskExists();
        }

        private bool ValidationInput()
        {
            if (string.IsNullOrEmpty(txtTaskName.Text) || string.IsNullOrEmpty(cbCompletionPeroid.Text))
            {
                MessageBox.Show("The input field must not be empty !", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            else
                return false;
        }

        private void Search()
        {
            if (ValidationInput())
                return;

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
                        return;
                    }
                }
                TaskNotExists(); 
            }

        }

        private void UpdateButton()
        {
            btnSearch.Visible = false;
            btnSave.Visible = true;
            btnDelete.Visible = true;
            btnReset.Visible = true;
        }

        private void UpdateInputFields()
        {
            txtTaskName.Enabled = true;
            cbCompletionPeroid.Enabled = true;

            lblPromisedTime.Visible = true;
            dateTimePicker.Visible = true;
        }
             
        private void UpdateUserInterface()
        {
            UpdateButton();
            UpdateInputFields();
        }

        private void Edit()
        {
            UpdateUserInterface();
        }

        private void UpdateButtonAfterSave()
        {
            btnSave.Visible = false;
            btnEdit.Visible = false;
            btnDelete.Visible = false;

            btnSearch.Visible = true;
        }

        private void UpdateInputFieldsAfterSave()
        {
            lblPromisedTime.Visible = false;
            dateTimePicker.Visible = false;

            txtTaskName.Text = "";
            cbCompletionPeroid.Text = "";
        }

        private void UpdateUserInterfaceAfterClickSave()
        {
            UpdateButtonAfterSave();
            UpdateInputFieldsAfterSave();
        }
        
        private void Save()
        {
            string NewLine = txtTaskName.Text + "," + cbCompletionPeroid.Text + "," + dateTimePicker.Value;

            if (File.Exists(path))
            {
                string[] Lines = File.ReadAllLines(path);

                for (int i = 0; i < Lines.Length; i++)
                {
                    if (Lines[i] == OldLine)
                        Lines[i] = NewLine;
                }
                File.WriteAllLines(path, Lines);
            }

            UpdateUserInterfaceAfterClickSave();
        }

        private void Delete()
        {
            string[] Lines = File.ReadAllLines(path);

            var updateLines = new List<string>();

            foreach (var Line in Lines)
            {
                if (Line != OldLine)
                {
                    updateLines.Add(Line);
                }
            }

            File.WriteAllLines(path, updateLines);
            UpdateUserInterfaceAfterClickSave();
        }

        private void ResetButton()
        {
            btnDelete.Visible = false;
            btnEdit.Visible = false;
            btnSave.Visible = false;
            btnReset.Visible = false;
            btnSearch.Visible = true;
        }

        private void ResetInputFields()
        {
            txtTaskName.Text = "";
            cbCompletionPeroid.Text = "";
            
            lblPromisedTime.Visible = false;
            dateTimePicker.Visible = false;
        }

        private void Reset()
        {
            ResetButton();
            ResetInputFields();
        }







        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Clock_Tick(object sender, EventArgs e)
        {
            lblDateAndTime.Text = DateTime.Now.ToString("dd/MM/yyyy - hh:mm:ss tt");
        }
    }
}
