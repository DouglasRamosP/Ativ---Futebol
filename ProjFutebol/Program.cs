using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjFutebol
{
    class Program
    {
        static void Main(string[] args)
        {
            Time time1 = new Time("Palmeiras");
            time1.contrararJogador(new Jogador("Alex", 20, 99, 1));
            time1.contrararJogador(new Jogador("Pedro", 22, 96, 2));
            time1.contrararJogador(new Jogador("Leandro", 27, 91, 3));
            time1.contrararJogador(new Jogador("Bruno", 21, 90, 4));
            time1.contrararJogador(new Jogador("Jorge", 23, 92, 5));
            time1.contrararJogador(new Jogador("Eleno", 30, 97, 6));
            time1.contrararJogador(new Jogador("Rodrigo", 33, 80, 7));
            time1.contrararJogador(new Jogador("Antônio", 29, 88, 8));
            time1.contrararJogador(new Jogador("Migel", 25, 79, 9));
            time1.contrararJogador(new Jogador("Luciano", 28, 90, 10));
            time1.contrararJogador(new Jogador("Alencar", 38, 95, 11));

            Time time2 = new Time("Santos");
            time2.contrararJogador(new Jogador("Juliano", 20, 99, 1));
            time2.contrararJogador(new Jogador("Matias", 22, 96, 2));
            time2.contrararJogador(new Jogador("Roberto", 27, 91, 3));
            time2.contrararJogador(new Jogador("Carlos", 21, 90, 4));
            time2.contrararJogador(new Jogador("Renato", 23, 92, 5));
            time2.contrararJogador(new Jogador("Fabiano", 30, 97, 6));
            time2.contrararJogador(new Jogador("Regis", 33, 80, 7));
            time2.contrararJogador(new Jogador("Otavio", 29, 88, 8));
            time2.contrararJogador(new Jogador("Marcio", 25, 79, 9));
            time2.contrararJogador(new Jogador("Wilson", 28, 90, 10));
            time2.contrararJogador(new Jogador("Marcos", 38, 95, 11));

            Partida p1 = new Partida(DateTime.Now, time1, time2);
            p1.jogar();
            Console.WriteLine(p1.getPlacar());

            Console.WriteLine(time1.getStatus());
            time1.getDescricaoJogadores();

            Console.WriteLine(time2.getStatus());
            time2.getDescricaoJogadores();

            Console.ReadKey();
        }
    }
}
