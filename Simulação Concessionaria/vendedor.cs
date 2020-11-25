using System;

class Vendedor{
  string nome;
  double salario;
  double comissao;

  //construtor
  public Vendedor(string n, double s, double c){
    nome = n;
    salario = s;
    comissao = c;
  }

  public void setNome(string n){
    nome = n;
  }
  public string getNome(){
    return nome;
  }
  


  public double ReceberSalario(int t_v, double s, double c){
    salario = s;
    comissao = c;
    
    return salario + comissao * t_v;
  }

}
