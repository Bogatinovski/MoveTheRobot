using MoveTheRobot.Persistance;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MoveTheRobot.Models
{
    public class RobotConfiguration : Repository
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public ICollection<Motor> Motors { get; set; }
        public ICollection<RobotMovement> Movements { get; set; }

        public override string ToString()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.AppendFormat("Configuration Name: {0}", Name);
            strBuilder.AppendLine();
            strBuilder.Append("Motors: ");

            foreach(Motor motor in Motors)
            {
                strBuilder.AppendFormat("\n\t{0}", motor.ToString());
            }

            return strBuilder.ToString();
        }

        public bool Save()
        {
            string directory = string.Format("{0}\\{1}", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "MoveTheRobot");
            string fullPath = string.Format("{0}\\{1}.{2}", directory, Name, "rcfg");

            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            if(File.Exists(fullPath))
            {
                return false;
            }

            XmlDocument document = new XmlDocument();

            XmlElement root = document.CreateElement("Configuration");
            root.SetAttribute("id", Id.ToString());

            XmlElement nameElem = document.CreateElement("Name");
            nameElem.InnerText = Name;
            root.AppendChild(nameElem);

            XmlElement motorsElem = document.CreateElement("Motors");
            root.AppendChild(motorsElem);

            foreach(Motor motor in Motors)
            {
                XmlElement motorElem = document.CreateElement("Motor");
                motorElem.SetAttribute("id", motor.Id.ToString());
                motorsElem.AppendChild(motorElem);

                XmlElement motorNameElem = document.CreateElement("Name");
                motorNameElem.InnerText = motor.Name;
                motorElem.AppendChild(motorNameElem);

                XmlElement minValueElem = document.CreateElement("MinValue");
                minValueElem.InnerText = motor.MinValue.ToString();
                motorElem.AppendChild(minValueElem);

                XmlElement maxValueElem = document.CreateElement("MaxValue");
                maxValueElem.InnerText = motor.MaxValue.ToString();
                motorElem.AppendChild(maxValueElem);

                XmlElement robotConfIdElem = document.CreateElement("RobotConfigurationId");
                robotConfIdElem.InnerText = motor.RobotConfigurationId.ToString();
                motorElem.AppendChild(robotConfIdElem);
            }

            document.AppendChild(root);
            document.Save(fullPath);

            return false;
        }
    }
}
