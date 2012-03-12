namespace TaskCloud.GUI
{
    partial class frmTaskCloud
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chkTechDept = new System.Windows.Forms.CheckBox();
            this.chkFeatures = new System.Windows.Forms.CheckBox();
            this.chkShowDefects = new System.Windows.Forms.CheckBox();
            this.chkGetAllTasks = new System.Windows.Forms.CheckBox();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.txtFilename = new System.Windows.Forms.TextBox();
            this.btnGetTasks = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(608, 618);
            this.panel1.TabIndex = 4;
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackColor = System.Drawing.Color.White;
            this.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBox1.Location = new System.Drawing.Point(0, 0);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(608, 618);
            this.PictureBox1.TabIndex = 1;
            this.PictureBox1.TabStop = false;
            this.PictureBox1.DoubleClick += new System.EventHandler(this.PictureBox1_DoubleClick);
            this.PictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseDown);
            this.PictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseMove);
            this.PictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseUp);
            this.PictureBox1.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseWheel);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chkTechDept);
            this.panel2.Controls.Add(this.chkFeatures);
            this.panel2.Controls.Add(this.chkShowDefects);
            this.panel2.Controls.Add(this.chkGetAllTasks);
            this.panel2.Controls.Add(this.btnSaveChanges);
            this.panel2.Controls.Add(this.txtFilename);
            this.panel2.Controls.Add(this.btnGetTasks);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 523);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(608, 95);
            this.panel2.TabIndex = 5;
            // 
            // chkTechDept
            // 
            this.chkTechDept.AutoSize = true;
            this.chkTechDept.Checked = true;
            this.chkTechDept.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTechDept.Location = new System.Drawing.Point(238, 15);
            this.chkTechDept.Name = "chkTechDept";
            this.chkTechDept.Size = new System.Drawing.Size(97, 17);
            this.chkTechDept.TabIndex = 10;
            this.chkTechDept.Text = "Technical dept";
            this.chkTechDept.UseVisualStyleBackColor = true;
            // 
            // chkFeatures
            // 
            this.chkFeatures.AutoSize = true;
            this.chkFeatures.Checked = true;
            this.chkFeatures.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFeatures.Location = new System.Drawing.Point(165, 15);
            this.chkFeatures.Name = "chkFeatures";
            this.chkFeatures.Size = new System.Drawing.Size(67, 17);
            this.chkFeatures.TabIndex = 9;
            this.chkFeatures.Text = "Features";
            this.chkFeatures.UseVisualStyleBackColor = true;
            // 
            // chkShowDefects
            // 
            this.chkShowDefects.AutoSize = true;
            this.chkShowDefects.Checked = true;
            this.chkShowDefects.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowDefects.Location = new System.Drawing.Point(96, 15);
            this.chkShowDefects.Name = "chkShowDefects";
            this.chkShowDefects.Size = new System.Drawing.Size(63, 17);
            this.chkShowDefects.TabIndex = 8;
            this.chkShowDefects.Text = "Defects";
            this.chkShowDefects.UseVisualStyleBackColor = true;
            // 
            // chkGetAllTasks
            // 
            this.chkGetAllTasks.AutoSize = true;
            this.chkGetAllTasks.Checked = true;
            this.chkGetAllTasks.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGetAllTasks.Location = new System.Drawing.Point(12, 64);
            this.chkGetAllTasks.Name = "chkGetAllTasks";
            this.chkGetAllTasks.Size = new System.Drawing.Size(84, 17);
            this.chkGetAllTasks.TabIndex = 7;
            this.chkGetAllTasks.Text = "Get all tasks";
            this.chkGetAllTasks.UseVisualStyleBackColor = true;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(498, 64);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(98, 20);
            this.btnSaveChanges.TabIndex = 6;
            this.btnSaveChanges.Text = "Save changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // txtFilename
            // 
            this.txtFilename.Location = new System.Drawing.Point(12, 38);
            this.txtFilename.Name = "txtFilename";
            this.txtFilename.Size = new System.Drawing.Size(229, 20);
            this.txtFilename.TabIndex = 5;
            this.txtFilename.Text = "c:/temp/tasks2.xml";
            // 
            // btnGetTasks
            // 
            this.btnGetTasks.Location = new System.Drawing.Point(12, 12);
            this.btnGetTasks.Name = "btnGetTasks";
            this.btnGetTasks.Size = new System.Drawing.Size(78, 20);
            this.btnGetTasks.TabIndex = 4;
            this.btnGetTasks.Text = "Get tasks";
            this.btnGetTasks.UseVisualStyleBackColor = true;
            this.btnGetTasks.Click += new System.EventHandler(this.btnGetTasks_Click);
            // 
            // frmTaskCloud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(608, 618);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmTaskCloud";
            this.Text = "TaskCloud";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox chkGetAllTasks;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.TextBox txtFilename;
        private System.Windows.Forms.Button btnGetTasks;
        private System.Windows.Forms.CheckBox chkShowDefects;
        private System.Windows.Forms.CheckBox chkTechDept;
        private System.Windows.Forms.CheckBox chkFeatures;

    }
}

