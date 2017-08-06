using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveTheRobot.Models
{
    public class RobotMovement
    {
        public Guid Id { get; set; }
        public Guid RobotConfigurationId { get; set; }

        public ICollection<MovementStep> Steps { get; set; }
    }
}
