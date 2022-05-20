using System; 

public class Program {

  public static void Main(string[] args) {
    string[] n = Console.ReadLine().Split(' ');
    int x = int.Parse(n[0]);
    int y = int.Parse(n[1]);
    if (x>=0 && y>=0 && x<433 && y<469) Console.WriteLine("dentro");
    else Console.WriteLine("fora");
  }
}