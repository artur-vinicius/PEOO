using System; 

public class Program {

  public static void Main(string[] args) {
    int n = int.Parse(Console.ReadLine());
    
    for (int i = 1; i<=n; i++){
      int n1 = int.Parse(Console.ReadLine());
      int mult = 0;
      if (n1!=1 && n1!=2 && n1!=3 && n1!=5 && n1!=7) {
        
        for (int c=2; c<=n1-1; c++){
          
          if (n1%c==0) mult+=1;
        }
        if (mult>=1) Console.WriteLine($"{n1} nao eh primo");
        else if (mult<=0) Console.WriteLine($"{n1} eh primo");
      }
      else Console.WriteLine($"{n1} eh primo");
    }
    
  }
}