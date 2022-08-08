using System; 

public class Media {
  public string disciplina;
  public int nb1;
  public int nb2;
  public int nb3;
  public int nb4;
  public int npf;
  

  public double MediaP() {
    return (nb1*2 + nb2*2 + nb3*3 + nb4*3) / (2+2+3+3);
  }
  public double MediaF() {
    return (MediaP() + npf) / 2;
  }
}

public class Program {
  public static void Main(string[] args) {
    Media m = new Media();
    m.disciplina = "PEOO";
    m.nb1 = 60;
    m.nb2 = 60;
    m.nb3 = 60;
    m.nb4 = 60;
    int parcial = m.MediaP();
    Console.WriteLine($"Nota Parcial = {parcial}");
    if (parcial < 60) {
      m.npf = 60;
      Console.WriteLine($"Nota Final = {m.MediaF()}");
    }
  }
}