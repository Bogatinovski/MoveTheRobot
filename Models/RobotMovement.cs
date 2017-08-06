using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MoveTheRobot.Models
{
    public class RobotMovement
    {
        public Guid Id { get; set; }
        public Guid RobotConfigurationId { get; set; }
        public string Name { get; set; }

        public ICollection<MovementStep> Steps { get; set; }

        public bool Save(string filepath)
        {
            XmlDocument document = new XmlDocument();

            XmlElement root = document.CreateElement("Configuration");
            root.SetAttribute("Id", Id.ToString());
            root.SetAttribute("RobotConfigurationId", RobotConfigurationId.ToString());
            root.SetAttribute("Name", Name);

            XmlElement stepsNode = document.CreateElement("Steps");
            root.AppendChild(stepsNode);

            document.AppendChild(root);
            document.Save(filepath);

            return true;
        }
    }
}
