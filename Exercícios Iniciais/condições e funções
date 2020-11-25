using System;

/*
1- Criar um programa que leia dois números inteiros, e que solicite ao usuário qual a operação 
deseja realizar entre esses números. Caso o usuário digitar o caractere “*” será realizada uma multiplicação, 
caso seja digitado o caractere “/” será realizada uma divisão, caso seja digitado o caractere “+” 
será realizado uma adição, e caso seja digitado o caractere “–” será realizada uma subtração.
2- O cardápio de uma casa de lanches é dado pela tabela abaixo:
Código Produto Preço Unitário (R$)
---------------------------------
100  Cachorro quente   R$ 1,70
101   Bauru Simples    R$ 2,30
102   Bauru com ovo    R$ 2,60
103   Hamburguer       R$ 2,40
104   Cheeseburguer    R$ 2,50
105   Refrigerante     R$ 1,00
----------------------------------
Escreva um algoritmo que leia o código do item adquirido pelo consumidor e a
quantidade, calculando e mostrando o valor a pagar. Não será necessário exibir o produto
e o valor, somente o valor final
3- Crie um programa que funcione para uma votação eleitoral. Existem três candidatos:
33 - José Couve
25 - Joana Bravo
10 - Roberto Nove
0 - Voto branco
4 - Voto nulo
Deseja-se saber:
- O candidato vencedor;
- O total de votos em branco;
- O total de votos nulos;
*/



class MainClass {

  public static float Sinal(float n1, float n2,char operador){
  switch (operador){
    case '+':
      return n1 + n2;

    case '-':
      return n1 - n2;

    case '*':
      return n1 * n2;

    case '/':
      return n1 / n2;
    
    default:
      return 0;
  }
}

public static double ValorFinal(int codigo, int quantidade){
  double valor = 0; 
  if (codigo == 100){
    valor = 1.70;
    return valor * quantidade;
    }else if (codigo == 101){
      valor = 2.30;
      return valor * quantidade;
    }else if (codigo == 102){
      valor = 2.60;
      return valor * quantidade;
    }else if (codigo == 103){
      valor = 2.40;
      return valor * quantidade;
    }else if (codigo == 104){
      valor = 2.50;
      return valor * quantidade;
    }else if (codigo == 105){
      valor = 1;
      return valor * quantidade;
    }else{
      return 0;
    }
  }

  public static void Exercicio3(){
    //Exercicio 3

    bool condiLoop = false;

    Console.Write("Candidatos:\n33 - José Couve\n25 - Joana Bravo\n10 - Roberto Nove\n0 - Voto branco\n4 - Voto nulo.\n\nPara sair escolha o numero 1.\n\n");

    int escolha = 0; 
    int cand1 = 0;
    int cand2 = 0;
    int cand3 = 0;
    int branco = 0;
    int nulo = 0;

    while (!condiLoop){
      Console.Write("Insira seu voto ou escolha 1 para sair >> ");
      escolha = int.Parse(Console.ReadLine()); 
      //Votos(escolha,cand1,cand2,cand3,branco,nulo);
       if (escolha == 33){
      cand1 = cand1 + 1;
      Console.Write("Voto efetuado!\n\n");
    }else if (escolha == 25){
      cand2 = cand2 + 1;
      Console.Write("Voto efetuado!\n\n");
    }else if (escolha == 10){
      cand3 = cand3 + 1;
      Console.Write("Voto efetuado!\n\n");
    }else if (escolha == 0){
      branco = branco + 1;
      Console.Write("Voto efetuado!\n\n");
    }else if (escolha == 4){
      nulo = nulo + 1;
      Console.Write("Voto efetuado!\n\n");
    }else{
      Console.Write("Comando Inválido.");
    }
    
    
      
      if (escolha == 1){
        condiLoop = true;
        Console.WriteLine("Votos encerrados!\nJosé Couve >> {0} votos.\nJoana Bravo >> {1} votos.\nRoberto Nove >> {2} votos.\nVotos Brancos >> {3} votos.\nVotos Nulos >> {4} votos.\n",cand1,cand2,cand3,branco,nulo);

    if( (cand1 > cand2) && ( cand1 > cand3 ) ){
      Console.WriteLine("Jose Couve foi o Vencedor!");
    }else if( cand2 > cand3 ){
      Console.WriteLine("Joana Bravo foi o Vencedor!");
    }else if((cand1 == cand2) && (cand2 == cand3)) {
       Console.WriteLine("Empate. Não Houve Vencedor!");
    }else{
      Console.WriteLine("Roberto Nove foi o Vencedor!");
    }
      }
    }

   
}
 
  public static void Main (string[] args) {
   //Exercicio 1

    
    float n1;
    float n2;
    char operador;

    Console.Write("Insira o primeiro valor >> ");
    n1 = float.Parse(Console.ReadLine());

    Console.Write("Insira o segundo valor >> ");
    n2 = float.Parse(Console.ReadLine());

    Console.Write("Insira o operador \n+ para soma\n- para subtração\n* para multiplicação\n/ para divisão >> ");
    operador = char.Parse(Console.ReadLine());

    Console.WriteLine("Operação >> {0} {1} {2} = {3}",n1, operador,n2,Sinal(n1,n2,operador));
    
    Console.WriteLine("===========================================");

    //Exercicio 2

    
    int codigo;
    int quantidade;

    Console.WriteLine ("\nCódigo Produto Preço Unitário (R$)\n---------------------------------\n100   Cachorro quente  R$ 1,70\n101   Bauru Simples    R$ 2,30\n102   Bauru com ovo    R$ 2,60\n103   Hamburguer       R$ 2,40\n104   Cheeseburguer    R$ 2,50\n105   Refrigerante     R$ 1,00\n----------------------------------");

    Console.Write("Insira o código do produto desejado >> ");
    codigo = int.Parse(Console.ReadLine());
    Console.Write("Insira a quantidade >> ");
    quantidade = int.Parse(Console.ReadLine());
    Console.WriteLine("O valor total foi de {0} R$.\n",ValorFinal(codigo, quantidade));
    
    Console.WriteLine("===========================================");

    Exercicio3();

  }
}
