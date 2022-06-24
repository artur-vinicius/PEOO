using System; 

class MainClass {
  public static string FormatarNome(string nome) {
    string[] a = nome.ToLower().Split(' ');
    string l = ""; 
    foreach (string s in a) {
      switch (s) {
        case "da": l = l + s + " ";break;
        case "de": l = l + s + " ";break;
        case "do": l = l + s + " ";break;
        case "das": l = l + s + " ";break;
        case "dos": l = l + s + " ";break;
        case "e": l = l + s + " ";break;
        default: if (s != "") l = l + s.Substring(0, 1).ToUpper() + s.Substring(1) + " ";break;
      }
      
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
