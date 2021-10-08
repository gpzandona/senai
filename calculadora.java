package exercicio;

import java.util.Scanner;

public class calculadora2numeros_unidade4 {
	
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner tec = new Scanner(System.in);
		
		double num1, num2;
		char operador;
		
		System.out.print("Digite um número:");
		num1 = tec.nextDouble();
		
		System.out.print("Digite um operador:");
		operador = tec.next().charAt(0);
		
		System.out.print("Digite outro número:");
		num2 = tec.nextDouble();
		
		switch (operador)
		{
			case '+': 
				operadorSoma(num1, num2);
				break;
			case '-': operadorSubtracao(num1, num2);
				break;
			case '*': operadorMultiplicacao(num1, num2);
				break;
			case '/': operadorDivisao(num1, num2);
				break;
			default:
				System.out.println(" ... Opção inválida ...");
		}
		tec.close();
	}
	
	private static void operadorSoma(double num1, double num2)
	{
		System.out.println("Soma = " + (num1 + num2));
	}
	private static void operadorSubtracao(double num1, double num2)
	{
		System.out.println("Subtracao = " + (num1 - num2));
	}
	private static void operadorMultiplicacao(double num1, double num2)
	{
		System.out.println("Multiplicacao = " + (num1 * num2));
	}
	private static void operadorDivisao(double num1, double num2)
	{
		System.out.println("Divisao = " + (num1 / num2));
	}
	
}
