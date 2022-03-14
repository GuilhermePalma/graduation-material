using System;
class PasswordProgram
{
  static void Main(string[] args)
  {
    bool managerForm = false;
    while (!managerForm){
    	try{
    	  // Desenha o Menu Inicial
    	  drawMenu();
	      Console.WriteLine("Digite uma Opção (0 ou 1): ");
    	  int option =  Convert.ToInt32(Console.ReadLine());

    	  if (option == 0) {
    	      managerForm = true;
    	      Console.WriteLine("Opção Selecionada: Falso");
	      } else if (option == 1) {
    	      managerForm = true;
    	      Console.WriteLine("Opção Selecionada: Verdadeiro");
    	  } else {
    	      showError();
    	  }
    	}
    	catch{
    	  showError();
    	}
      }
  }
  static private void drawMenu()
  {
    Console.Clear();
    Console.WriteLine("Programa de Tomada de Decisão (IF-ELSE)\n");
    Console.WriteLine("==================");
    Console.WriteLine("|    0 - Falso   |");
    Console.WriteLine("|    1 - True    |");
    Console.WriteLine("==================");
  }
  static private void showError()
  {
    Console.WriteLine("\nOpção Invalida\n");
    Console.WriteLine("Selecione os Numeros 0 ou 1");
    Console.WriteLine("Clique em alguma Tecla para Continuar");
    Console.ReadLine();
  }
}
