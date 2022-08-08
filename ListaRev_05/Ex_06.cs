using System; 

public class Program {
  public static double Frete(double massa, double distancia) {
    return 0.01 * massa * distancia;
  }

  public static void Main(string[] args) {
    double n1 = double.Parse(Console.ReadLine());
    double n2 = double.Parse(Console.ReadLine());
    Console.WriteLine(Frete(n1,n2));
  }
}
