using System; 

public class Program {

  public static void Main(string[] args) {
    int n1 = int.Parse(Console.ReadLine());
    int n2 = int.Parse(Console.ReadLine());
    int n3 = int.Parse(Console.ReadLine());
    int t1 = (n1*4) + (n2*2);
    int t2 = (n1*2) + (n3*2);
    int t3 = (n3*4) + (n2*2);
    if (t1<=t2 && t1<=t3) Console.WriteLine(t1);
    else if (t2<=t3 && t2<=t1) Console.WriteLine(t2);
    else Console.WriteLine(t3);
  }
}