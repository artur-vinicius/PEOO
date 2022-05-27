using System; 

public class Program {

  public static void Main(string[] args) {
    Console.WriteLine("Informe o Número do Mês:");
    int n = int.Parse(Console.ReadLine());
    string m = "a";
    string tri = "a";
    switch (n) {
      case 1: {
        m = "Janeiro";
        tri = "Primeiro"; break; }
      case 2: {
        m = "Fevereiro";
        tri = "Primeiro"; break; }
      case 3: {
        m = "Março";
        tri = "Primeiro"; break; }
      case 4: {
        m = "Abril";
        tri = "Segundo"; break; }
      case 5: {
        m = "Maio";
        tri = "Segundo"; break; }
      case 6: {
        m = "Junho";
        tri = "Segundo"; break; }
      case 7: {
        m = "Julho";
        tri = "Terceiro"; break; }
      case 8: {
        m = "Agosto";
        tri = "Terceiro"; break; }
      case 9: {
        m = "Setembro";
        tri = "Terceiro"; break; }
      case 10: {
        m = "Outubro";
        tri = "Quarto"; break; }
      case 11: {
        m = "Novembro";
        tri = "Quarto"; break; }
      case 12:{
        m = "Dezembro";
        tri = "Quarto"; break; }
    }
    Console.WriteLine($"O Mês de {m} é do {tri} Trimestre do Ano");
  }
}