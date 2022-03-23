using System;
class AlcoolAge
{
  static void Main(string[] args)
  {
    bool managerForm = false;
    while (!managerForm){
    	try{
    	  // Desenha o Menu Inicial
    	  drawMenu();
	      Console.WriteLine("Digite sua Idade: ");
    	  int ageUser = Convert.ToInt32(Console.ReadLine());

    	  if (ageUser >= 18 && ageUser <= 115) {
    	      managerForm = true;
    	      Console.WriteLine("Idade Permitida para Compra de Bebidas Alcoolicas");
	      } else if (ageUser >= 0 && ageUser < 18) {
    	      managerForm = true;
              Console.WriteLine("Idade Não Permitida para Compra de Bebidas Alcoolicas");
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
    Console.WriteLine("Programa de Compra de Bebidas Alcoolicas\n");
    Console.WriteLine("========================================\n");
  }
  static private void showError()
  {
    Console.WriteLine("\nIdade Invalida\n");
    Console.WriteLine("Digite uma Idade Valida (Apenas Numeros)");
    Console.WriteLine("Clique em alguma Tecla para Continuar");
    Console.ReadLine();
  }
}
