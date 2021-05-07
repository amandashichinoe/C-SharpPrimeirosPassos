using System;

namespace loop_while_do_while
{
    class Program
    {
        static void Main(string[] args)
        {
            //valor dado = Random
            //pont = pont -dado
            //if pont = 0 -> morre /perde
            const int pontuacaoInicial = 10;
            int pontuacaoHeroi = pontuacaoInicial;
            int pontuacaoMonstro = pontuacaoInicial;
            Random dado = new Random();
            
            do{
                int ataque = dado.Next(1,11); //ataque =  valor entre 1 e 10
                pontuacaoMonstro -= ataque;
                Console.WriteLine($"Monster was damaged and lost {ataque} health and now has {pontuacaoMonstro} health.");

                if(pontuacaoMonstro <=0) continue;

                ataque = dado.Next(1,11);
                pontuacaoHeroi -= ataque;

                Console.WriteLine($"Hero was damaged and lost {ataque} health and now has {pontuacaoMonstro} health.");


            }while(pontuacaoHeroi > 0 && pontuacaoMonstro >0);

            Console.WriteLine(pontuacaoHeroi > pontuacaoMonstro ? "Hero wins!": "Monster wins!");
        }
    }
}
