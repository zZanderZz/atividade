using System;

class programa{
    public static void Main(string[] args){
        string tipoCarro;
        double kmPercorrido, valorAluguel;
        int diasCarro;
        
        Console.Write("Digite o tipo de veiculo: ");
        tipoCarro = Console.ReadLine();

        Console.Write("Quantos dias ficou com veiculo: ");
        diasCarro = int.Parse(Console.ReadLine());

        Console.Write("Quantos quilometros foram percorridos com o veiculo: ");
        kmPercorrido = double.Parse(Console.ReadLine());
    

        if(tipoCarro == "popular"){
            valorAluguel = 90 * diasCarro;

            if( kmPercorrido > 100){
                valorAluguel = valorAluguel + (0.10 * kmPercorrido); 
                Console.WriteLine("O valor a ser pago sera de " + valorAluguel);
            }else{
                valorAluguel = valorAluguel + (0.20 * kmPercorrido); 
                Console.WriteLine("O valor a ser pago sera de " + valorAluguel);
            }
        }
        
        
        if(tipoCarro == "luxo"){
            valorAluguel = 150 * diasCarro;
        if( kmPercorrido > 200){
            valorAluguel = valorAluguel + (0.25 * kmPercorrido); 
            Console.WriteLine("O valor a ser pago sera de " + valorAluguel);
        }else{
            valorAluguel = valorAluguel + (0.30 * kmPercorrido); 
            Console.WriteLine("O valor a ser pago sera de " + valorAluguel);
        }
        }
       
        
        Console.WriteLine("Pressione enter para sair...");
        Console.ReadLine();
        
    }
}