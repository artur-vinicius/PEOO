using System; 

public class Program {

  public static void Main(string[] args) {
    string[] n = Console.ReadLine().Split(' ');
    int a = int.Parse(n[0]);
    int b = int.Parse(n[1]);
    if (a>b){
      if (a%b == 0) Console.WriteLine("Sao Multiplos");
      else Console.WriteLine("Nao sao Multiplos");}
    else if (a<b){
      if (b%a == 0) Console.WriteLine("Sao Multiplos");
      else Console.WriteLine("Nao sao Multiplos");}
    else if (a==b) Console.WriteLine("Sao Multiplos");
  }
}