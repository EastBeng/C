using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {
    Vendedor carlos = new Vendedor("carlos", 2000, 1.34);
    Veiculo uno = new Veiculo("Fiat", 2020, 50000, 0);

    Mostruario sessaoA = new Mostruario(carlos);

    
    sessaoA.carros.Add(uno);
    sessaoA.carros.Add(uno);
    sessaoA.carros.Add(uno);

    sessaoA.CalculaValor();

    /* EXPLICACAO LISTA */
    List<int> meuNumeros = new List<int>{10,20,30,40};
    meuNumeros.Add(100);
    Console.WriteLine(meuNumeros.Count);

    int tot = 0;
    for(int i=0;i<meuNumeros.Count;i++){
      tot += meuNumeros[i];
     // Console.WriteLine("Elemento {0} >> {1}", i, meuNumeros[i]);
    }
     Console.WriteLine("Soma >> {0}", tot);

  }
}
