using System; 

public class Program {

  public static void Main(string[] args) {
    Console.WriteLine("Digite uma Frase:");
    string x = Console.ReadLine();
    int p = x.IndexOf(' ');
    while (p != -1){
      x = x.Substring(p+1);
      Console.WriteLine(x);
      p = x.IndexOf(' ');
    }
  }
}