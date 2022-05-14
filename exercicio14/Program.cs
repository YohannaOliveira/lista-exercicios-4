/*14 – Fazer um algoritmo para ler duas notas, os pesos de cada nota e mostrar a média ponderada.
(nota 1 *peso da nota 1) +(nota 2 *peso da nota 2)/ Cálculo da Média Ponderada =soma dos pesos*/
class Program {
  public static void Main (string[] args) {
    double somaPeso=0, multi, soma=0, mediaPond;
    double[] nota = new double[2];
    double[] peso = new double[2];

    for(int i=0; i<2; i++){
      Console.Write("Informe o peso da {0}- nota: ", i+1);
      peso[i]=int.Parse(Console.ReadLine());
      Console.Write("Informe a {0}- nota: ", i+1);
      nota[i]=int.Parse(Console.ReadLine());
      Console.WriteLine("----------------------------------------");
      somaPeso=somaPeso+peso[i];
      multi=(nota[i]*peso[i]);
      soma=soma+multi;
    }
    
    mediaPond=soma/somaPeso;
    Console.WriteLine("Média ponderada: {0}",mediaPond);
  }
}