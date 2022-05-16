using System; 

public class Program {

  public static void Main(string[] args) {
    string[] n1 = Console.ReadLine().Split(' ');
    String[] n2 = Console.ReadLine().Split(' ');
    double x1 = double.Parse(n1[0]);
    double y1 = double.Parse(n1[1]);
    double x2 = double.Parse(n2[0]);
    double y2 = double.Parse(n2[1]);
    double dist = Math.Sqrt(((x2-x1)*(x2-x1))+((y2-y1)*(y2-y1)));
    Console.WriteLine($"{dist:0.0000}");
  }
}
