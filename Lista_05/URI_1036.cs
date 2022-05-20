using System; 

public class Program {

  public static void Main(string[] args) {
    string[] n = Console.ReadLine().Split(' ');
    double a = double.Parse(n[0]);
    double b = double.Parse(n[1]);
    double c = double.Parse(n[2]);
    double delta = (b*b) - (4*a*c);
    double rdelta = Math.Sqrt(delta);
    double x1 = ((-1*b) + rdelta) / (2*a);
    double x2 = ((-1*b) - rdelta) / (2*a);
    if (a==0 || b==0 || c==0 || delta<=0  ){
      Console.WriteLine("Impossivel calcular"); }
    else {
      Console.WriteLine($"R1 = {x1:0.00000}");
      Console.WriteLine($"R2 = {x2:0.00000}"); }
  }
}