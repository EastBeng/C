using System;

class MainClass {
  public static void Main (string[] args) {
    
    Pessoa x = new Pessoa();
    Lista y = new Lista();

		int opcao = 0;

    bool cond = false;

    Console.Write("Insira seu nome >> ");
    string nome = Console.ReadLine();

    Console.WriteLine("\nOlá {0}. Bem vindo ao AddNotes! O intuito deste aplicativo é fazer a adição de notas a um contato que você deseja.\n", nome);

    

		while(opcao == 0 || opcao == 1 || opcao == 2 || opcao == 3 || opcao == 4){
      Console.WriteLine(@"-----------------Menu-----------------
        Digite:
        1 - Adicionar contato e anotação.
        2 - Excluir um contato.
        3 - Buscar um contato.
        4 - Mostrar contatos.
        5 - Finalizar sistema.");

      try{
        Console.Write("\nOpçao >> ");
        opcao = int.Parse(Console.ReadLine());
        if(opcao == 1) {
          while(!cond){

            try{
              Console.Write("\nNome da pessoa >> ");
              nome = Console.ReadLine();

              Console.Write("Numero >> ");
              string num = Console.ReadLine();

              Console.Write("Deseja inserir uma anotação a esse número?s/n >> ");
              string cond2 = Console.ReadLine();

              if(cond2 == "s"){
                Console.Write("Anotação >> ");
                string o = Console.ReadLine();
                x = new Pessoa(nome, num, o);
                y.agenda.Add(x);

              }else{
                x = new Pessoa(nome, num);
                y.agenda.Add(x);
              }

              Console.Write("Deseja continuar adicionando pessoas?s/n >> ");
              string cond3 = Console.ReadLine();

              if(cond3 == "n" || cond3 == "n"){
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Cadastro/s feito com sucesso.\n");
                Console.ForegroundColor = ConsoleColor.White;
                cond = true;
          
            }


            }catch (ArgumentException){
              Console.WriteLine("Ops! Algo deu errado!");
            }

          }
        }if(opcao == 2){
          if(y.agenda.Count == 0){
            Console.WriteLine("Adicione um contato antes de exclui-lo.");
          }else{
            Console.Write("Digite o nome do contato que deseja excluir >> ");
            string nomeexclu = Console.ReadLine();

            int tamanho = y.agenda.Count;

            for(int i = 0; i < y.agenda.Count; i++){ 
              if(nomeexclu == y.agenda[i].GetNome()){
                y.agenda.Remove(y.agenda[i]);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Excluido com sucesso.\n");
                Console.ForegroundColor = ConsoleColor.White;
                }
            }
            if(tamanho == y.agenda.Count){
              Console.Write("Contato não encontrado!");
            }

          }
        
          
        }if(opcao == 3){
          if(y.agenda.Count == 0){
            Console.WriteLine("Adicione um contato antes de buscar.");
          }else{
            Console.Write("Digite o nome do contato que deseja buscar >> ");
          string nomebuscar = Console.ReadLine();

          for(int i = 0; i < y.agenda.Count; i++){ 
            if(nomebuscar== y.agenda[i].GetNome()){
              Console.Write("\nNome >> {0}\nNumero >> {1}\nObs >> {2}\n",y.agenda[i].GetNome(), y.agenda[i].GetNumero(), y.agenda[i].GetObs());
              }
            }
          }
          
          
        }if(opcao == 4){
          if(y.agenda.Count == 0){
            Console.WriteLine("Adicione um contato antes de mostra-los.");
          }else{
          /*
					foreach(Pessoa c in y.agenda
					{
							Console.WriteLine("\nNome >> {0}\nNumero >> {1}\nObs >> {2}\n",c.nome,c.numero,c.observacao);
					}*/
            for(int i = 0; i < y.agenda.Count; i++){
        Console.Write("\nNome >> {0}\nNumero >> {1}\nObs >> {2}\n",y.agenda[i].GetNome(), y.agenda[i].GetNumero(), y.agenda[i].GetObs());
            }
          }
          
      
        }if(opcao == 5){
          Console.WriteLine("Sistema Finalizado.");
          Environment.Exit(0);
        }

        Console.WriteLine("\nDeseja Continar No sistema? s/n>>");
        string var1 = Console.ReadLine();

        if(var1 == "s" || var1 == "S"){
          Console.Clear();
          continue;
        }else{
          Console.WriteLine("\nSistema Finalizado.");
          Environment.Exit(0);
      }
      }catch(Exception){
        Console.Write("\nAlgo deu errado!\n");
      }
      

		}  
  }
}
