using System; 

public class Program {
  
  public static void Main(string[] args) {
    Console.WriteLine("Digite o nome e a data de nascimento da 1ª pessoa:");
    string nom1 = Console.ReadLine();
    string[] data1 = Console.ReadLine().Split('/');
    int dia1 = int.Parse(data1[0]);
    int mes1 = int.Parse(data1[1]);
    int ano1 = int.Parse(data1[2]);
    Console.WriteLine("Digite o nome e a data de nascimento da 2ª pessoa:");
    string nom2 = Console.ReadLine();
    string[] data2 = Console.ReadLine().Split('/');
    int dia2 = int.Parse(data2[0]);
    int mes2 = int.Parse(data2[1]);
    int ano2 = int.Parse(data2[2]);
    int idd1 = 2022-ano1;
    int idd2 = 2022-ano2;
    if (idd1>idd2) Console.WriteLine($"{nom2} é o(a) mais novo(a).");
    else if (idd2>idd1) Console.WriteLine($"{nom1} é o(a) mais novo(a).");
    else {
      if (mes1>mes2) Console.WriteLine($"{nom1} é o(a) mais novo(a).");
      else if (mes2>mes1) Console.WriteLine($"{nom2} é o(a) mais novo(a).");
      else {
        if (dia1>dia2) Console.WriteLine($"{nom1} é o(a) mais novo(a).");
        else if (dia2>dia1) Console.WriteLine($"{nom2} é o(a) mais novo(a).");
        else Console.WriteLine($"Ambos {nom1} e {nom2} têm a mesma idade.");
      }
    }
  }
}