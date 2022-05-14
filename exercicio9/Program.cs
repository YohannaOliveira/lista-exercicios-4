using System;
/*9 – Faça um algoritmo que leia o nome e as idades de duas pessoas e mostre a soma das idades.*/
class Program {
  public static void Main (string[] args) {
    int totalIdade=0;
    string[] nome = new string[2];
    int[] idade = new int[2];
    
    for(int i=0; i<2; i++){
      Console.Write("Informe o nome da {0}- pessoa: ", i+1);
      nome[i]=(Console.ReadLine());
      Console.Write("Informe a idade da {0}- pessoa: ", i+1);
      idade[i]=int.Parse(Console.ReadLine());
      Console.WriteLine("----------------------------------------");
      totalIdade=totalIdade+idade[i];
    }
    
    Console.WriteLine("Soma das idades: {0} anos",totalIdade);
  }
}