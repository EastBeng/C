using System;
using System.Collections.Generic;

class Pessoa{

  private string nome;
  public void SetNome(string n){
    nome = n;
  }
  public string GetNome(){
    return nome;
  }

  private string numero;
  public void SetNumero(string num){
    numero = num;
  }
  public string GetNumero(){
    return numero;
  }


  private string observacao;
  public void SetObs(string o){
    observacao = o;
  }
  public string GetObs(){
    return observacao;
  }

  public Pessoa(string n, string num, string o){
    nome = n;
    numero = num;
    observacao = o;
  }

  public Pessoa(){
    nome = "Padrão";
    numero = "9999999";
    observacao = "Padrão";
  }

  public Pessoa(string n, string num){
    nome = n;
    numero = num;
  }


}
