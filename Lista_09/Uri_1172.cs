using System; 

public class Program {

  public static void Main(string[] args) {
    int[] num = new int[10];
    for (int i=0; i<num.Length; i++) {
      num[i] = int.Parse(Console.ReadLine());
    }

    for (int i=0; i<num.Length;i++) {
      if (num[i] <= 0) {
        num[i] = 1;
      }
      Console.WriteLine($"X[{i}] = {num[i]}");
    }
  }
}
