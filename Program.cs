using AAAAAAAAAAAAAA.models;
Calc calculadora = new Calc();

calculadora.somar(10 , 30);
calculadora.subtrair(10, 50);
calculadora.Multiplicar(15, 45);
calculadora.DivisãoComum(2, 2);
calculadora.DivisãoResto(10, 5);

calculadora.Potencia(3,3);

calculadora.Seno(30);
calculadora.Coseno(30);
calculadora.Tangente(30);


int N = 10;
Console.WriteLine("Número no começo " + N);
N++;
Console.WriteLine("Númreo após o incremento em 1 = " + N);
N = 10;
N--;
Console.WriteLine("Númreo após o decremento em 1 = " + N);


calculadora.RaizQuadrada(9);