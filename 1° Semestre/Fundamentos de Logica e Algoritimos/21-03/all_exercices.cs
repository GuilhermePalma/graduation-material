// https://onlinegdb.com/87mghuF8g
using System;
class ListExercices
{

  static void Main(string[] args){
    bool managerForm = false;
    while (!managerForm){
        // Desenha o Menu Inicial
        Console.Clear();
        Console.WriteLine("Escolha o Exercicio Desejado\n");
        Console.WriteLine("============================");
        Console.WriteLine("             12             ");
        Console.WriteLine("             13             ");
        Console.WriteLine("             14             ");
        Console.WriteLine("             15             ");
        Console.WriteLine("             18             ");
        Console.WriteLine("             20             ");
        Console.WriteLine("============================");

        Console.WriteLine("Opção Escolhida: ");
        string option = Console.ReadLine();
        switch(option){
            case "12":
              managerForm = true;
              exercice12();
              break;
            case "13":
              managerForm = true;
              exercice13();
              break;
            case "14":
              managerForm = true;
              exercice14();
              break;
            case "15":
              managerForm = true;
              exercice15();
              break;
            case "18":
              managerForm = true;
              exercice18();
              break;
            case "20":
              managerForm = true;
              exercice20();
              break;
            default:
              Console.WriteLine("Escolha entre as Opções '12','13','14','15','18','20'\n");
              Console.ReadLine();
              break;
        }
    }





  }

  static void exercice12()
  {
    bool managerForm = false;
    while (!managerForm){
    	try{
    	  // Desenha o Menu Inicial
          Console.Clear();
          Console.WriteLine("Programa de Compra de Bebidas Alcoolicas\n");
          Console.WriteLine("========================================\n");

          Console.WriteLine("Digite sua Idade: ");
    	  int ageUser = Convert.ToInt32(Console.ReadLine());

    	  if (ageUser >= 18 && ageUser <= 115) {
    	      managerForm = true;
    	      Console.WriteLine("Idade Permitida para Compra de Bebidas Alcoolicas");
	      } else if (ageUser >= 0 && ageUser < 18) {
    	      managerForm = true;
              Console.WriteLine("Idade Não Permitida para Compra de Bebidas Alcoolicas");
    	  } else {
              Console.WriteLine("\nIdade Invalida\n");
              Console.WriteLine("Digite uma Idade Valida (Apenas Numeros)");
              Console.WriteLine("Clique em alguma Tecla para Continuar");
              Console.ReadLine();
    	  }
    	}
    	catch{
            Console.WriteLine("\nIdade Invalida\n");
            Console.WriteLine("Digite uma Idade Valida (Apenas Numeros)");
            Console.WriteLine("Clique em alguma Tecla para Continuar");
            Console.ReadLine();
    	}
      }
  }

  /** 13) Uma pessoa está obesa se seu IMC (peso dividido pela altura ao quadrado)
      é superior a 30. Dados o peso e a altura de uma pessoa, informe se ela está obesa*/
  static void exercice13()
  {
    bool managerForm = false;
    while (!managerForm){
    	try{
    	  // Desenha o Menu Inicial
          Console.Clear();
          Console.WriteLine("Programa de Verificação de Obesidade\n");
          Console.WriteLine("====================================\n");

	      Console.WriteLine("Digite sua Altura: ");
    	  double height = Double.Parse(Console.ReadLine());
	      Console.WriteLine("Digite seu Peso: ");
    	  double weight =  Double.Parse(Console.ReadLine());

    	  if (height > 0 && weight > 0) {
    	      double imc = weight/(height*height);
    	      if(imc > 30){
    	          Console.WriteLine("\nIMC Obeso");
    	      } else{
    	          Console.WriteLine("\nIMC Não Obeso");
    	      }
    	      managerForm = true;
    	  } else {
            Console.WriteLine("\nPeso ou Idade Invalidos\n");
            Console.WriteLine("Digite um Peso ou Idade Validos");
            Console.ReadLine();
    	  }
    	}
    	catch{
          Console.WriteLine("\nPeso ou Idade Invalidos\n");
          Console.WriteLine("Digite um Peso ou Idade Validos");
          Console.ReadLine();
    	}
      }
  }

  static void exercice14()
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
            Console.WriteLine("\nUsuario Invalido\n");
            Console.WriteLine("ACESSO NEGADO !");
            Console.WriteLine("Clique em alguma Tecla para Continuar");
            Console.ReadLine();
    	  }
    	}
    	catch{
            Console.WriteLine("\nUsuario Invalido\n");
            Console.WriteLine("ACESSO NEGADO !");
            Console.WriteLine("Clique em alguma Tecla para Continuar");
            Console.ReadLine();
    	}
      }
  }

  static void exercice15()
  {
    bool managerForm = false;
    while (!managerForm){
    	try{
    	  // Desenha o Menu Inicial
          Console.Clear();
          Console.WriteLine("Programa de Aprovaçõa da Media\n");
          Console.WriteLine("==========================");
          Console.WriteLine("Insira suas Notas\n");

          Console.WriteLine("Nota 1: ");
    	  double note1 =  Double.Parse(Console.ReadLine());
          Console.WriteLine("Nota 2: ");
    	  double note2 =  Double.Parse(Console.ReadLine());
          Console.WriteLine("==========================");

    	  if (note1 > 10 || note1 < 0) {
            Console.WriteLine("\nMedia Invalida\n");
            Console.WriteLine("A Nota 1 tem que estar entre 0.0 e 10.0");
            Console.WriteLine("Clique em alguma Tecla para Continuar");
            Console.ReadLine();
    	  } else if (note2 > 10 || note2 < 0) {
            Console.WriteLine("\nMedia Invalida\n");
            Console.WriteLine("A Nota 2 tem que estar entre 0.0 e 10.0");
            Console.WriteLine("Clique em alguma Tecla para Continuar");
            Console.ReadLine();
    	  }else {
            managerForm = true;
            double media = (note1+note2)/2;

            if(media >= 7){
                Console.WriteLine("\nAPROVADO!");
            }else{
                Console.WriteLine("\nREPROVADO!");
            }
    	  }
    	}
    	catch{
            Console.WriteLine("\nMedia Invalida\n");
            Console.WriteLine("Insira um Numero Valido");
            Console.WriteLine("Clique em alguma Tecla para Continuar");
            Console.ReadLine();
    	}
      }
  }

  /** 18) Faça um algoritmo em que o usuário informa uma operação matemática e
      dois números, então o algoritmo exibe o resultado da expressão.
      (expressão aceita +, - , *, /) */
  static void exercice18()
  {
    bool managerForm = false;
    while (!managerForm){
    	try{
    	  // Desenha o Menu Inicial
          Console.Clear();
          Console.WriteLine("Programa de Calculadora\n");
          Console.WriteLine("=======================\n");

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
                  Console.WriteLine("\nIdade Invalida\n");
                  Console.WriteLine("Digite uma Operação (+, -, *, /) e Numeros Validos (Aceita Decimais)");
                  Console.WriteLine("Clique em alguma Tecla para Continuar");
                  Console.ReadLine();
	            } else{
        	      Console.WriteLine("\nResultado: " + (numberOne/numberTwo));
                  managerForm = true;
	            }
	            break;
	          default:
                Console.WriteLine("\nIdade Invalida\n");
                Console.WriteLine("Digite uma Operação (+, -, *, /) e Numeros Validos (Aceita Decimais)");
                Console.WriteLine("Clique em alguma Tecla para Continuar");
                Console.ReadLine();
	            break;
	      }
    	}
    	catch{
          Console.WriteLine("\nIdade Invalida\n");
          Console.WriteLine("Digite uma Operação (+, -, *, /) e Numeros Validos (Aceita Decimais)");
          Console.WriteLine("Clique em alguma Tecla para Continuar");
          Console.ReadLine();
    	}
      }
  }

  /** 20) Faça um algoritmo para encontrar o menor número num conjunto de 3
  dados, fornecidos pelo usuário. A saída deve apresentar este menor número
  encontrado. */
  static void exercice20()
  {
    bool managerForm = false;
    while (!managerForm){
    	try{
    	  // Desenha o Menu InicialConsole.Clear();
          Console.WriteLine("Programa de Verificação do Menor Numero\n");
          Console.WriteLine("=======================================\n");

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
          Console.WriteLine("\nNumeros Invalidos\n");
          Console.WriteLine("Digite um Numero Inteiros e Validos");
          Console.WriteLine("Clique em alguma Tecla para Continuar");
          Console.ReadLine();
    	}
      }
  }
}