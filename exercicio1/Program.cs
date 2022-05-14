
class Program {
  public static void Main (string[] args) {
    int totalIdade=0, mediaIdade, maior=0;
    
    int[] idade = new int[7];
    int[] peso = new int[7];

    for(int i=0; i<7; i++){
      Console.Write("Digite a {0}- idade: ", i+1);
      idade[i]=int.Parse(Console.ReadLine());
      Console.Write("Digite o {0}- peso: ", i+1);
      peso[i]=int.Parse(Console.ReadLine());
      Console.WriteLine("-----------------------------");
      totalIdade=totalIdade+idade[i];

      if(peso[i]>90){
        maior++;
      }
    }

    mediaIdade=totalIdade/7;
    Console.WriteLine("Média de idade: {0}",mediaIdade);
    Console.WriteLine("Número de pessoas com mais de 90 kg: {0}",maior);
  }
}