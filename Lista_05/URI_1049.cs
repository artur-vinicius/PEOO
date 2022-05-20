using System; 

public class Program {

  public static void Main(string[] args) {
    string a = Console.ReadLine();
    string b = Console.ReadLine();
    string c = Console.ReadLine();
    if (a == "vertebrado") {
      if (b == "ave"){
        if (c == "carnivoro") Console.WriteLine("aguia");
        else Console.WriteLine("pomba");
      }
      else {
        if (c == "onivoro")Console.WriteLine("homem");
        else Console.WriteLine("vaca");
      }
    }
    else {
      if (b == "inseto") {
        if (c == "hematofago") Console.WriteLine("pulga");
        else Console.WriteLine("lagarta");
      }
      else {
        if (c == "hematofago") Console.WriteLine("sanguessuga");
        else Console.WriteLine("minhoca");
      }
    }
  }
}