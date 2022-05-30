using System; 

public class Program {

  public static void Main(string[] args) {
    Console.WriteLine("Digite Dez Valores Inteiros:");
    string[] valores = Console.ReadLine().Split(' ');
    int a = int.Parse(valores[0]);
    int b = int.Parse(valores[1]);
    int c = int.Parse(valores[2]);
    int d = int.Parse(valores[3]);
    int e = int.Parse(valores[4]);
    int f = int.Parse(valores[5]);
    int g = int.Parse(valores[6]);
    int h = int.Parse(valores[7]);
    int i = int.Parse(valores[8]);
    int j = int.Parse(valores[9]);
    int menor = a;
    int maior = j;
    if (a!=b || a!=c || a!=d) {
      if (b < menor) menor = b;
      if (c < menor) menor = c;
      if (d < menor) menor = d;
      if (e < menor) menor = e;
      if (f < menor) menor = f;
      if (g < menor) menor = g;
      if (h < menor) menor = h;
      if (i < menor) menor = i;
      if (j < menor) menor = j;
      if (a > maior) maior = a;
      if (b > maior) maior = b;
      if (c > maior) maior = c;
      if (d > maior) maior = d;
      if (e > maior) maior = e;
      if (f > maior) maior = f;
      if (g > maior) maior = g;
      if (h > maior) maior = h;
      if (i > maior) maior = i;
      Console.WriteLine($"O Maior Valor é {maior} e o Menor é {menor}");
    }
    else Console.WriteLine("[Error] valores iguais");
  }
}
