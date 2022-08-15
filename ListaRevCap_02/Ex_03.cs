using System; 

public class Program {
  
  public static void Main(string[] args) {
    Console.WriteLine("Digite sua data de nascimento:");
    string[] data = Console.ReadLine().Split('/');
    int dia = int.Parse(data[0]);
    int mes = int.Parse(data[1]);
    int ano = int.Parse(data[2]);
    switch (mes) {
      case 1: Console.WriteLine("Você nasceu em Janeiro");break;
      case 2: Console.WriteLine("Você nasceu em Fevereiro");break;
      case 3: Console.WriteLine("Você nasceu em Março");break;
      case 4: Console.WriteLine("Você nasceu em Abril");break;
      case 5: Console.WriteLine("Você nasceu em Maio");break;
      case 6: Console.WriteLine("Você nasceu em Junho");break;
      case 7: Console.WriteLine("Você nasceu em Julho");break;
      case 8: Console.WriteLine("Você nasceu em Agosto");break;
      case 9: Console.WriteLine("Você nasceu em Setembro");break;
      case 10: Console.WriteLine("Você nasceu em Outubro");break;
      case 11: Console.WriteLine("Você nasceu em Novembro");break;
      case 12: Console.WriteLine("Você nasceu em Dezembro");break;
      default: Console.WriteLine($"O mês {mes} não existe.");break;
    }
  }
}