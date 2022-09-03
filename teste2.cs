using System;
 
class Programa{
 
static void Main(string[] args){
 
int contadorProdutos = 8, maior = 0, menor = 99999999, i = 1;
 
Console.WriteLine("digite o preco de 8 produtos..");
 
for(i = 1; i <= 8; i++){
Console.Write("Informe o "+ i +"º preço: ");
contadorProdutos = int.Parse(Console.ReadLine());
 
if (contadorProdutos < menor){
menor = contadorProdutos;
}
if (contadorProdutos > maior){
maior = contadorProdutos;
}
}
 
Console.WriteLine("\nMaior número: " + maior);
Console.Write("Menor número: " + menor + "\n");
 
Console.WriteLine("Aperte enter para sair..");
Console.ReadLine();
 
}
}
