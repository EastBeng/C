using System;

class Apresentacao{

  private char sexo;
  private int escolha;

  public static void Abertura(){

    Console.WriteLine("\nOlá, Bem vindo ao GymAtHome! Esse é um projeto para você que quer se \nmanter saudavel, aqui você encontra diversos exercicios para diversas \npartes do corpo, basta escolher qual parte você deseja exercitar no \nmenu abaixo.\n");
  }

  public void Sexo(){
    bool condicao = false;

    Console.Write("Primeiramente indique o seu sexo(F para Feminino ou M para Masculino)>> ");
    sexo = char.Parse(Console.ReadLine());
    Console.Clear();

    while(!condicao){
      if (sexo == 'M' || sexo == 'm'){
        MenuMasculino();
        condicao = true;

      }else if (sexo == 'F' || sexo == 'f'){
        MenuFeminino();
        condicao = true;

      }else{
          Console.WriteLine("Erro. Sexo não encontrado.");
          Console.WriteLine("Insira novamente o seu sexo >> ");
          sexo = char.Parse(Console.ReadLine());
          Console.Clear();
        }
    }
  }


  public void MenuMasculino(){
    bool condicao = false;
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("------------------------ Menu Masculino ------------------------\n1 - Exercicios Para a Parte Superior do Corpo(Braço, Costas e Abdomen).\n2 - Exercicios Para a Parte Inferior do Corpo(Perna e Panturrilhas).\n");

    Console.Write("Qual treino voce deseja realizar?(1 ou 2) >> ");
    escolha = int.Parse(Console.ReadLine());
    

    while(!condicao){
      if (escolha == 1){
        Console.Clear();
        Exercicios.Explica();
        Exercicios.ExerciciosSuperiorMasculino();
        condicao = true;

      }else if(escolha == 2){
        Console.Clear();
        Exercicios.Explica();
        Exercicios.ExerciciosInferiorMasculino(); 
        condicao = true; 

      }else{
        Console.WriteLine("\nTreino invalido.");
        Console.Write("Por favor insira outro treino >> ");
        escolha = int.Parse(Console.ReadLine());
        Console.Clear();
      }
    }
  }

  public void MenuFeminino(){
    bool condicao = false;
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("------------------------ Menu Feminino ------------------------\n1 - Exercicios Para a Parte Superior do Corpo(Abdomen).\n2 - Exercicios Para a Parte Inferior do Corpo(Perna e Panturrilhas).\n");

    Console.Write("Qual treino voce deseja realizar?(1 ou 2) >> ");
    escolha = int.Parse(Console.ReadLine());

    while(!condicao){
      if (escolha == 1){
        Console.Clear();
        Exercicios.Explica();
        Exercicios.ExerciciosSuperiorFeminino();
        condicao = true;

      }else if(escolha == 2){
        Console.Clear();
        Exercicios.Explica();
        Exercicios.ExerciciosInferiorFeminino(); 
        condicao = true;

      }else{
        Console.WriteLine("\nTreino invalido.");
        Console.Write("Por favor insira outro treino >> ");
        escolha = int.Parse(Console.ReadLine());
        Console.Clear();
      }
    }
    
  }

}
