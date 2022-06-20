using System; 

class MainClass {
  public static double Maior(double x, double y, double z) {
    if (x>=y && x>=z) return x;
    else if (y>=x && y>=z) return y;
    else return z;
  }

  public static void Main(string[] args) {
    double n1 = double.Parse(Console.ReadLine());
    double n2 = double.Parse(Console.ReadLine());
    double n3 = double.Parse(Console.ReadLine());
    double n4 = Maior(n1, n2, n3);
    Console.WriteLine($"O Maior Número Entre {n1}, {n2} e {n3} é {n4}");
  }
}