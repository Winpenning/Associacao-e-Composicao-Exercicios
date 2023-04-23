using System.Security.Cryptography.X509Certificates;

namespace Associacao_e_Composicao_Exercicios.Entities
{
    class Processador
    {
        private string modelo;
        private double frequencia;
        public double cache;

        public Processador(string modelo, double frequencia, double cache)
        {
            this.modelo = modelo;
            this.cache = frequencia;
            this.cache = cache;
        }

        public void setmodelo(string modelo)
        {
            this.modelo = modelo;
        }
        public string getmodelo()
        {
            return this.modelo;
        }
        public double getfrequencia()
        {
            return this.cache;
        }
        public void setfrequencia(double frequencia)
        {
            this.frequencia = frequencia;
        }
        public double getcache()
        {
            return this.cache;
        }
        public void setcache(double cache)
        {
            this.cache = cache;
        }

        public override string ToString()
        {
            return "\nModelo do processador: " + getmodelo()+
                   "\nFrequencia do processador: " + getfrequencia()+
                   "\nCache do processador: " + getcache();
        }
    }
}
