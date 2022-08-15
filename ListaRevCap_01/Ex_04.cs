public class Program {
  
  public static void Main(string[] args) {
    Console.WriteLine("Digite três números inteiros:");
    int n1 = int.Parse(Console.ReadLine());
    int n2 = int.Parse(Console.ReadLine());
    int n3 = int.Parse(Console.ReadLine());
    int m1 = 0;
    int m2 = 0;
    if (n1>=n2 && n1>=n3) {
      m1 = n1;
      if (n2>=n3) m2 = n2;
      else m2 = n3;
    }
    else if  (n2>=n1 && n2>=n3) {
      m1 = n2;
      if (n1>=n3) m2 = n1;
      else m2 = n3;
      }
    else {
      m1 = n3;
      if (n1>=n2) m2 = n1;
      else m2 = n2;
      }
    Console.WriteLine($"Soma dos maiores = {m1+m2}");
  }
}