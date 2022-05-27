using System; 

public class Program {

  public static void Main(string[] args) {
    Console.WriteLine("Digite os coeficientes a, b, e c de uma equação do II grau:");
    double a = double.Parse(Console.ReadLine());
    double b = double.Parse(Console.ReadLine());
    double c = double.Parse(Console.ReadLine());
    double delta = (b*b) - (4*a*c);
    double rdelta = Math.Sqrt(delta);
    double x1 = ((-1*b) + rdelta) / (2*a);
    double x2 = ((-1*b) - rdelta) / (2*a);
    if (delta<=0) Console.WriteLine("Impossivel calcular"); 
    else Console.WriteLine($"As raízes são {x1} e {x2}");
  }
}