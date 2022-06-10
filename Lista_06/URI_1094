using System; 

public class Program {

  public static void Main(string[] args) {
    int n = int.Parse(Console.ReadLine());
    int coelho = 0;
    int rato = 0;
    int sapo = 0;
    int soma = 0;
    
    for (int i = 1; i <= n; i++) {
      string[] x = Console.ReadLine().Split(' ');
      int num = int.Parse(x[0]);
      char chr = char.Parse(x[1]);
      soma += num;
      if (chr == 'C') coelho += num;
      if (chr == 'R') rato += num;
      if (chr == 'S') sapo += num;
    }
    double cper = ((double)coelho*100)/soma;
    double rper = ((double)rato*100)/soma;
    double sper = ((double)sapo*100)/soma;
  
    Console.WriteLine($"Total: {soma} cobaias");
    Console.WriteLine($"Total de coelhos: {coelho}");
    Console.WriteLine($"Total de ratos: {rato}");
    Console.WriteLine($"Total de sapos: {sapo}");
    Console.WriteLine($"Percentual de coelhos:{cper: 0.00} %");
    Console.WriteLine($"Percentual de ratos:{rper: 0.00} %");
    Console.WriteLine($"Percentual de sapos:{sper: 0.00} %");
  } 
}
