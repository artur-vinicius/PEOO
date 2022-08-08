using System; 

public class Circulo {
  public double raio;

  public double area() {
    return 3.14 * raio*raio;
  }
  public double circunferencia() {
    return 3.14 * raio * 2;
  }
}

public class Program {
  public static void Main(string[] args) {
    Circulo c = new Circulo();
    c.raio = 5;
    Console.WriteLine(c.area());
    Console.WriteLine(c.circunferencia());
  }
}