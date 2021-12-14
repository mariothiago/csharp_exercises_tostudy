/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
    int peca1 = 12;
    int numPecas1 = 1;
    double valorPeca1 = 5.30;
    double valor1 = valorPeca1 * numPecas1;
    
    int peca2 = 16;
    int numPecas2 = 2;
    double valorPeca2 = 5.10;
    double valor2 = valorPeca2 * numPecas2;
    
    double valorTotal = valor1 + valor2;
    
    Console.WriteLine($"VALOR A PAGAR: R${valorTotal}");
  }
}