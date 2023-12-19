namespace Task_1
{
    public class Rectangle
    {
        private double _firstSide;
        private double _secondSide;

        public double FirstSide
        {
            get { return _firstSide; }
            set { _firstSide = value; }
        }

        public double SecondSide
        {
            get { return _secondSide; }
            set { _secondSide = value; }
        }

        public Rectangle(double firstSide, double secondSide)
        {
            _firstSide = firstSide;
            _secondSide = secondSide;
        }

        public double CalculateArea()
        {
            return _firstSide * _secondSide;
        }

        public double CalculatePerimeter()
        {
            return 2 * (_firstSide + _secondSide);
        }

        public double Area
        {
            get { return CalculateArea(); }
        }

        public double Perimeter
        {
            get { return CalculatePerimeter(); }
        }
    }
}