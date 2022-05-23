using System; 

public class Program {

  public static void Main(string[] args) {
    Console.WriteLine("Digite o Primeiro Horário no Formato hh:mm :");
    string[] n1 = Console.ReadLine().Split(':');
    Console.WriteLine("Digite o Segundo Horário no Formato hh:mm:");
    string[] n2 = Console.ReadLine().Split(':');
    var h1 = int.Parse(n1[0]);
    var m1 = int.Parse(n1[1]);
    var h2 = int.Parse(n2[0]);
    var m2 = int.Parse(n2[1]);
    var t1 = new TimeSpan(h1, m1, 0);
    var t2 = new TimeSpan(h2, m2, 0);
    var tot = t1 + t2;
    Console.WriteLine(tot);
  }
}