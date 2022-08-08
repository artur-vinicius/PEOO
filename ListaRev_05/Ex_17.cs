using System; 

public class Program {
  public static int MDC(int x, int y) {
    int n = 0;
    while (y != 0) {
      n = y;
      y = x % y;
      x = n;      
    }
    return x;
  }
  public static int MMC(int x, int y) {
    return (x / MDC(x, y)) * y;
  }
  public static void Main(string[] args) {
    int n1 = int.Parse(Console.ReadLine());
    int n2 = int.Parse(Console.ReadLine());
    Console.WriteLine(MMC(n1, n2));
  }
}