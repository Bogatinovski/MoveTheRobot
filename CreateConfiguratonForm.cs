using MoveTheRobot.Controls;
using MoveTheRobot.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoveTheRobot
{
    public partial class CreateConfiguratonForm : Form
    {
        private ICollection<AddMotorControl> motorsControls;
        public RobotConfiguration RobotConfiguration { get; set; }

        public CreateConfiguratonForm()
        {
            InitializeComponent();
            motorsControls = new List<AddMotorControl>();

        }

        private void CreateConfiguratonForm_Load(object sender, EventArgs e)
        {
           
        }

        private void addMotorBtn_Click(object sender, EventArgs e)
        {
            Motor motor = new Motor
            {
                Id = Guid.NewGuid(),
                Name = motorName.Text,
                MinValue = (int)motorMinValue.Value,
                MaxValue = (int)motorMaxValue.Value
            };

            motorsControls.Add(new AddMotorControl(motorsPanel, motor, motorsControls));
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            RobotConfiguration = new RobotConfiguration();

            RobotConfiguration.Name = nameTextBox.Text;
            RobotConfiguration.Id = Guid.NewGuid();
            RobotConfiguration.Motors = new List<Motor>();

            foreach (AddMotorControl motorControl in motorsControls)
            {
                Motor motor = motorControl.Motor;
                motor.RobotConfigurationId = RobotConfiguration.Id;
                RobotConfiguration.Motors.Add(motor);
            }

            bool saved = RobotConfiguration.Save();

            if (!saved)
            {
                Debug.WriteLine("File already exists!");
            }
        }
    }
}
