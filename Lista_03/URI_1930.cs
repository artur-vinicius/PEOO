using System; 

public class Program {

  public static void Main(string[] args) {
    string[] n = Console.ReadLine().Split(' ');
    int t1 = int.Parse(n[0]);
    int t2 = int.Parse(n[1]);
    int t3 = int.Parse(n[2]);
    int t4 = int.Parse(n[3]);
    int tomad = (t1-1) + (t2-1) + (t3-1) + t4;
    Console.WriteLine(tomad);
  }
}
