using System;
/**
PROGRAMA NOTA: Desenvolva um programa que pede 2 notas do aluno.
Se a média das notas for maior ou igual a 7,0 exibe a mensagem “APROVADO”, caso contrário o programa
exibe a mensagem “REPROVADO”.
*/
class NoteProgram
{
  static void Main(string[] args)
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
            showError("A Nota 1 tem que estar entre 0.0 e 10.0");
    	  } else if (note2 > 10 || note2 < 0) {
            showError("A Nota 2 tem que estar entre 0.0 e 10.0");
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
    	  showError("Insira um Numero Valido");
    	}
      }
  }

  static private void showError(String error)
  {
    Console.WriteLine("\nMedia Invalida\n");
    Console.WriteLine(error);
    Console.WriteLine("Clique em alguma Tecla para Continuar");
    Console.ReadLine();
  }
}
