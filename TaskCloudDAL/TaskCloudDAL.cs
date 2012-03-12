using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Text;
using Base = TaskCloud.Base;

namespace TaskCloud.DAL
{
    public class Tasks
    {
        public string filename { get; set; }

        public Base.Tasks GetAllTasks()
        {
            return DeserializeFromXML();
        }

        public void UpdateTasks(Base.Tasks tasks)
        {
            SerializeToXML(tasks);
        }

        public void SerializeToXML(Base.Tasks tasks)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Base.Tasks));
            using (TextWriter textWriter = File.CreateText(filename))
            {
                serializer.Serialize(textWriter, tasks);
            }
        }

        private Base.Tasks DeserializeFromXML()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(Base.Tasks));
            using (TextReader textReader = new StreamReader(filename))
            { 
                Base.Tasks tasks = (Base.Tasks)deserializer.Deserialize(textReader);
                return tasks;
            }
        }
    }
}
