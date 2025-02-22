namespace UIPractice.MainApplication
{
    public class MousePositionInfo
    {
        public double X { get; }
        public double Y { get; }

        public MousePositionInfo(double x, double y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"X: {X:F2}, Y: {Y:F2}";
        }

    }
}
