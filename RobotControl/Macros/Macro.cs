using RobotControl.Serial;
using System.Collections.Generic;

namespace RobotControl.Macros
{
    public class Macro
    {
        public List<Instruction> instructions;

        public Macro(string fileContent)
        {
            instructions = new List<Instruction>();
            //Input 4 space seperated numbers. The first 3 represent the servo 1,2, and 3's angle.
            //The 4th is the delay to wait after executing the current line.

            var lines = fileContent.Split('\n');

            foreach(var line in lines)
            {
                var inputs = line.Trim().Split(' ');
                //TODO: kill
                if (inputs.Length < 4) break;

                bool success = true;
                success &= byte.TryParse(inputs[0], out byte baseServoAngle);
                success &= byte.TryParse(inputs[1], out byte joint1Angle);
                success &= byte.TryParse(inputs[2], out byte joint2Angle);
                success &= int.TryParse(inputs[3], out int delay);
                
                if (!success) break;

                string desc = line;
                if (inputs.Length == 5) desc = inputs[4];

                instructions.Add(new Instruction()
                {
                    baseServoAngle = baseServoAngle,
                    joint1Angle = joint1Angle,
                    joint2Angle = joint2Angle,
                    delay = delay,
                    description = desc
                });
            }
        }
    }
}
