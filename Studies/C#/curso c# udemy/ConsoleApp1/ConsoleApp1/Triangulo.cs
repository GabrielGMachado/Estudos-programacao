namespace NomeAleatorio {
    class Triangulo {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public double CalcularPerimetro() {
            return A + B + C;
        }

        public double CalcularArea() {
            double s = (A + B + C) / 2;
            return Math.Sqrt(s * (s - A) * (s - B) * (s - C));
        }
    }
}