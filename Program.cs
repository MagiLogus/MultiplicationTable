// Faça um programa que receba um número inteiro e mostre a sua tabuada.

//Entrada
Console.WriteLine($"Insira um número inteiro: ");
int numero = int.Parse(Console.ReadLine());

Console.WriteLine($"Tabuada de {numero}");

//Processamento
for (int i = 0; i <=10; i++)
{
Console.WriteLine($"{numero} X {i} = {numero*i}");
}
//Saida

