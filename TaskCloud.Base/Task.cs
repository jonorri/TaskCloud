using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace TaskCloud.Base
{
    public class Task
    {
        int _priority;

        [XmlElement("priority")]
        public int Priority
        {
            get { return _priority; }
            set { _priority = value < 1 ? 1 : value; }
        }

        [XmlAttribute("id")]
        public int TaskId { get; set; }

        [XmlElement("name")]
        public string TaskName { get; set; }

        [XmlElement("description")]
        public string Description { get; set; }

        [XmlElement("active")]
        public bool Activity { get; set; }

        [XmlElement("xValue")]
        public int xValue { get; set; }

        [XmlElement("yValue")]
        public int yValue { get; set; }

        [XmlElement("taskType")]
        public TaskType TaskType { get; set; }

        public float Height { get; set; }

        public float Width { get; set; }
    }
}
