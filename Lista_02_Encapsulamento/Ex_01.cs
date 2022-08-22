using System; 

public class Program {
  
  public static void Main(string[] args) {
    Circulo r = new Circulo();
    Console.WriteLine("Digite o Raio:");
    r.SetRaio(double.Parse(Console.ReadLine()));
    Console.WriteLine($"Área: {r.CalcArea()}");
    Console.WriteLine($"Circunferência: {r.CalcCircunferencia()}");
  }

  class Circulo {
    private double raio;
    public void SetRaio(double v) { if (v>0) raio = v; }  
    public double GetRaio() { return raio; }  
    public double CalcArea() { return 3.14 * Math.Pow(raio, 2); }  
    public double CalcCircunferencia() { return 3.14 * raio * 2; }
  }
}