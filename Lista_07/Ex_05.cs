using System; 

class MainClass {
  public static string FormatarNome(string nome) {
    string[] a = nome.ToLower().Split(' ');
    string l = ""; 
    foreach (string s in a) {
      if (s != "") l = l + s.Substring(0, 1).ToUpper() + s.Substring(1) + " ";
    }
    return l;
  }
  
  
  public static void Main(string[] args) {
    Console.WriteLine("Digite Seu Nome:");
    string n = Console.ReadLine();
    string frmt = FormatarNome(n);
    Console.WriteLine(frmt);
  }
}
