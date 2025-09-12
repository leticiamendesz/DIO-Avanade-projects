namespace MeuProjeto.Models;
//aqui é apenas a ordem a ser seguida mas o que faz funcionar é o program
public class Calculadora //classe
{
    public void Somar(int x, int y) //a calculadora vai fazer a ação de somar x numero e y numero
    {
        Console.WriteLine($"{x} + {y} = {x + y}"); //ele vai mandar a seguinte mensagem "X numero + Y numero a soma é Z"
    }
    public void Subtrair(int x, int y) //a calculadora vai fazer a ação de somar x numero e y numero
    {
        Console.WriteLine($"{x} - {y} = {x - y}"); //ele vai mandar a seguinte mensagem "X numero + Y numero a soma é Z"
    }
    public void Multiplicar(int x, int y) //a calculadora vai fazer a ação de somar x numero e y numero
    {
        Console.WriteLine($"{x} * {y} = {x * y}"); //ele vai mandar a seguinte mensagem "X numero + Y numero a soma é Z"
    }
    public void Dividir(int x, int y) //a calculadora vai fazer a ação de somar x numero e y numero
    {
        Console.WriteLine($"{x} / {y} = {x / y}"); //ele vai mandar a seguinte mensagem "X numero + Y numero a soma é Z"
    }

    public void Potencia(int x, int y)
    {
        double pot = Math.Pow(x, y); //math.pow ele é para fazer calculos de potencia, double é porque nem sempre o resultado é inteiro, então o double consegue pegar números quebrados sem limites
        Console.WriteLine($"{x}^{y} = {pot}");
    }

    public void Seno(double angulo)
    {
        double radiano = angulo * Math.PI / 180;
        double Seno = Math.Sin(radiano);
        Console.WriteLine($"Seno de {angulo} = {Math.Round(Seno, 4)}");
    }

    public void Coseno(double angulo)
    {
        double radiano = angulo * Math.PI / 180;
        double Coseno = Math.Sin(radiano);
        Console.WriteLine($"Coseno de {angulo} = {Math.Round(Coseno, 4)}");
    }

    public void Tangente(double angulo)
    {
        double radiano = angulo * Math.PI / 180;
        double Tangente = Math.Tan(radiano);
        Console.WriteLine($"Tangente de {angulo} = {Math.Round(Tangente, 4)}");
    }

    public void RaizQuadrada(double x)
    {
        double raiz = Math.Sqrt(x);
        Console.WriteLine($"Raiz quadrada de {x} = {raiz}");
    }
}
