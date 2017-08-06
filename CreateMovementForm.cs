using MoveTheRobot.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace MoveTheRobot
{
    public partial class CreateMovementForm : Form
    {
        public CreateMovementForm()
        {
            InitializeComponent();
        }

        private void CreateMovementForm_Load(object sender, EventArgs e)
        {
            IEnumerable<RobotConfiguration> configurations = LoadRobotConfigurations();

            listBox1.Items.AddRange(configurations.ToArray());
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = saveFileDialog1.ShowDialog();

            if(result == DialogResult.OK)
            {
                RobotMovement movement = new RobotMovement
                {
                    Id = Guid.NewGuid(),
                    Name = nameTextBox.Text,
                    RobotConfigurationId = ((RobotConfiguration)listBox1.SelectedItem).Id,
                    Steps = new List<MovementStep>()
                };

                Debug.WriteLine(saveFileDialog1.FileName);

                movement.Save(saveFileDialog1.FileName);
            }
        }

        private IEnumerable<RobotConfiguration> LoadRobotConfigurations()
        {
            ICollection<RobotConfiguration> configurations = new List<RobotConfiguration>();

            string directory = string.Format("{0}\\{1}", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "MoveTheRobot");

            foreach (string filePath in Directory.EnumerateFiles(directory))
            {
                XmlDocument document = new XmlDocument();
                document.Load(filePath);

                XmlNode configurationNode = document.FirstChild;

                RobotConfiguration configuration = new RobotConfiguration
                {
                    Id = new Guid(configurationNode.Attributes["Id"].Value),
                    Name = configurationNode.Attributes["Name"].Value,
                    Motors = new List<Motor>()
                };

                XmlNodeList motorsNodes = configurationNode.FirstChild.ChildNodes;

                foreach (XmlNode motorNode in motorsNodes)
                {
                    Motor motor = new Motor
                    {
                        Id = new Guid(motorNode.Attributes["Id"].Value),
                        Name = motorNode.Attributes["Name"].Value,
                        MinValue = int.Parse(motorNode.Attributes["MinValue"].Value),
                        MaxValue = int.Parse(motorNode.Attributes["MaxValue"].Value),
                        RobotConfigurationId = new Guid(motorNode.Attributes["RobotConfigurationId"].Value)
                    };

                    configuration.Motors.Add(motor);
                }

                configurations.Add(configuration);
                Debug.WriteLine(configuration.ToString());
            }

            return configurations;
        }
    }
}
