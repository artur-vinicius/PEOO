using System; 

public class Program {
  
  public static void Main(string[] args) {
    Disciplina n = new Disciplina();
    Console.WriteLine("Digite o Nome do Aluno:");
    n.SetNome(Console.ReadLine());
    Console.WriteLine("Digite a Nota do 1º Bimestre");
    n.SetNota1(int.Parse(Console.ReadLine()));
    Console.WriteLine("Digite a Nota do 2º Bimestre");
    n.SetNota2(int.Parse(Console.ReadLine()));
    Console.WriteLine("Digite a Nota do 3º Bimestre");
    n.SetNota3(int.Parse(Console.ReadLine()));
    Console.WriteLine("Digite a Nota do 4º Bimestre");
    n.SetNota4(int.Parse(Console.ReadLine()));
    
    int mp = n.CalcMediaParcial();
    Console.WriteLine($"Média Parcial: {mp}");
    if (mp<60) {
      Console.WriteLine("Aluno não Aprovado por Média Parcial. Digite a Nota da Prova Final:");
      n.SetNotaFinal(int.Parse(Console.ReadLine()));
      Console.WriteLine($"Média Final: {n.CalcMediaFinal()}");
    }
  }

  class Disciplina {
    private string nome;
    private int nota1;
    private int nota2;
    private int nota3;
    private int nota4;
    private int notaFinal;
    
    public void SetNome(string s) { nome = s; }
    public void SetNota1(int n) { nota1 = n; }
    public void SetNota2(int n) { nota2 = n; }
    public void SetNota3(int n) { nota3 = n; }
    public void SetNota4(int n) { nota4 = n; }
    public void SetNotaFinal(int n) { notaFinal = n; }
    
    public string GetNome() { return nome; }
    public int GetNota1() { return nota1; }
    public int GetNota2() { return nota2; }
    public int GetNota3() { return nota3; }
    public int GetNota4() { return nota4; }
    public int GetnotaFinal() { return notaFinal; }
    
    public int CalcMediaParcial() { return (nota1*2 + nota2*2 + nota3*3 + nota4*3) / (2+2+3+3); }
    public double CalcMediaFinal() { return (CalcMediaParcial() + notaFinal) / 2; }
  }
}