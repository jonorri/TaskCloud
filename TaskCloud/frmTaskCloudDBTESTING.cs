using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Base = TaskCloud.Base;
using Logic = TaskCloud.Logic;

namespace TaskCloud.GUI
{
    public partial class frmTaskCloudDBTESTING : Form
    {
        private TaskCloud.Logic.Tasks _logics;
        private Base.Task _taskSelected;
        private Point? _mouseLocation;

        public frmTaskCloudDBTESTING()
        {
            InitializeComponent();
            g = PictureBox1.CreateGraphics();
        }

        private Graphics g;

        private void btnGetTasks_Click(object sender, EventArgs e)
        {
            _logics = new TaskCloud.Logic.Tasks(txtFilename.Text);
            _logics.GetTasks();
            
            DrawTasks();
        }

        private void DrawTasks()
        {
            PictureBox1.Refresh();

            IList<Base.Task> tasksToDraw = _logics.TasksObject.TaskList.Where(x => (x.Activity == true || chkGetAllTasks.Checked == true)).ToList();
            foreach (Base.Task task in tasksToDraw)
            {
                Font font = new Font("Helvetica", task.Priority * 7, FontStyle.Italic);
                Brush brush = new SolidBrush(System.Drawing.Color.Black);
                if (task.Activity != true)
                    brush = new SolidBrush(System.Drawing.Color.Green);
                g.DrawString(task.TaskName, font, brush, task.xValue, task.yValue);
                task.Height = g.MeasureString(task.TaskName, font).Height;
                task.Width = g.MeasureString(task.TaskName, font).Width;
            }
            PictureBox1.Focus();
        }

        private void PictureBox1_DoubleClick(object sender, EventArgs e)
        {
            // Create a little input form and create/update a task.
            Point mousePos = Cursor.Position;
            _taskSelected = _logics.GetSelectedTask(PictureBox1.PointToClient(mousePos).X, PictureBox1.PointToClient(mousePos).Y);
            frmCreateTaskDialog frm = new frmCreateTaskDialog(PictureBox1.PointToClient(mousePos).X, PictureBox1.PointToClient(mousePos).Y, _logics, _taskSelected);
            frm.ShowDialog();

            DrawTasks();

            _taskSelected = null;
        }

        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_taskSelected != null)
            { 
                // Change x,y coordinates for object selected.
                int deltaX = Cursor.Position.X - _mouseLocation.Value.X;
                int deltaY = Cursor.Position.Y - _mouseLocation.Value.Y;
                _taskSelected.xValue += deltaX;
                _taskSelected.yValue += deltaY;

                _mouseLocation = Cursor.Position;

                // Repaint canvas.
                _logics.UpdateTaskPosition(_taskSelected);
                DrawTasks();
            }
        }

        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            // Find out which object is selected.
            _mouseLocation = Cursor.Position;
            _taskSelected = _logics.GetSelectedTask(PictureBox1.PointToClient(_mouseLocation.Value).X, PictureBox1.PointToClient(_mouseLocation.Value).Y);
        }

        private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (_taskSelected != null)
            { 
                _logics.UpdateTaskPosition(_taskSelected);
                _taskSelected = null;
                _mouseLocation = null;
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            _logics.UpdateTasks();
        }

        private void PictureBox1_MouseWheel(object sender, MouseEventArgs e)
        {
            // Find out which object is selected.
            Point mousePos = Cursor.Position;
            _taskSelected = _logics.GetSelectedTask(PictureBox1.PointToClient(Cursor.Position).X, PictureBox1.PointToClient(Cursor.Position).Y);
            if (_taskSelected != null)
            {
                _taskSelected.Priority += e.Delta / 120;
                _logics.UpdateTaskPriority(_taskSelected);
                DrawTasks();
            }
            _taskSelected = null;
        }
    }
}