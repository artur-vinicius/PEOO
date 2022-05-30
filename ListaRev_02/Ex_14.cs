using System; 

public class Program {

  public static void Main(string[] args) {
    Console.WriteLine("Digite Três Valores:");
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int c = int.Parse(Console.ReadLine());
    int cond1 = a+b;
    int cond2 = a+c;
    int cond3 = c+b;
    if (cond1>c && cond2>b && cond3>a){
      if (a==b && a==c) Console.WriteLine("Esses Valores Formam um Triângulo Equilátero");
      else if (a==b || a==c ||b==c) Console.WriteLine("Esses Valores Formam um Triângulo Isósceles");
      else if (a!=b && a!=c && b!=c) Console.WriteLine("Esses Valores Formam um Triângulo Escaleno");
    }
    else Console.WriteLine("Esses Valores não Formam um Triângulo");
  }
}
