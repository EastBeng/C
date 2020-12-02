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

class Datas{
  private int dia;
  public void SetDia(int d){
    dia = d;
  }public int GetDia(){
    return dia;
  }

  private int mes;
  public void SetMes(int m){
    mes = m;
  }public int GetMes(){
    return mes;
  }

  private int ano;
  public void SetAno(int a){
    ano = a;
  }public int GetAno(){
    return ano;
  }
  
  //Construtor de verificação
  public Datas(int d , int m , int a){
    if(d > 0 && d <= 31){
      dia = d;
    }else{
      throw new ArgumentException("O campo de dia ou de mês ou de ano está com valores invalidos.");
    }

    if(m > 0 && m <= 12){
      mes = m;
    }else{
      throw new ArgumentException("O campo de dia ou de mês ou de ano está com valores invalidos.");
    }

    if(a > 0 && a <= 2020){
      ano = a;
    }else{
      throw new ArgumentException("O campo de dia ou de mês ou de ano está com valores invalidos.");
    }
  }

  public Datas(){
    DateTime dataEntrada = DateTime.Now;

    dataEntrada.ToString();
    dia = int.Parse(dataEntrada.ToString("dd"));
    mes = int.Parse(dataEntrada.ToString("MM"));
    ano = int.Parse(dataEntrada.ToString("yyyy"));

  }

  public static void ToString(int n, int m , int a){
    Console.WriteLine("{0}/{1}/{2}",n , m ,a);
  }

  public static void Avancar(int d, int m, int a){
    if(d == 31 && m != 12){
      m += 1;
      d = 1;
    }else if(m == 12 && d == 31){
      a += 1;
      m = 1;
      d = 1;
    }else if(d < 31 && m <= 12){
        d += 1;
    }

    // if(m == 12 && d == 31){
    //   a += 1;
    //   m = 1;
    //   d = 1;
    // }else if(d < 31){
    //   m = m;
    // }

    /*
    dia = d;
    mes = m;
    ano = a;
    */

    Console.WriteLine("{0}/{1}/{2}",d , m ,a);
  }

}
