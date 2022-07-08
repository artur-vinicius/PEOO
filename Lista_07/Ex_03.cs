class MainClass {
  public static string Iniciais(string nome) {
    string[] a = nome.Split(' ');
    string l = "";
    foreach (string s in a) {
      l = l + s[0] + " ";
    }
    return l;
  }
  
  public static void Main(string[] args) {
    Console.WriteLine("Digite Seu Nome:");
    string n = Console.ReadLine();
    Console.WriteLine(Iniciais(n));
  }
}