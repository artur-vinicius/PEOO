using System; 

public class Program {

  public static void Main(string[] args) {
    double t = double.Parse(Console.ReadLine());
    double km = double.Parse(Console.ReadLine());
    double lit = (t*km) / 12;
    Console.WriteLine($"{lit:0.000}");
  }
}
