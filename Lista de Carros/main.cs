using System;

class MainClass {
  public static void Main (string[] args) {
    Carros car = new Carros();

    string condicao = "S";
    string ler;
    double km;
    
    while(condicao == "S"){
      Console.WriteLine("Insira um Carro >> ");
      ler = Console.ReadLine();
      car.carro.Add(ler);

      Console.WriteLine("Insira a km que percorre com 1L de combustivel no Carro {0} >> ",ler);
      km = double.Parse(Console.ReadLine());
      car.consumo.Add(km);

      Console.WriteLine("Deseja colocar mais um carro?(S/N)");
      condicao = Console.ReadLine();
      Console.WriteLine("==========================");
    }
    Console.WriteLine("Total de carros >> {0}", car.carro.Count);

    double menor = car.consumo[0];
    string carro_economico = car.carro[0];
    for (int i = 0; i < car.carro.Count && i < car.consumo.Count; i++){
      Console.WriteLine("Carro {0} >> {1} possui um consumo de {2}", i+1, car.carro[i], car.consumo[i]);

      
      if (car.consumo[i] < menor){
        menor = car.consumo[i];
        carro_economico = car.carro[i];
      }
    }
    Console.WriteLine("Menor Cosumo >> {0} no carro {1}", menor, carro_economico);

    for (int i = 0; i < car.carro.Count && i < car.consumo.Count; i++){
      double valorLitro = ( 1000/car.consumo[i]) * 4.89 ;

      Console.WriteLine("O carro {0} gastará R$ {1}", car.carro[i], valorLitro);

    }

    
  }
}
