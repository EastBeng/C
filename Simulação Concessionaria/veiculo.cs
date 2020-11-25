using System;

class Veiculo{
  string marca;
  int ano;
  double valor;
  int km;

  public double getValor(){
    return valor;
  }

  //construtor
  public Veiculo(string m, int a, double v, int k){
    marca = m;
    ano = a;
    valor = v;
    km = k;

  }

  public void Relatorio(){
    
    Console.WriteLine("Marca do Veículo: {0}", marca);
		Console.WriteLine("Ano do Veículo: {0}", ano);
		Console.WriteLine("Valor do Veículo: {0}", valor);
		Console.WriteLine("Quilometragem: {0}", km);
  }


  public double AtualizaValor(int a, int a_a, double v){
    ano = a;  
    valor = v;

    return v-(a_a - a) * 2.05;
  }




}
