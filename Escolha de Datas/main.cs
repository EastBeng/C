/*
Crie uma classe para representar datas.
1. Represente uma data usando três atributos: o dia, o mês, e o ano.
2. Sua classe deve ter um construtor que inicializa os três atributos e verifica a validade dos valores
fornecidos.
3. Forneça um construtor sem parâmetros que inicializa a data com a data atual fornecida pelo sistema
operacional.
4. Forneça um método set um get para cada atributo.
5. Forneça o método toString para retornar uma representação da ata como string. Considere que a
data deve ser formatada mostrando o dia, o mês e o ano separados por barra (/).
6. Forneça uma operação para avançar uma data para o dia seguinte.
7. Escreva um aplicativo de teste que adicione em lista várias datas de acordo com o usuário (loop).
*/

using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {
    Datas x = new Datas();
    List<Datas> lista = new List<Datas>();
    bool cond = false;

    while(!cond){
      try{
      Console.WriteLine("\nDeseja utilizar a hora atual do sistema? (s/n) >> ");
      string aux1 = Console.ReadLine();
      if(aux1 == "s" || aux1 == "S"){
        x = new Datas();
        lista.Add(x);
      }else{ 
        Console.WriteLine("\nINFORME OS CAMPOS ABAIXO:\n");
        Console.Write("Dia >> ");
        int d = int.Parse(Console.ReadLine());
        Console.Write("Mes >> ");
        int m = int.Parse(Console.ReadLine());
        Console.Write("Ano >> " );
        int a = int.Parse(Console.ReadLine());

        //x = new Datas(d,m,a);
        Console.Write("Gostaria de observar um dia a frente da data escolhida? (s/n) >> ");
        string aux2 = Console.ReadLine();
        if(aux2 == "s" || aux2 == "S"){
          Console.Write("Visualizando uma dia adicionado.\n");
          Datas.Avancar(d,m,a);
          x = new Datas(d,m,a);
          x.ToString();
          lista.Add(x);
        }else{
          x = new Datas(d,m,a);
          x.ToString();
          lista.Add(x);
        }
      }
    
  

      Console.Write("Deseja Continuar? (s/n) >> ");
      string aux = Console.ReadLine();
      if(aux == "s" || aux == "S"){
        cond = false;
      }else{
        cond = true;
      }
      

    }catch(ArgumentException){

      Console.WriteLine("\nUm ou mais Campos estão com valores invalidos(Podem estar vazios ou com datas invalidas).\n");
      Console.ReadLine();

    }catch(FormatException){

      Console.WriteLine("\nOs campos apenas podem ser preenchidos por números.\n");
      Console.ReadLine();

    }finally{

      if(cond == true){
        
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\n________Datas Informadas________\n");

        for(int i = 0; i < lista.Count;i++){
          Console.ForegroundColor = ConsoleColor.Blue;
          Console.Write(i+1 + "ª - ");
          Datas.ToString(lista[i].GetDia(), lista[i].GetMes(), lista[i].GetAno());

          }

        }
      
      }

    }
  }
}
