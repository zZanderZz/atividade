using System;

   class Programa{

    static void Main(string[] args)
	{ 
        int compri1, compri2, compri3;
        
        
         Console.WriteLine("digite um lado do triangulo:");
         compri1 = int.Parse(Console.ReadLine());

         Console.WriteLine("digite outro lado do triangulo:");
         compri2 = int.Parse(Console.ReadLine());

         Console.WriteLine("digite mais um lado:");
         compri3 = int.Parse(Console.ReadLine());


         if(compri1 == compri2 && compri1 == compri3){
            Console.WriteLine("ele e equilatero");

            }else if(compri1 == compri2  && compri1 != compri3){
                Console.WriteLine("ele e isosceles");
            }else{
                Console.WriteLine("ele e escaleno");
            }
     

         
         Console.WriteLine("Aperte enter para sair..");
        Console.ReadLine();
    }
	}