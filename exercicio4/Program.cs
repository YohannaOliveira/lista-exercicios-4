using System;
/*4 – Faça um algoritmo que receba a idade e o sexo de 12 pessoas, calcule e mostre:
• A idade média do grupo;
• A idade média das mulheres;
• A idade média dos homens.*/
class Program {
  public static void Main (string[] args) {
    int totalIdade=0, mediaIdade, quantFem=0, quantMasc=0, idadeFem=0, idadeMasc=0, mediaFem, mediaMasc;
    int[] idade = new int[12];
    char[] sexo = new char[12];
    
    for(int i=0; i<12; i++){
      Console.Write("Digite a {0}- idade: ", i+1);
      idade[i]=int.Parse(Console.ReadLine());
      do{
        Console.Write("Digite o {0}- sexo (F ou M): ", i+1);
        sexo[i]=char.Parse(Console.ReadLine().ToUpper());
        if(sexo[i]!='F' && sexo[i]!='M'){
          Console.WriteLine("Opção inválida.");
        }
      }while(sexo[i]!='F' && sexo[i]!='M');

      Console.WriteLine("-----------------------------");
      totalIdade=totalIdade+idade[i];

      if(sexo[i]=='F'){
        quantFem++;
        idadeFem=idadeFem+idade[i];
      }
      else if(sexo[i]=='M'){
          quantMasc++;
          idadeMasc=idadeMasc+idade[i];
        }
    }

    mediaIdade=totalIdade/12;
    mediaFem=idadeFem/quantFem;
    mediaMasc=idadeMasc/quantMasc;

    Console.WriteLine("Média de idade: {0} anos\n",mediaIdade);
    Console.WriteLine("Quantidade de pessoas do sexo feminino: {0}\n",quantFem);
    Console.WriteLine("Média de idade do sexo feminino: {0} anos\n",mediaFem);
    Console.WriteLine("Quantidade de pessoas do sexo masculino: {0}\n",quantMasc);
    Console.WriteLine("Média de idade do sexo masculino: {0} anos\n",mediaMasc);
  }
}