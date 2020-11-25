using System.Collections.Generic;
using System;

class Mostruario{
  //TAD
  private Vendedor Representante;
          //estrutura<tipo>nome_variavel; 
  public List<Veiculo> carros;


  public Mostruario(Vendedor v){
    Representante = v;
    carros = new List<Veiculo>();

  }

  public void setRepresentante(Vendedor v){
    Representante = v;
  }


  public void CalculaValor(){
    double soma = 0;
    for(int i = 0; i < carros.Count; i++){
      soma += carros[i].getValor();
    }
    Console.WriteLine("Soma >> {0}", soma);
  }
  // pronto voce quer que retorne ? ou fala a soma ?so chamar agora 
}
