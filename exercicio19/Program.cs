/*19 – Fazer um algoritmo que leia dois números inteiros. O programa deve somar os valores ASCII desses dois números e mostrar como resultado o caractere correspondente ao resultado da soma.*/
class Program {
  public static void Main (string[] args) {
    int soma=0;
    int[] num = new int[2];

    for(int i=0; i<2; i++){
      Console.Write("Informe o {0}- número: ", i+1);
      num[i]=int.Parse(Console.ReadLine());
      soma=soma+num[i];
    }

    Console.WriteLine("");
    Console.WriteLine("Soma - ASCII: {0}",soma);
    Console.WriteLine("Caractere: {0}", (char)soma);
  }
}