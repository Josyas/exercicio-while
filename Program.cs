using System;

namespace Exercicio_while {
    class Program {
        static void Main(string[] args) {
            

            Console.WriteLine("1 Álcool ");
            Console.WriteLine("2 Gasolina ");
            Console.WriteLine("3 Diesel ");
            Console.WriteLine("4 Sair ");
            Console.WriteLine("Escolha uma opção: ");
            int escolha = int.Parse(Console.ReadLine());
           

            int cont1 = 0;
            int cont2 = 0;
            int cont3 = 0;
            while (escolha != 4) {
                
                if (escolha == 1) {
                    Console.WriteLine("Álcool");
                    cont1++;
                }
                else if (escolha == 2) {
                    Console.WriteLine("Gasolina");
                    cont2++;
                } else {
                    Console.WriteLine("Diesel");
                    cont3++;
                }
                Console.WriteLine("Escolha outra opção: ");
                escolha = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("Muito obrigado!!!");
            Console.WriteLine($"Álcool {cont1}");
            Console.WriteLine($"Gasolina {cont2}");
            Console.WriteLine($"Diesel {cont3}");
            

        }
    }
}
