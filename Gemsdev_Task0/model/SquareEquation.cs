namespace Gemsdev_Task0
{
    public class SquareEquation
    {
        private double _a;
        private double _b;
        private double _c;

        public SquareEquation(double a, double b, double c)
        {
            //По определению квадратного уравнения a != 0, поэтому проверим:
            if (a == 0)
            {
                throw new ArgumentException("Недопустимое значение параметра a!");
            }
            _a = a;
            _b = b;
            _c = c;
        }

        public double A
        {
            get => _a;
            set
            {
                if (value == 0)
                {
                    throw new ArgumentException("Недопустимое значение параметра a!");
                }
                _a = value;
            }
        }

        public double B
        {
            get => _b;
            set => _b = value;
        }

        public double C
        {
            get => _c;
            set => _c = value;
        }
    }
}