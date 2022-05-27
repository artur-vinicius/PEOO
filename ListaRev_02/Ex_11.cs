using System; 

public class Program {

  public static void Main(string[] args) {
    Console.WriteLine("Digite uma data no formato dd/mm/aaaa:");
    string[] data = Console.ReadLine().Split('/');
    int dia = int.Parse(data[0]);
    string mes = data[1];
    int ano = int.Parse(data[2]);
    switch (mes) {
      case "01": mes = "Janeiro"; break;
      case "02": mes = "Fevereiro"; break;
      case "03": mes = "Março"; break;
      case "04": mes = "Abril"; break;
      case "05": mes = "Maio"; break;
      case "06": mes = "Junho"; break;
      case "07": mes = "Julho"; break;
      case "08": mes = "Agosto"; break; 
      case "09": mes = "Setembro"; break;
      case "10": mes = "Outubro"; break; 
      case "11": mes = "Novembro"; break; 
      case "12": mes = "Dezembro"; break; 
    }
    Console.WriteLine($"A data é {dia} de {mes} de {ano}");
  }
}