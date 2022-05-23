using System; 

public class Program {

  public static void Main(string[] args) {
    Console.WriteLine("Digite Quatro Valores Inteiros:");
    int n1 = int.Parse(Console.ReadLine());
    int n2 = int.Parse(Console.ReadLine());
    int n3 = int.Parse(Console.ReadLine());
    int n4 = int.Parse(Console.ReadLine());
    int med = (n1+n2+n3+n4)/4;
    Console.WriteLine($"Média = {med}");
    if (n1<6) Console.WriteLine($"A Nota do Primeiro Bimestre({n1}.0) Está Abaixo da Média");
    else Console.WriteLine($"A Nota do Primeiro Bimestre({n1}.0) Está na Média");
    if (n2<6) Console.WriteLine($"A Nota do Segundo Bimestre({n2}.0) Está Abaixo da Média");
    else Console.WriteLine($"A Nota do Segundo Bimestre({n2}.0) Está na Média");
    if (n3<6) Console.WriteLine($"A Nota do Terceiro Bimestre({n3}.0) Está Abaixo da Média");
    else Console.WriteLine($"A Nota do Terceiro Bimestre({n3}.0) Está na Média");
    if (n4<6) Console.WriteLine($"A Nota do Quarto Bimestre({n4}.0) Está Abaixo da Média");
    else Console.WriteLine($"A Nota do Quarto Bimestre({n4}.0) Está na Média");
  }
}