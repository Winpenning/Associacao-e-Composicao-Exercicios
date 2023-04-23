using System.Security.Cryptography.X509Certificates;

namespace Associacao_e_Composicao_Exercicios.Entities
{
    internal class PlacaMae
    {
        private string modelo;
        private string descricao;
        List<PenteMemoria> pentememoria;
        List<Fonte> fonte;
        List<Processador> processador;
        public PlacaMae(string modelo, string descricao)
        {
            this.modelo = modelo;
            this.descricao = descricao;
            pentememoria = new List<PenteMemoria>();
            fonte = new List<Fonte>();
            processador = new List<Processador>();
        }

        public void setmodelo(string modelo)
        {
            this.modelo = modelo;
        }
        public string getmodelo()
        {
            return modelo;
        }

        public void setdescricao(string descricao)
        {
            this.descricao = descricao;
        }
        public string getdescricao()
        {
            return descricao;
        }

        public void associarpentememoria(PenteMemoria pentememoria)
        {
            this.pentememoria.Add(pentememoria);
        }
        public void associarfonte(Fonte fonte)
        {
            this.fonte.Add(fonte);
        }
        public void associarprocessador(Processador processador)
        {
            this.processador.Add(processador);
        }

        public int qtdsprocessadores()
        {
            return processador.Count();
        }
        public int qtdspentememoria()
        {
            return pentememoria.Count();
        }
        public double qtdsmemoria()
        {
            double quantidadedememoria = 0;
            foreach (PenteMemoria pentememoria in pentememoria)
            {
                quantidadedememoria += pentememoria.getquantidade();
            }
            return quantidadedememoria;
        }
        public int qtdsfonte()
        {
            return fonte.Count();
        }

        public override string ToString()
        {
            return "\nModelo da placa mae: " + getmodelo() +
                   "\nDescricao: " + getdescricao() +
                   "\nQuantidade de processadores: " + qtdsprocessadores() +
                   "\nQuantidades de pentes de memoria: " + qtdspentememoria() +
                   "\nQuantidade de memoria: " + qtdsmemoria();
        }
    }
}
