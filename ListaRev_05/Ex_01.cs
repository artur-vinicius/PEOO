using System; 

public class Program {
  public static double Menor(double x, double y) {
    double menor = 0;
    if  (x<=y) menor = x;
    else menor = y;
    return menor;      
  }

  public static void Main(string[] args) {
      Console.WriteLine(Menor(double.Parse(Console.ReadLine()),double.Parse(Console.ReadLine())));
  }
}