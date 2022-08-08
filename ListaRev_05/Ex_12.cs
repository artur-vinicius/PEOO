using System; 

public class Program {
  public static string Senha(string texto) {
    string sn = "";
    foreach (string i in texto.Split(' ')) {
      sn += i.Length;
    }
    return sn;
  }
  public static void Main(string[] args) {
    string n1 = Console.ReadLine();
    Console.WriteLine(Senha(n1));
  }
}
