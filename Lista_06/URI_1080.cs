using System; 

public class Program {

  public static void Main(string[] args) {
    int maior = 0;
    int pos = 0;
    for (int i = 1; i<101; i++) {
      var num = int.Parse(Console.ReadLine());
      if (num >= maior) {
        maior = num;
        pos = i;
      }
    }
      
    Console.WriteLine(maior);
    Console.WriteLine(pos);
  } 
}
