namespace Task_2
{
    public class Point
    {
        private double _x;
        private double _y;
        private string _name;

        public double X
        {
            get { return _x; }
        }

        public double Y
        {
            get { return _y; }
        }

        public string Name
        {
            get { return _name; }
        }

        public Point(double x, double y, string name)
        {
            _x = x;
            _y = y;
            _name = name;
        }
    }
}