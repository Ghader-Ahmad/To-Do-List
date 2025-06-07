namespace To_Do_List
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pbSearchForTask = new System.Windows.Forms.PictureBox();
            this.pbShowAllTask = new System.Windows.Forms.PictureBox();
            this.pbAddNewTask = new System.Windows.Forms.PictureBox();
            this.btnExist = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearchForTask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShowAllTask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddNewTask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Monotype Corsiva", 72F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Lime;
            this.lblTitle.Location = new System.Drawing.Point(258, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(446, 117);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "To-Do-List";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Segoe Marker", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(21, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Add New Task";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Yellow;
            this.label2.Font = new System.Drawing.Font("Segoe Marker", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(353, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 40);
            this.label2.TabIndex = 3;
            this.label2.Text = "Show All Tasks";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Yellow;
            this.label3.Font = new System.Drawing.Font("Segoe Marker", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(684, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 40);
            this.label3.TabIndex = 4;
            this.label3.Text = "Search For Task";
            // 
            // pbSearchForTask
            // 
            this.pbSearchForTask.Image = global::To_Do_List.Properties.Resources.SearchForTask;
            this.pbSearchForTask.Location = new System.Drawing.Point(729, 229);
            this.pbSearchForTask.Name = "pbSearchForTask";
            this.pbSearchForTask.Size = new System.Drawing.Size(148, 153);
            this.pbSearchForTask.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSearchForTask.TabIndex = 7;
            this.pbSearchForTask.TabStop = false;
            this.pbSearchForTask.Click += new System.EventHandler(this.pbSearchForTask_Click);
            // 
            // pbShowAllTask
            // 
            this.pbShowAllTask.Image = global::To_Do_List.Properties.Resources.ShowAllTask;
            this.pbShowAllTask.Location = new System.Drawing.Point(391, 229);
            this.pbShowAllTask.Name = "pbShowAllTask";
            this.pbShowAllTask.Size = new System.Drawing.Size(148, 153);
            this.pbShowAllTask.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbShowAllTask.TabIndex = 6;
            this.pbShowAllTask.TabStop = false;
            this.pbShowAllTask.Click += new System.EventHandler(this.pbShowAllTask_Click);
            // 
            // pbAddNewTask
            // 
            this.pbAddNewTask.Image = global::To_Do_List.Properties.Resources.AddNewTask;
            this.pbAddNewTask.Location = new System.Drawing.Point(53, 229);
            this.pbAddNewTask.Name = "pbAddNewTask";
            this.pbAddNewTask.Size = new System.Drawing.Size(148, 153);
            this.pbAddNewTask.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAddNewTask.TabIndex = 5;
            this.pbAddNewTask.TabStop = false;
            this.pbAddNewTask.Click += new System.EventHandler(this.pbAddNewTask_Click);
            // 
            // btnExist
            // 
            this.btnExist.BackColor = System.Drawing.Color.Yellow;
            this.btnExist.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnExist.FlatAppearance.BorderSize = 2;
            this.btnExist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExist.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExist.ForeColor = System.Drawing.Color.Lime;
            this.btnExist.Location = new System.Drawing.Point(416, 432);
            this.btnExist.Name = "btnExist";
            this.btnExist.Size = new System.Drawing.Size(123, 45);
            this.btnExist.TabIndex = 9;
            this.btnExist.Text = "Exist";
            this.btnExist.UseVisualStyleBackColor = false;
            this.btnExist.Click += new System.EventHandler(this.btnExist_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::To_Do_List.Properties.Resources.ToDoList;
            this.pictureBox2.Location = new System.Drawing.Point(28, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(122, 120);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::To_Do_List.Properties.Resources.ToDoList;
            this.pictureBox1.Location = new System.Drawing.Point(791, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(941, 489);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnExist);
            this.Controls.Add(this.pbSearchForTask);
            this.Controls.Add(this.pbShowAllTask);
            this.Controls.Add(this.pbAddNewTask);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form2";
            this.Text = "Main ";
            ((System.ComponentModel.ISupportInitialize)(this.pbSearchForTask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShowAllTask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddNewTask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbAddNewTask;
        private System.Windows.Forms.PictureBox pbShowAllTask;
        private System.Windows.Forms.PictureBox pbSearchForTask;
        private System.Windows.Forms.Button btnExist;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}