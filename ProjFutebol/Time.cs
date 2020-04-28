using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjFutebol
{
    class Time
    {
        private string nome;
        private Int32 vitorias;
        private Int32 derrotas;
        private Int32 empates;
        private List<Jogador> jogadores;

        public Time (string Nome)
        {
            this.nome = Nome;
            this.vitorias = 0;
            this.derrotas = 0;
            this.empates = 0;
            this.jogadores = new List<Jogador>();
        }

        public string Nome
        {
            get { return nome; }
        }

        public string getStatus()
        {
            return "O status do time " + this.Nome +
                " E Vitorias:" + this.Vitorias +
                "\tDerrotas:" + this.Derrotas +
                "\tEmpates: " + this.empates;
        }

        public Int32 Vitorias
        {
            get { return vitorias; }
            set { vitorias += value; }
        }

        public Int32 Derrotas
        {
            get { return derrotas; }
            set { derrotas += value; }
        }

        public Int32 Empates
        {
            get { return empates; }
            set { empates += value; }
        }

        public void contrararJogador(Jogador J)
        {
            this.jogadores.Add(J);
        }

        private string demitirJogador(Jogador J)
        {
            int buscarJogador = this.jogadores.IndexOf(J);

            string strRetorno = "jogador" + J.getNome();
            if (buscarJogador != -1)
            {
                this.jogadores.RemoveAt(buscarJogador);
                return strRetorno + "demitido.";
            }
            return "Não foi possível demitir " + strRetorno;
        }

        private Jogador getJogador(int camisa)
        {
            return jogadores.Find(j => j.getCamisa().Equals(camisa));
        }

        public void gol(int camisa)
        {
            this.getJogador(camisa).Gols = 1;
        }

        public void getDescricaoJogadores()
        {
            foreach(Jogador jog in jogadores)
            {
                Console.WriteLine(jog.getDescricao());
            }
        }






    }
}
