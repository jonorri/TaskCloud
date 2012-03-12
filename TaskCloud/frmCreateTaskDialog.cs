using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TaskCloud
{
    public partial class frmCreateTaskDialog : Form
    {
        TaskCloud.Logic.Tasks _logics;
        private int _xPos;
        private int _yPos;
        private Base.Task _task;
        public frmCreateTaskDialog(int xPos, int yPos, TaskCloud.Logic.Tasks logics, TaskCloud.Base.Task task = null)
        {
            InitializeComponent();
            _xPos = xPos;
            _yPos = yPos;
            _logics = logics;
            if (task != null)
            {
                txtTaskName.Text = task.TaskName;
                nmPriority.Value = task.Priority;
                txtDescription.Text = task.Description;
                chkActive.Checked = task.Activity;
                _task = task;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool update = true;
            if (_task == null)
            { 
                _task = new Base.Task();
                _task.TaskId = _logics.GetNewId();
                update = false;
            }
            _task.TaskName = txtTaskName.Text;
            _task.Description = txtDescription.Text;
            _task.Priority = (int)(nmPriority.Value);
            _task.Activity = chkActive.Checked;
            _task.xValue = _xPos;
            _task.yValue = _yPos;
            if (update)
                _logics.UpdateTask(_task);
            else
                _logics.CreateTask(_task);
            this.Dispose();
        }
    }
}
