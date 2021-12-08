using System;

class HelloWorld {
  static void Main() {
    double nota1 = 5.0;
    double nota2 = 7.1;
    
    double notaPeso1 = nota1 * 3.5; 
    double notaPeso2 = nota2 * 7.5;
    
    double media = (notaPeso1 + notaPeso2) / 11;
    Console.WriteLine($"Média = {media}");
  }
}