using System; 

public class Program {
  public static string Vogais(string s) {
    int sum = 0;
    foreach (char i in s) {
      if (i=='a') sum += 1;
      if (i=='e') sum += 1;
      if (i=='i') sum += 1;
      if (i=='o') sum += 1;
      if (i=='u') sum += 1;
    } 
    return sum.ToString();
    }
  public static void Main(string[] args) {
    string n1 = Console.ReadLine();
    Console.WriteLine(Vogais(n1));
  }
}
