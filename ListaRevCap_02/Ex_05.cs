using System; 

public class Program {
  
  public static void Main(string[] args) {
    Console.WriteLine($"Digite o nome e a data de nascimento da 1ª pessoa:");
    string nome = Console.ReadLine();
    string data = Console.ReadLine();
    int i = 2;
    while (nome != "fim") {
      Console.WriteLine($"Digite o nome e a data de nascimento da {i}ª pessoa:");
      nome = Console.ReadLine();
      data = Console.ReadLine();
      i++;
    }
    
  }
}