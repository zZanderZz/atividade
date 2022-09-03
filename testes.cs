using System;
 
class Programa{
 
    static void Main(string[] args){
 
        int num = 1, div = 0, contador = 1;
 
        while(contador <= 6){
            Console.Write("Digite o " + contador + " numero: ");
            contador++;
            
            num = int.Parse(Console.ReadLine());
            div = num % 2;
 
            if (div == 0){
            Console.WriteLine("O numero e par.. ");
            }else{
            Console.WriteLine("Ele e impar..");
            }
 
        }
 
                    Console.WriteLine("Aperte enter para sair..");
                    Console.ReadLine();
    }
}