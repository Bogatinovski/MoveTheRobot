using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveTheRobot.Models
{
    public class MovementStep
    {
        public Guid Id { get; set; }
        public Guid MovementId { get; set; }

        public ICollection<MotorState> States { get; set; }
    }
}
