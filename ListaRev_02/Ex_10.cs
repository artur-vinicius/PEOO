using System; 

public class Program {

  public static void Main(string[] args) {
    Console.WriteLine("Digite uma data no formato dd/mm/aaaa:");
    string[] data = Console.ReadLine().Split('/');
    int dia = int.Parse(data[0]);
    int mes = int.Parse(data[1]);
    int ano = int.Parse(data[2]);
    if (dia > 31 || dia <= 0) Console.WriteLine("Data Inválida");
    else if (mes > 12 || mes <= 0) Console.WriteLine("Data Inválida");
    else if (ano > 2100 || ano < 1900) Console.WriteLine("Data Inválida");
    else Console.WriteLine("Data Válida");
  }
}
