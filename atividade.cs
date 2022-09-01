using System;

class program{
        public static void Main(String[] args){

            string nome;
            double salario, anosDeEmpresa;

            Console.Write(" Digite o nome: ");
            nome = Console.ReadLine();

            Console.Write(" Digite a quantos anos voce trabalha:");
            anosDeEmpresa = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o seu salario para ver qual sera o aumento:");
            salario = Convert.ToDouble(Console.ReadLine());

            if (anosDeEmpresa <= 3 && anosDeEmpresa > 0)
            {
                salario = salario * 1.03;
                Console.WriteLine("Seu salario com aumento sera de: R$" + salario + ".00");
            }else if (anosDeEmpresa > 3 && anosDeEmpresa <= 10)
            {
                salario = salario * 1.125;
                Console.WriteLine("\nSeu salario com aumento sera de: R$" + salario + ".00");
            }else if (anosDeEmpresa > 10)
            {
                salario = salario * 1.20;
                Console.WriteLine("Seu salario com aumento sera de: R$" + salario + ".00");
            }

            Console.WriteLine(" Pressione Enter para sair... ");
            Console.ReadLine();

        }
}