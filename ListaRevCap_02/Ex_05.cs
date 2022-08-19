using System; 

public class Program {
  
  public static void Main(string[] args) {
    Console.WriteLine($"Digite o nome e a data de nascimento da 1ª pessoa:");
    string nome = Console.ReadLine();
    string[] data = Console.ReadLine().Split('/');
    int ano = int.Parse(data[2]);
    int idd = 2022-ano;
    int menor = idd;
    string name = nome;
    int i = 3;
    Console.WriteLine($"Digite o nome e a data de nascimento da 2ª pessoa:");
    nome = Console.ReadLine();
    while (nome != "fim") {
      data = Console.ReadLine().Split('/');
      ano = int.Parse(data[2]);
      idd = 2022-ano;
      if (idd<menor) {
        menor = idd;
        name = nome;
      }
      Console.WriteLine($"Digite o nome e a data de nascimento da {i}ª pessoa:");
      nome = Console.ReadLine();
      i++;
    }
    Console.WriteLine($"{name} é o(a) mais novo(a).");
  }
}