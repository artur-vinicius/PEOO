using System; 

public class Program {

  public static void Main(string[] args) {
    int[] num = new int[10];
    int valor = int.Parse(Console.ReadLine());
    num[0] = valor;

      for (int i=1; i<num.Length; i++) {
        num[i] = valor*2;
        valor = num[i];
      }

    for (int i=0; i<num.Length; i++) {
      Console.WriteLine($"N[{i}] = {num[i]}");
    }
  }
}
