using System;

class HelloWorld 
{
  static void Main() 
  {
    int funcionario = 25;
    int horasTrabalhadas = 100;
    double salarioHora = 5.50;
    double salario = (salarioHora * horasTrabalhadas);
    
    Console.WriteLine($"Número do funcionário: {funcionario}");
    Console.WriteLine($"Salário = U${salario}");
  }
}