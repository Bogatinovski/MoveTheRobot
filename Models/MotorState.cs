using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveTheRobot.Models
{
    public class MotorState
    {
        public Guid Id { get; set; }
        public decimal Value { get; set; }

        public Guid MovementStepId { get; set; }
        public Guid MotorId { get; set; }
    }
}
