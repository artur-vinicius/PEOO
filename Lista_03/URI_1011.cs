using System; 

public class Program {

  public static void Main(string[] args) {
    double r = double.Parse(Console.ReadLine());
    double pi = 3.14159;
    double vol = (4/3.0) * pi * (r*r*r);
    Console.WriteLine($"VOLUME = {vol:0.000}");
  }
}
