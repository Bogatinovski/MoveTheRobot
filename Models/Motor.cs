using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveTheRobot.Models
{
    public class Motor
    {
        public Guid Id { get; set; }
        public string Key { get; set; }
        public int MinValue { get; set; }
        public int MaxValue { get; set; }

        public Guid RobotConfigurationId { get; set; }
        public ICollection<MotorState> MotorStates { get; set; }
    }
}
