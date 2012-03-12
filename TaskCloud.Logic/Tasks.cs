using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaskCloud.Logic
{
    public class Tasks
    {
        private TaskCloud.DAL.Tasks dal;
        public Tasks(string filename)
        {
            dal = new TaskCloud.DAL.Tasks();
            dal.filename = filename;

            GetTasks();
        }

        private Base.Tasks _tasks;
        public Base.Tasks TasksObject
        {
            get { return _tasks; }
            set { _tasks = value; }
        }

        public int GetNewId()
        {
            return (from p in TasksObject.TaskList
                    orderby p.TaskId descending
                    select p.TaskId + 1).First();
        }

        public Base.Task GetSelectedTask(int x, int y)
        {
            Base.Task taskToReturn = null;

            foreach (Base.Task task in TasksObject.TaskList)
            {
                if (CheckStringAndMouseCollision(task, x, y))
                {
                    taskToReturn = task;
                }
            }
            return taskToReturn;
        }

        private bool CheckStringAndMouseCollision(Base.Task task, int xMousePos, int yMousePos)
        {
            if((xMousePos > task.xValue && xMousePos < task.xValue + task.Width) && (yMousePos > task.yValue && yMousePos < task.yValue + task.Height))
            {
                return true;
            }
            return false;
        }

        public void GetTasks()
        {
            TasksObject = dal.GetAllTasks();
        }

        public void CreateTask(Base.Task task)
        {
            TasksObject.TaskList.Add(task);
        }

        public void UpdateTask(Base.Task task)
        {
            TasksObject.TaskList.Where(x => x.TaskId == task.TaskId).FirstOrDefault().TaskName = task.TaskName;
            TasksObject.TaskList.Where(x => x.TaskId == task.TaskId).FirstOrDefault().Description = task.Description;
            TasksObject.TaskList.Where(x => x.TaskId == task.TaskId).FirstOrDefault().Priority = task.Priority;
            TasksObject.TaskList.Where(x => x.TaskId == task.TaskId).FirstOrDefault().Activity = task.Activity;
        }

        public void UpdateTaskPosition(Base.Task task)
        {
            TasksObject.TaskList.Where(x => x.TaskId == task.TaskId).FirstOrDefault().xValue = task.xValue;
            TasksObject.TaskList.Where(x => x.TaskId == task.TaskId).FirstOrDefault().yValue = task.yValue;
        }

        public void UpdateTaskPriority(Base.Task task)
        {
            TasksObject.TaskList.Where(x => x.TaskId == task.TaskId).FirstOrDefault().Priority = task.Priority;
        }

        public void UpdateTasks()
        {
            dal.UpdateTasks(TasksObject);
        }
    }
}
