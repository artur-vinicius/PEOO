using System; 

public class Program {
  public static double Diagonal(double b, double h) {
    return Math.Sqrt(Math.Pow(b,2)+Math.Pow(h,2));
  }

  public static void Main(string[] args) {
    double n1 = double.Parse(Console.ReadLine());
    double n2 = double.Parse(Console.ReadLine());
    Console.WriteLine(Diagonal(n1,n2));
  }
}
