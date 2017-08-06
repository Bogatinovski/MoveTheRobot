using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveTheRobot.Models
{
    public class RobotConfiguration
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public ICollection<Motor> Motors { get; set; }
        public ICollection<RobotMovement> Movements { get; set; }
    }
}
