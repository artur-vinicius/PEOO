using System; 

public class Program {
  
  public static void Main(string[] args) {
    Console.WriteLine("Digite sua data de nascimento:");
    string[] data = Console.ReadLine().Split('/');
    int dia = int.Parse(data[0]);
    int mes = int.Parse(data[1]);
    int ano = int.Parse(data[2]);
    Console.WriteLine($"no final de 2022, você terá {2022-ano} anos.");
  }
}