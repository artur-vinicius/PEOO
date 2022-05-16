using System; 

public class Program {

  public static void Main(string[] args) {
    string[] n = Console.ReadLine().Split(' ');
    double a = double.Parse(n[0]);
    double b = double.Parse(n[1]);
    double c = double.Parse(n[2]);
    double atri = (a*c) / 2;
    double acir = (c*c) * 3.14159;
    double atra = ((a+b) * c) / 2;
    double aqua = b * b;
    double aret = a * b;
    Console.WriteLine($"TRIANGULO: {atri:0.000}");
    Console.WriteLine($"CIRCULO: {acir:0.000}");
    Console.WriteLine($"TRAPEZIO: {atra:0.000}");
    Console.WriteLine($"QUADRADO: {aqua:0.000}");
    Console.WriteLine($"RETANGULO: {aret:0.000}");
  }
}
