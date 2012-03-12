using System.Xml.Serialization;
using System.Collections.Generic;

namespace TaskCloud.Base
{
    [XmlRoot("Tasks")]
    public class Tasks
    {
        public Tasks()
        {
            TaskList = new List<Task>();
        }
        
        [XmlElement("task")]
        public List<Task> TaskList { get; set; }

    }
}