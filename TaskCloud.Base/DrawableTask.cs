using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace TaskCloud.Base
{
    /// <summary>
    /// Summary description for DrawObject.
    /// </summary>
    public class DrawableTask : Task
    {
        private Rectangle boundingRect;
        private Point dragPoint;
        private bool dragging;

        public bool IsDragging()
        {
            return dragging;
        }

        public DrawableTask(Base.Task task)
        {
            Priority = task.Priority;
            TaskId = task.TaskId;
            TaskName = task.TaskName;
            Description = task.Description;
            Activity = task.Activity;
            xValue = task.xValue;
            yValue = task.yValue;
            TaskType = task.TaskType;
            Height  = task.Height;
            Width = task.Width;

            dragging = false;
            boundingRect = new Rectangle(xValue, yValue, (int)Width, (int)Height);
        }

        public bool HitTest(Point pt)
        {
            return boundingRect.Contains(pt);
        }

        public void Drag(Point pt, System.Windows.Forms.Form wnd)
        {
            wnd.Invalidate(boundingRect, false);

            boundingRect.X = pt.X - dragPoint.X;
            boundingRect.Y = pt.Y - dragPoint.Y;

            wnd.Invalidate(boundingRect, false);
        }

        public void BeginDrag(Point pt)
        {
            dragPoint.X = pt.X - boundingRect.X;
            dragPoint.Y = pt.Y - boundingRect.Y;
            dragging = true;
        }

        public void EndDrag()
        {
            dragging = false;
        }

        public void Draw(Graphics g)
        {
            Font font = new Font("Helvetica", Priority * 7, FontStyle.Italic);
            Brush brush = new SolidBrush(System.Drawing.Color.Black);
            if (Activity != true)
                brush = new SolidBrush(System.Drawing.Color.Green);
            g.DrawString(TaskName, font, brush, xValue, yValue);
            Height = g.MeasureString(TaskName, font).Height;
            Width = g.MeasureString(TaskName, font).Width;
        }
    }
}
