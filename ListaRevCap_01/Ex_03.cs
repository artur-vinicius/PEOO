using System; 

public class Program {
  
  public static void Main(string[] args) {
    Console.WriteLine("Digite dois números inteiros:");
    int n1 = int.Parse(Console.ReadLine());
    int n2 = int.Parse(Console.ReadLine());
    Console.WriteLine($"{n1} / {n2} = {n1/n2}");
    Console.WriteLine($"{n1} % {n2} = {n1%n2}");
  }
}