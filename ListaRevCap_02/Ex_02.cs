using System; 

public class Program {
  
  public static void Main(string[] args) {
    Console.WriteLine("Digite sua data de nascimento:");
    string[] data = Console.ReadLine().Split('/');
    int ano = int.Parse(data[2]);
    int idd = 2022 - ano;
    if (idd<=19) Console.WriteLine("Você está na faixa etária: Jovem");
    else if (idd<=59) Console.WriteLine("Você está na faixa etária: Adulto");
    else Console.WriteLine("Você está na faixa etária: Idoso");
  }
}