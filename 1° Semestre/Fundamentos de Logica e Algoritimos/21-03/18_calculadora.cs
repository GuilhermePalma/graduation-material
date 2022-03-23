using System;
class Calculater
{
  /** 18) Faça um algoritmo em que o usuário informa uma operação matemática e
      dois números, então o algoritmo exibe o resultado da expressão.
      (expressão aceita +, - , *, /) */
  static void Main(string[] args)
  {
    bool managerForm = false;
    while (!managerForm){
    	try{
    	  // Desenha o Menu Inicial
    	  drawMenu();
	      Console.WriteLine("Digite o 1° Numero: ");
    	  double numberOne = Convert.ToInt32(Console.ReadLine());
	      Console.WriteLine("Digite o 2° Numero: ");
    	  double numberTwo = Convert.ToInt32(Console.ReadLine());
	      Console.WriteLine("Digite a  Operação: ");
    	  string opereration = Console.ReadLine();

	      switch(opereration){
	          case "+":
        	    Console.WriteLine("\nResultado: " + (numberOne+numberTwo));
                managerForm = true;
	            break;
	          case "-":
        	    Console.WriteLine("\nResultado: " + (numberOne-numberTwo));
                managerForm = true;
	            break;
	          case "*":
        	    Console.WriteLine("\nResultado: " + (numberOne*numberTwo));
                managerForm = true;
	            break;
	          case "/":
	            if(numberTwo == 0){
        	      Console.WriteLine("Não é Possivel Divisão por Zero (2° Numero é Zero)");
    	          showError();
	            } else{
        	      Console.WriteLine("\nResultado: " + (numberOne/numberTwo));
                  managerForm = true;
	            }
	            break;
	          default:
	            showError();
	            break;
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
    Console.WriteLine("Programa de Calculadora\n");
    Console.WriteLine("=======================\n");
  }

  static private void showError()
  {
    Console.WriteLine("\nIdade Invalida\n");
    Console.WriteLine("Digite uma Operação (+, -, *, /) e Numeros Validos (Aceita Decimais)");
    Console.WriteLine("Clique em alguma Tecla para Continuar");
    Console.ReadLine();
  }
}
