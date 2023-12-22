using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generator
{
    internal class Number
    {
        public enum Resultado
        {
            Ganhar, PerderMaior, PerderMenor
        }

        public Resultado Jogar(int numeroJogador, int numeroGerado)
        {
            int numeroPlayer = numeroJogador;

            if (numeroPlayer < numeroGerado)
            {
                return Resultado.PerderMenor;
            }
            else if (numeroPlayer > numeroGerado)
            {
                return Resultado.PerderMaior;
            } else
            {
                return Resultado.Ganhar;
            }
        }

        public int Numero()
        {
            Random random = new Random();
            return random.Next(99);
        }

        

    }
}
