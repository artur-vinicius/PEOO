using System; 

public class Program {
  public static void AntecessorSucessor (int x, out int antecessor, out int sucessor) {
    antecessor = x-1;
    sucessor = x+1;
  }

  public static void Main(string[] args) {
    int n1 = int.Parse(Console.ReadLine());
    int n2,n3;
    AntecessorSucessor(n1,out n2,out n3);
    Console.WriteLine($"{n2} {n3}");
  }
}
