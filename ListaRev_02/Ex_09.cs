using System; 

public class Program {

  public static void Main(string[] args) {
    Console.WriteLine("Digite o Horário no Formato hh:mm:");
    string[] hora = Console.ReadLine().Split(':');
    int h = int.Parse(hora[0]);
    int m = int.Parse(hora[1]);
    int ang = ((11*m) - (60*h)) / 2;
    Console.WriteLine($"Menor Ângulo Entre os Ponteiros = {ang} Graus");
  }
}