namespace RobotControl.Serial
{
    public class Instruction
    {
        public byte baseServoAngle { get; set; }
        public byte joint1Angle { get; set; }
        public byte joint2Angle { get; set; }
        public int delay { get; set; }
    }
}
