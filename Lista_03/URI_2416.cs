using System; 

public class Program {

  public static void Main(string[] args) {
    string[] n = Console.ReadLine().Split(' ');
    int pista = int.Parse(n[0]);
    int treino = int.Parse(n[1]);
    if (pista > treino) 
      { int pos = pista % treino;
      Console.WriteLine(pos); }
    else 
      { int pos = treino % pista;
      Console.WriteLine(pos); }
  }
}
