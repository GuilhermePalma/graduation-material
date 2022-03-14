using System;
/**
PROGRAMA SENHA: Desenvolva um algoritmo que solicita nome de usuário e senha.
Se ambos estiverem corretos (financeiro/303010) é exibida a mensagem
“SEJA BEM-VINDO!” caso contrário, a mensagem “ACESSO NEGADO” é exibida.
*/
class PasswordProgram
{
  static void Main(string[] args)
  {
    bool managerForm = false;
    while (!managerForm){
    	try{
    	  // Desenha o Menu Inicial
          Console.Clear();
          Console.WriteLine("Programa de Login\n");
          Console.WriteLine("==========================");
          Console.WriteLine("Insira seus Dados de Login\n");
          Console.WriteLine("Usuario: ");
    	  String user =  Console.ReadLine();
          Console.WriteLine("Senha: ");
    	  String password =  Console.ReadLine();
          Console.WriteLine("==========================");

    	  if (user == "financeiro" && password == "303010") {
    	      managerForm = true;
    	      Console.WriteLine("SEJA BEM-VINDO!");
    	  } else {
    	      showError();
    	  }
    	}
    	catch{
    	  showError();
    	}
      }
  }

  static private void showError()
  {
    Console.WriteLine("\nUsuario Invalido\n");
    Console.WriteLine("ACESSO NEGADO !");
    Console.WriteLine("Clique em alguma Tecla para Continuar");
    Console.ReadLine();
  }
}
