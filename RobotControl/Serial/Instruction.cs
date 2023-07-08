namespace RobotControl.Serial
{
    public class Instruction
    {
        public byte baseServoAngle { get; set; }
        public byte joint1Angle { get; set; }
        public byte joint2Angle { get; set; }
        public int delay { get; set; }
        public string description { get; set; }

        public override string ToString()
        {
            return description ?? $"{baseServoAngle} {joint1Angle} {joint2Angle} {delay}";
        }
    }
}
