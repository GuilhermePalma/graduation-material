using System;
class LowerNumber
{
  /** 20) Faça um algoritmo para encontrar o menor número num conjunto de 3
  dados, fornecidos pelo usuário. A saída deve apresentar este menor número
  encontrado. */
  static void Main(string[] args)
  {
    bool managerForm = false;
    while (!managerForm){
    	try{
    	  // Desenha o Menu Inicial
    	  drawMenu();
	      Console.WriteLine("Digite o 1° Numero: ");
    	  int numberOne = Convert.ToInt32(Console.ReadLine());
	      Console.WriteLine("Digite o 2° Numero: ");
    	  int numberTwo = Convert.ToInt32(Console.ReadLine());
	      Console.WriteLine("Digite o 3° Numero: ");
    	  int numberThree = Convert.ToInt32(Console.ReadLine());

	      int[] numbersArray = new int[3] {numberOne,numberTwo,numberThree};
	      Array.Sort(numbersArray);

	      Console.WriteLine("Menor Numero Informado: " + numbersArray[0]);
          managerForm = true;
    	}
    	catch{
    	  showError();
    	}
      }
  }
  static private void drawMenu()
  {
    Console.Clear();
    Console.WriteLine("Programa de Verificação do Menor Numero\n");
    Console.WriteLine("=======================================\n");
  }
  static private void showError()
  {
    Console.WriteLine("\nNumeros Invalidos\n");
    Console.WriteLine("Digite um Numero Inteiros e Validos");
    Console.WriteLine("Clique em alguma Tecla para Continuar");
    Console.ReadLine();
  }
}
