using System;
/*24 – Fazer um algoritmo que leia a capacidade de um elevador e o peso de 5 pessoas. Informar se o
elevador está liberado para subir ou se excedeu a carga máxima.*/
class Program {
  public static void Main (string[] args) {
    int capac, total=0;
    int[] peso = new int[5];

    Console.Write("Informe a capacidade de peso (kg) do elevador: ");
    capac=int.Parse(Console.ReadLine());
    Console.WriteLine("");

    for(int i=0; i<5; i++){
      Console.Write("Informe o peso (kg) da {0}- pessoa: ", i+1);
      peso[i]=int.Parse(Console.ReadLine());
      total=total+peso[i];
    }

    Console.WriteLine("\nPeso total: {0}",total);

    if(total>capac){
      Console.WriteLine("");
      Console.WriteLine("Carga máxima excedida!");
    }else{
      Console.WriteLine("");
      Console.WriteLine("Elevador liberado.");
    }
  }
}