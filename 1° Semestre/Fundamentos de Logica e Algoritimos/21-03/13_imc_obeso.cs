using System;
class ImcProgram
{
    /**Uma pessoa está obesa se seu IMC (peso dividido pela altura ao quadrado)
    é superior a 30. Dados o peso e a altura de uma pessoa, informe se ela está obesa*/
  static void Main(string[] args)
  {
    bool managerForm = false;
    while (!managerForm){
    	try{
    	  // Desenha o Menu Inicial
    	  drawMenu();
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
    Console.WriteLine("Programa de Verificação de Obesidade\n");
    Console.WriteLine("========================================\n");
  }
  static private void showError()
  {
    Console.WriteLine("\nPeso ou Idade Invalidos\n");
    Console.WriteLine("Digite um Peso ou Idade Validos");
    Console.ReadLine();
  }
}
