using System; 

public class Program {
  public static double VolumeEsfera(double r) {
    return (3.14 * Math.Pow(r,3) * 4) / 3;
  }

  public static void Main(string[] args) {
    double n1 = double.Parse(Console.ReadLine());
    Console.WriteLine(VolumeEsfera(n1));
    
  }
}
