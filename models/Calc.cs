namespace AAAAAAAAAAAAAA.models
{
    public class Calc
    {
        public void somar(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }

        public void subtrair(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x - y}");
        }
            public void Multiplicar(int x, int y)
        {
            Console.WriteLine($"{x} x {y} = {x * y}");
        }
            public void DivisãoComum(int x, int y)
        {
            Console.WriteLine($"{x} / {y} = {x / y}");
        }
            public void DivisãoResto(int x, int y)
        {
            Console.WriteLine($"{x} % {y} = {x % y}");
        }

        public void Potencia(int x, int y)
        {
          double pot =  Math.Pow(x , y);
            Console.WriteLine($"{x}^{y} = {pot} ");
        }

        public void Seno(double angulo)
        {
           double radiano = angulo * Math.PI/ 180;
           double seno = Math.Sin(radiano);
           Console.WriteLine($"seno de {angulo}º = {Math.Round( seno,4)}");
        }
         public void Coseno(double angulo)
        {
           double radiano = angulo * Math.PI/ 180;
           double coseno = Math.Cos(radiano);
           Console.WriteLine($"Coseno de {angulo}º = {Math.Round( coseno,4)}");
        }

         public void Tangente(double angulo)
        {
           double radiano = angulo * Math.PI/ 180;
           double tangente = Math.Tan(radiano);
           Console.WriteLine($"Tangente de {angulo}º = {Math.Round( tangente,4)}");
        }

        public void RaizQuadrada(double x)
        {
           double raiz = Math.Sqrt(x);
            Console.WriteLine($"Raíz quadrada de {x} = {raiz}");
        }
    }


}