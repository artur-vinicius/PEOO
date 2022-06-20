using System; 

class MainClass {
  public static bool Aprovado(int nota1, int nota2) {
    double m = (nota1 + nota2) / 2;
    if (m >= 60) return true;
    else return false;
  }

  public static void Main(string[] args) {
    int n1 = int.Parse(Console.ReadLine());
    int n2 = int.Parse(Console.ReadLine());
    bool n3 = Aprovado(n1, n2);
    Console.WriteLine(n3);
  }
}