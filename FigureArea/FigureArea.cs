namespace FigureArea
{
    public static class FigureArea
    {
        public static bool IsRightTriangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new Exception("Values must be greater than zero");
            }

            double squareA = Math.Pow(a, 2);
            double squareB = Math.Pow(b, 2);
            double squareC = Math.Pow(c, 2);

            if (squareA + squareB == squareC || squareA + squareC == squareB || squareB + squareC == squareA)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static double CalculateArea(double r)
        {
            if (r <= 0)
            {
                throw new Exception("Radius must be greater than zero");
            }

            return Math.Round(Math.PI, 2) * Math.Pow(r, 2);
        }

        public static double CalculateArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new Exception("Values must be greater than zero");
            }

            double p = (a + b + c) / 2;

            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}