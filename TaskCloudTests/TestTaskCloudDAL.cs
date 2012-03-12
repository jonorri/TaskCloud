using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TaskCloud.Tests
{
    [TestClass]
    public class TestTaskCloudDAL
    {
        [TestMethod]
        public void TestGetTasks()
        {
            TaskCloud.DAL.Tasks dal = new TaskCloud.DAL.Tasks();
            dal.filename = "C:/temp/tasks2.xml";
            dal.GetAllTasks();
        }

        [TestMethod]
        public void TestCreateTask()
        {
            TaskCloud.DAL.Tasks dal = new TaskCloud.DAL.Tasks();
            dal.filename = "C:/temp/tasks2.xml";

            Base.Tasks tasks = new Base.Tasks();
            Base.Task task1 = new Base.Task();
            Base.Task task2 = new Base.Task();
            Base.Task task3 = new Base.Task();
            task1.Description = "TASK1DESC";
            task1.TaskName = "TASK1";
            task1.Priority = 1;
            task1.TaskId = 1;
            task1.TaskType = Base.TaskType.DEFECT;

            task2.Description = "TASK2DESC";
            task2.TaskName = "TASK2";
            task2.Priority = 2;
            task2.TaskId = 2;
            task2.TaskType = Base.TaskType.DEFECT;

            task3.Description = "TASK3DESC";
            task3.TaskName = "TASK3";
            task3.Priority = 2;
            task3.TaskId = 3;
            task3.TaskType = Base.TaskType.DEFECT;

            tasks.TaskList.Add(task1);
            tasks.TaskList.Add(task2);
            tasks.TaskList.Add(task3);

            dal.UpdateTasks(tasks);
        }
    }
}
